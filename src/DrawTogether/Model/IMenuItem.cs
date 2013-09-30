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
        string Title { get; set; }
        BitmapImage ImageSource { get; set; }
        int Id { get; set; }
        GameMode GameMode { get; set; }
    }
}
