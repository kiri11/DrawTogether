using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DrawTogether.Model
{
    public interface IMenuItem
    {
        public string Title { get; set; }
        public BitmapImage ImageSource { get; set; }
        public int Id { get; set; }
        public GameType GameType { get; set; }
    }
}
