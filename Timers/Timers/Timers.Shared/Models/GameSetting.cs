using System;

namespace Timers.Shared.Models
{
    public class GameSetting
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public int MaxPlayersAllowed { get; set; }
        public int Periods { get; set; }
        public int MinutesPerPeriod { get; set; }
        public bool IsCountdown { get; set; }

    }
}
