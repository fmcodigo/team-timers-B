using Timers.Shared.Models;
using System.Collections.Generic;

namespace Timers.Shared.ViewModels
{
    public class TeamVM : Team, ITeamVM
    {
        public IEnumerable<IPlayerVM> Players { get; set; }
    }
}
