using Timers.Shared.Models;

namespace Timers.Shared.ViewModels
{
    public interface IGameVM : IGame
    {
        IGameSetting GameSetting { get; set; }
        ITeamVM HomeTeam { get; set; }
        int SecondsElapsed { get; set; }
        ITeamVM VisitorTeam { get; set; }
    }
}