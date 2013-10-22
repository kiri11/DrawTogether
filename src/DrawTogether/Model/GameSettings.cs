using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DrawTogether.Model
{
    public class GameSettings
    {
        public int ModeID { get; set; }
        public int BoxId { get; set; }
        public int LevelId { get; set; }

        public TimeSpan TopTimerTimeSpan { get; set; }
        public TimeSpan BottomTimerTimeSpan { get; set; }

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player Player3 { get; set; }
        public Player Player4 { get; set; }
    }
}
