﻿using System;

namespace Timers.Shared.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Jersey { get; set; }
        public Guid TeamId { get; set; }
    }
}
