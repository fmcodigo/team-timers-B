using System;

namespace Timers.Shared.Models
{
    public interface ITeam
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}