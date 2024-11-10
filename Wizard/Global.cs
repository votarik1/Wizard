using ImageMagick;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using WisardLib;

namespace Wizard
{
    public static class  Global
    {
        public static Locations Locations { get; set; } = new Locations();
        public static LocationGrid LocationGrid { get; set; }
        public static ActionGrid ActionGrid { get; set; }
        public static AvatarGrid AvatarGrid { get; set; }


        public static void ChangeLocation(int id)
        {
            Location location = Locations.FirstOrDefault(x => x.Id == id);
            LocationGrid = new LocationGrid(location);
            ActionGrid = new ActionGrid(location);
            AvatarGrid = new AvatarGrid();
        }

        public static BitmapSource ConvertWebpToBitmapSource(string filePath)
        {
            using (var image = new MagickImage(filePath))
            {
                using (var memoryStream = new MemoryStream())
                {
                    image.Write(memoryStream, MagickFormat.Bmp);
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    var bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.StreamSource = memoryStream;
                    bitmapImage.EndInit();
                    bitmapImage.Freeze();
                    return bitmapImage;
                }
            }
        }
    }
}
