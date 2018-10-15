using System;

namespace Timers.Shared.ViewModels
{
    public interface IGameVM
    {
        Guid Id { get; set; }
        Guid GameSettingId { get; set; }
        Guid HomeTeamId { get; set; }
        Guid VisitorTeamId { get; set; }
        int HomeTeamScore { get; set; }
        int VisitorTeamScore { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }

        IGameSettingVM GameSetting { get; set; }
        ITeamVM HomeTeam { get; set; }
        int SecondsElapsed { get; set; }
        ITeamVM VisitorTeam { get; set; }
    }
}