using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTogether.Model
{
    public class GameFactory
    {
        public GameType GameType { get; set; }
        public BoxItem[] BoxItems { get; set; }
    }
}
