using Timers.Shared.Models;
using Timers.Shared.ViewModels;

namespace Timers.Client.ViewModels
{
    public class GameVM : Game, IGameVM
    {
        public ITeamVM HomeTeam { get; set; }
        public ITeamVM VisitorTeam { get; set; }
        public IGameSettingVM GameSetting { get; set; }
        public int SecondsElapsed { get; set; }
    }
}
