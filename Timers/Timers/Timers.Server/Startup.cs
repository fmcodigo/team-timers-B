using Microsoft.AspNetCore.Blazor.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Linq;
using System.Net.Mime;
using Timers.Shared.Models;
using Timers.Shared.Repositories;
using AutoMapper;

namespace Timers.Shared
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddServerSideBlazor<Client.Startup>();
            
            services.TryAddSingleton<IRepository<Game>, MemoryGameRepository>();
            services.TryAddSingleton<IRepository<GameSetting>, MemoryGameSettingRepository>();
            services.TryAddSingleton<IPlayerRepository<Player>, MemoryPlayerRepository>();
            services.TryAddSingleton<IRepository<Team>, MemoryTeamRepository>();
            //services.TryAddSingleton<IGameService, GameService>();

            services.AddMvc();
            
            var config = new MapperConfiguration(c =>
            {
                c.AddProfile(new AutomapperProfile());
            });
            services.AddSingleton<IMapper>(s => config.CreateMapper());
            //services.AddAutoMapper(c => c.AddProfile(new AutomapperProfile()));

            services.AddResponseCompression(options =>
            {
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
                {
                    MediaTypeNames.Application.Octet,
                    WasmMediaTypeNames.Application.Wasm,
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseResponseCompression();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller}/{action}/{id?}");
            });

            //app.UseBlazor<Client.Program>();
            // Use component registrations and static files from the app project.
            app.UseServerSideBlazor<Client.Startup>();
        }
    }
}
