using System;

namespace Timers.Shared.ViewModels
{
    public interface IGameSettingVM
    {
        Guid Id { get; set; }
        String Name { get; set; }
        int MaxPlayersAllowed { get; set; }
        int Periods { get; set; }
        int MinutesPerPeriod { get; set; }
        bool IsCountdown { get; set; }

        int MaxPlayerSeconds { get; }
    }
}
