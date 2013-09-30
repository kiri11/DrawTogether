using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DrawTogether.Model
{
    public interface IMenuItem
    {
        string Title { get; set; }
        ImageBrush ImageBrush { get; set; }
        int Id { get; set; }
        int GameModeId { get; set; }
    }
}
