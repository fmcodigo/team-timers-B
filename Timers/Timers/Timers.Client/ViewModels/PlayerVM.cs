using Timers.Shared.Models;
using Timers.Shared.ViewModels;

namespace Timers.Client.ViewModels
{
    public class PlayerVM : Player, IPlayerVM
    {
        public bool IsPresent { get; set; }
        public bool IsPlaying { get; set; }
        public int SecondsPlayed { get; set; }
    }
}
