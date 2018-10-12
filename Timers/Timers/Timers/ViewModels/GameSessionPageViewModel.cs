using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timers.Shared.Services;
using Timers.Shared.ViewModels;

namespace Timers.ViewModels
{
	public class GameSessionPageViewModel : BindableBase, INavigationAware
    {
        public IGameVM Game { get; set; }
        private readonly IGameService _gameService;

        public GameSessionPageViewModel(IGameService gameService)
        {
            _gameService = gameService ?? throw new ArgumentNullException(nameof(gameService));
        }

        public async Task LoadGameAsync()
        {
            Game = await _gameService.GetByIdAsync(new Guid("d66945ca-e9ef-4b5b-8084-35ea568d937c"));
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
