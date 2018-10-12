using System;
using System.Collections.Generic;
using System.Text;
using Timers.Shared.Models;
using Timers.Shared.ViewModels;

namespace Timers.Models
{
    public class GameXVM : IGameVM
    {
        public Guid Id { get; set; }
        public Guid GameSettingId { get; set; }
        public Guid HomeTeamId { get; set; }
        public Guid VisitorTeamId { get; set; }
        public int HomeTeamScore { get; set; }
        public int VisitorTeamScore { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public TeamXVM HomeTeam { get; set; }
        public TeamXVM VisitorTeam { get; set; }
        public GameSettingXVM GameSetting { get; set; }
        public int SecondsElapsed { get; set; }


        IGameSetting IGameVM.GameSetting { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ITeamVM IGameVM.HomeTeam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ITeamVM IGameVM.VisitorTeam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
