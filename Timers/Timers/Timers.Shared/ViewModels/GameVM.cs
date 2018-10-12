using Timers.Shared.Models;

namespace Timers.Shared.ViewModels
{
    public class GameVM : Game, IGameVM
    {
        public ITeamVM HomeTeam { get; set; }
        public ITeamVM VisitorTeam { get; set; }
        public IGameSetting GameSetting { get; set; }
        public int SecondsElapsed { get; set; }
    }
}
