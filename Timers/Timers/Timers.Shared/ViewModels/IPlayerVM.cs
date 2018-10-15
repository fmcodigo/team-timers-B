using System;

namespace Timers.Shared.ViewModels
{
    public interface IPlayerVM
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Jersey { get; set; }
        Guid TeamId { get; set; }

        bool IsPlaying { get; set; }
        bool IsPresent { get; set; }
        int SecondsPlayed { get; set; }
    }
}