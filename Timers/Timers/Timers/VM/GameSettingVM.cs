using System;
using Timers.Shared.ViewModels;

namespace Timers.VM
{
    public class GameSettingVM : IGameSettingVM
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public int MaxPlayersAllowed { get; set; }
        public int Periods { get; set; }
        public int MinutesPerPeriod { get; set; }
        public bool IsCountdown { get; set; }

        public int MaxPlayerSeconds => (MinutesPerPeriod * Periods * 60);
    }
}
