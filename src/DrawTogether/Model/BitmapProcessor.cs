using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DrawTogether.Model
{
    public class BitmapProcessor
    {
        public BitmapProcessor()
        { 
        }

        public double GetSimilarityValue(BitmapSource baseSource, BitmapSource resultSource)
        {
            return 0; //затычка
        }

        public static System.Windows.Media.Color GetPlayerColor(BitmapSource bitmap)
        {
            int w = bitmap.PixelWidth;
            int h = bitmap.PixelHeight;
            byte[] pixels = GetArrayOfPixels(bitmap);

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)    
                {
                    int offset = y * w * 3 + x * 3;
                    byte blue = pixels[offset];
                    byte green = pixels[offset + 1];
                    byte red = pixels[offset + 2];

                    if (blue < 255 || green < 255 || red < 255)
                    {
                        return Color.FromRgb(red,green, blue);
                    }
                }
            }

            return System.Windows.Media.Color.FromRgb(0,0,0);
        }

        private static byte[] GetArrayOfPixels(BitmapSource bitmapsource)
        {
            Int32 stride = bitmapsource.PixelWidth * bitmapsource.Format.BitsPerPixel / 8;
            Int32 ByteSize = stride * bitmapsource.PixelHeight * bitmapsource.Format.BitsPerPixel / 8;
            byte[] arrayofpixel = new byte[ByteSize];
            bitmapsource.CopyPixels(arrayofpixel, stride, 0);
            return arrayofpixel;
        }
    }
}
