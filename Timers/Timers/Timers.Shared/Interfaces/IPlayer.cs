using System;

namespace Timers.Shared.Models
{
    public interface IPlayer
    {
        Guid Id { get; set; }
        string Jersey { get; set; }
        string Name { get; set; }
        Guid TeamId { get; set; }
    }
}