using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DrawTogether.Model
{
    public class MenuBoxItem : IMenuItem
    {
        private string _title;
        private BitmapImage _imageSource;
        private int _id;
        private GameMode _gameMode;

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

        public BitmapImage ImageSource
        {
            get
            {
                return _imageSource;
            }
            set
            {
                _imageSource = value;
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

        public GameMode GameMode
        {
            get
            {
                return _gameMode;
            }
            set
            {
                _gameMode = value;
            }
        }
    }
}
