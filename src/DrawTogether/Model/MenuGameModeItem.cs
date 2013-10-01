using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DrawTogether.Model
{
    public class MenuGameModeItem : IMenuItem
    {
        public MenuBoxItem[] BoxItems { get; set; }

        private string _title;
        private ImageSource _ImageSource;
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

        public ImageSource ImageSource
        {
            get
            {
                return _ImageSource;
            }
            set
            {
                _ImageSource = value;
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
    }
}
