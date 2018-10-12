using System.Collections.Generic;
using Timers.Shared.Models;

namespace Timers.Shared.ViewModels
{
    public interface ITeamVM : ITeam
    {
        IEnumerable<IPlayerVM> Players { get; set; }
    }
}