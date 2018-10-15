using Prism.Commands;
using Prism.Navigation;
using System;

namespace Timers.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
            Title = "Main Page";
            GameSessionPageCommand = new DelegateCommand(GotoGameSessionPage);
        }

        public DelegateCommand GameSessionPageCommand { get; set; }

        private void GotoGameSessionPage()
        {
            //_navigationService.NavigateAsync("NavigationPage/GameSessionPage");
            _navigationService.NavigateAsync("NavigationPage/GameSessionPage");
        }

    }
}
