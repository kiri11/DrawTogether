using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DrawTogether.Model
{
    public class BoxItem : IMenuItem
    {
        private string _title;
        private BitmapImage _imageSource;
        private int _id;
        private GameType _gameType;

        public LevelItem[] LevelItems { get; set; }

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

        public GameType GameType
        {
            get
            {
                return _gameType;
            }
            set
            {
                _gameType = value;
            }
        }
    }
}
