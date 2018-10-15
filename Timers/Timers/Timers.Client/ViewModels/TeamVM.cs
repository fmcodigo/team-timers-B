using Timers.Shared.Models;
using System.Collections.Generic;
using Timers.Shared.ViewModels;

namespace Timers.Client.ViewModels
{
    public class TeamVM : Team, ITeamVM
    {
        public IEnumerable<IPlayerVM> Players { get; set; }
    }
}
