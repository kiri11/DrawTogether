using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DrawTogether.Model
{
    public class MenuLevelItem : IMenuItem
    {
        private string _title;
        private ImageBrush _imageBrush;
        private int _id;
        private int _gameModeId;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public int GameModeId
        {
            get
            {
                return _gameModeId;
            }
            set
            {
                _gameModeId = value;
            }
        }


        public ImageBrush ImageBrush
        {
            get
            {
                return _imageBrush;
            }
            set
            {
                _imageBrush = value;
            }
        }
    }
}
