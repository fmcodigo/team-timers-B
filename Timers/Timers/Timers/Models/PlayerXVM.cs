
using System;

namespace Timers.Models
{
    public class PlayerXVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Jersey { get; set; }
        public Guid TeamId { get; set; }

        public bool IsPresent { get; set; }
        public bool IsPlaying { get; set; }
        public int SecondsPlayed { get; set; }
    }
}
