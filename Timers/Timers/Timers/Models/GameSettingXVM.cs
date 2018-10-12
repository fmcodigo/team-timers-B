using System;
using System.Collections.Generic;
using System.Text;

namespace Timers.Models
{
    public class GameSettingXVM
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
