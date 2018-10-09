using Timers.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Timers.Shared.ViewModels
{
    public class TeamVM : Team
    {
        public IEnumerable<PlayerVM> Players { get; set; }
    }
}
