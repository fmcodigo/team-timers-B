using System.Collections.Generic;
using Timers.Shared.ViewModels;
using System;

namespace Timers.VM
{
    public class TeamVM : ITeamVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<IPlayerVM> Players { get; set; }
    }
}
