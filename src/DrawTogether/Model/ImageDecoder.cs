using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DrawTogether.Model
{
    class ImageDecoder
    {
        public static BitmapSource[] BitmapFrames(string tifPath)
        {
            Stream imageStreamSource = new FileStream(tifPath, FileMode.Open, FileAccess.Read, FileShare.Read);
            TiffBitmapDecoder decoder = new TiffBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
            
            BitmapSource[] bitmapFrames = new BitmapSource[decoder.Frames.Count];

            for (int i = 0; i < decoder.Frames.Count; i++)
			{
			    bitmapFrames[i] = decoder.Frames[i];
			}

            return bitmapFrames;
        }
    }
}
