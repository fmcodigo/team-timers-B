using System;

namespace Timers.Shared.Models
{
    public interface IGameSetting
    {
        Guid Id { get; set; }
        bool IsCountdown { get; set; }
        int MaxPlayersAllowed { get; set; }
        int MaxPlayerSeconds { get; }
        int MinutesPerPeriod { get; set; }
        string Name { get; set; }
        int Periods { get; set; }
    }
}