﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Timers.Shared.Models
{
    public class Team : ITeam
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
