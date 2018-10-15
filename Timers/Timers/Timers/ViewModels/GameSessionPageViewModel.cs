using Prism.Mvvm;
using Prism.Navigation;
using System;
using Timers.Shared.Services;
using Timers.Shared.ViewModels;

namespace Timers.ViewModels
{
    public class GameSessionPageViewModel : BindableBase, INavigationAware
    {
        private readonly IGameService _gameService;
        private readonly INavigationService _navigationService;

        public GameSessionPageViewModel(INavigationService navigationService, IGameService gameService)
        {
            _gameService = gameService ?? throw new ArgumentNullException(nameof(gameService));
            _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
        }

        private IGameVM game;
        public IGameVM Game
        {
            get { return game; }
            set { SetProperty(ref game, value); }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            if (Game == null)
                Game = await _gameService.GetByIdAsync(new Guid("d66945ca-e9ef-4b5b-8084-35ea568d937c"));
            
            //throw new NotImplementedException();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }
    }
}
