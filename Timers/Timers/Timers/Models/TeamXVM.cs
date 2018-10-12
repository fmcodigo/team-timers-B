using System;
using System.Collections.Generic;
using System.Text;

namespace Timers.Models
{
    public class TeamXVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<PlayerXVM> Players { get; set; }
    }
}
