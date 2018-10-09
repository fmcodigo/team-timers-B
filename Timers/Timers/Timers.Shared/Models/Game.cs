using System;
using System.Collections.Generic;
using System.Text;

namespace Timers.Shared.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public Guid GameSettingId { get; set; }
        public Guid HomeTeamId { get; set; }
        public Guid VisitorTeamId { get; set; }
        public int HomeTeamScore { get; set; }
        public int VisitorTeamScore { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

}
