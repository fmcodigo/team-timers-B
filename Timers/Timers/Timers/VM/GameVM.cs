using System;
using System.Collections.Generic;
using Timers.Shared.ViewModels;

namespace Timers.VM
{
    public class GameVM : IGameVM
    {
        public Guid Id { get; set; }
        public Guid GameSettingId { get; set; }
        public Guid HomeTeamId { get; set; }
        public Guid VisitorTeamId { get; set; }
        public int HomeTeamScore { get; set; }
        public int VisitorTeamScore { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public ITeamVM HomeTeam { get; set; }
        public ITeamVM VisitorTeam { get; set; }
        public IGameSettingVM GameSetting { get; set; }
        public int SecondsElapsed { get; set; }

        public string TeamVersusTeam => ($"{HomeTeam.Name} vs {VisitorTeam.Name}");
        public IEnumerable<IPlayerVM> PlayersPresent => (HomeTeam.Players);

    }
}
