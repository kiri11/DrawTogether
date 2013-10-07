using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DrawTogether.Model
{
    public class Player
    {
        public int Id { get; set; }
        public Color PlayerColor { get; set; }
        public SolidColorBrush ColorBrush { get { return new SolidColorBrush(PlayerColor); } set { } }


        public BitmapSource SourceBitmap { get; set; }
        public BitmapSource ResultBitmap { get; set; }

        public double Score { get; set; }
        public double BestLevelScore { get; set; }
    }
}
