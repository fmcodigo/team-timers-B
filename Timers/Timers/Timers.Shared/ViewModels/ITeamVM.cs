using System;
using System.Collections.Generic;

namespace Timers.Shared.ViewModels
{
    public interface ITeamVM
    {
        Guid Id { get; set; }
        string Name { get; set; }

        IEnumerable<IPlayerVM> Players { get; set; }
    }
}