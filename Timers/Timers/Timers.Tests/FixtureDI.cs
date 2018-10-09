using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Timers.Shared;
using Timers.Shared.Repositories;
using Timers.Shared.Services;
using Timers.Shared.Models;
using System;
using Xunit;

namespace Timers.Tests
{
    public class FixtureDI : IDisposable
    {
        public IServiceProvider ServiceProvider { get; private set; }
        public FixtureDI()
        {
            IServiceCollection services = new ServiceCollection();

            services.TryAddSingleton<IRepository<Game>, MemoryGameRepository>();
            services.TryAddSingleton<IRepository<GameSetting>, MemoryGameSettingRepository>();
            services.TryAddSingleton<IPlayerRepository<Player>, MemoryPlayerRepository>();
            services.TryAddSingleton<IRepository<Team>, MemoryTeamRepository>();
            services.TryAddSingleton<IGameService, GameService>();

            var config = new MapperConfiguration(c =>
            {
                c.AddProfile(new AutomapperProfile());
            });
            services.AddSingleton<IMapper>(s => config.CreateMapper());
                                                  
            ServiceProvider = services.BuildServiceProvider();
                       
        }

        public void Dispose()
        {

        }
    }

    [CollectionDefinition("DI collection")]
    public class CollectionDI : ICollectionFixture<FixtureDI>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
