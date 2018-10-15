using Prism;
using Prism.Ioc;
using Timers.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using AutoMapper;
using Timers.Shared.Services;
using Timers.Shared.Models;
using Timers.Shared.Repositories;
using Timers.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Timers
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            //await NavigationService.NavigateAsync("NavigationPage/MainPage");
            await NavigationService.NavigateAsync("NavigationPage/GameSessionPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<GameSessionPage>();

            containerRegistry.RegisterSingleton<IRepository<Game>, MemoryGameRepository>();
            containerRegistry.RegisterSingleton<IRepository<GameSetting>, MemoryGameSettingRepository>();
            containerRegistry.RegisterSingleton<IPlayerRepository<Player>, MemoryPlayerRepository>();
            containerRegistry.RegisterSingleton<IRepository<Team>, MemoryTeamRepository>();
            containerRegistry.RegisterSingleton<IGameService, GameService>();

            var config = new MapperConfiguration(c =>
            {
                c.AddProfile(new AutomapperProfileX());
            });
            containerRegistry.RegisterInstance(config.CreateMapper());
        }
    }
}
