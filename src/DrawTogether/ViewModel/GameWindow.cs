using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace DrawTogether
{
    public partial class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();
            SetImages();
        }


        public void SetImages()
        {//test
            BitmapImage ImgSource = new BitmapImage(new Uri(Directory.GetParent(Directory.GetCurrentDirectory()) + "\\" +
            "data\\test\\testimage.jpg"));

            leftTopImage.Source = ImgSource;
            leftTopImage.Stretch = Stretch.Fill;

            rightTopImage.Source = ImgSource;
            rightTopImage.Stretch = Stretch.Fill;

            leftBottomImage.Source = ImgSource;
            leftBottomImage.Stretch = Stretch.Fill;

            rightBottomImage.Source = ImgSource;
            rightBottomImage.Stretch = Stretch.Fill;

            int stride = ImgSource.PixelWidth * 4;
            int size = ImgSource.PixelHeight * stride;
            byte[] pixels = new byte[size];
            ImgSource.CopyPixels(pixels, stride, 0);

            //int index = y * stride + 4 * x;
            
            //byte red = pixels[index];
            //byte green = pixels[index + 1];
            //byte blue = pixels[index + 2];
            //byte alpha = pixels[index + 3];
        }

    }
}
