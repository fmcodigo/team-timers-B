using Timers.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Timers.Shared.ViewModels
{
    public class GameVM : Game
    {
        public TeamVM HomeTeam { get; set; }
        public TeamVM VisitorTeam { get; set; }
        public GameSetting GameSetting { get; set; }
        public int SecondsElapsed { get; set; }
    }
}
