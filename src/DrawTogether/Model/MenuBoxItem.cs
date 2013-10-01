using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DrawTogether.Model
{
    public class MenuBoxItem : IMenuItem
    {
        private string _title;
        private ImageSource _ImageSource;
        private int _id;
        private int _gameModeId;

        public MenuLevelItem[] LevelItems { get; set; }

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
    }
}
