using Timers.Shared.Models;

namespace Timers.Shared.ViewModels
{
    public interface IPlayerVM : IPlayer
    {
        bool IsPlaying { get; set; }
        bool IsPresent { get; set; }
        int SecondsPlayed { get; set; }
    }
}