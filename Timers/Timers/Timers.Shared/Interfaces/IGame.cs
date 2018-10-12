using System;

namespace Timers.Shared.Models
{
    public interface IGame
    {
        DateTime EndTime { get; set; }
        Guid GameSettingId { get; set; }
        Guid HomeTeamId { get; set; }
        int HomeTeamScore { get; set; }
        Guid Id { get; set; }
        DateTime StartTime { get; set; }
        Guid VisitorTeamId { get; set; }
        int VisitorTeamScore { get; set; }

    }
}