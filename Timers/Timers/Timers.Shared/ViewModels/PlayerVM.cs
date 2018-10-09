using Timers.Shared.Models;

namespace Timers.Shared.ViewModels
{
    public class PlayerVM : Player
    {
        public bool IsPresent { get; set; }
        public bool IsPlaying { get; set; }
        public int SecondsPlayed { get; set; }
    }
}
