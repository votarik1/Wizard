using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisardLib;
using ImageMagick;
using System.Windows.Media.Imaging;


namespace Wizard

{
    public class Locations:List<Location>
    {
        public Locations()
        {
            Location MyRoom = new Location();
            MyRoom.Id = 0;
            MyRoom.name = "Моя Комната";
            MyRoom.Discription = "Здесь я живу";
            MyRoom.Img = "Pics\\Locations\\MyRoom.webp";
            //
            Location Yard = new Location();
            Yard.Id = 1;
            Yard.name = "Мой Дом";
            Yard.Discription = "Мой дом";
            Yard.Img = "Pics\\Locations\\Yard.webp";
            //
            Location School = new Location();
            School.Id = 2;
            School.name = "Школа";
            School.Discription = "Школа";
            School.Img = "Pics\\Locations\\School.webp";

            //***************************************************************************************//
            MyRoom.WaysOut.Add(Yard);
            Yard.WaysOut.Add(MyRoom);
            Yard.WaysOut.Add(School);
            School.WaysOut.Add(Yard);
            //***************************************************************************************//
            this.Add(MyRoom);
            this.Add(Yard);
            this.Add(School);
        }



        public byte[] ConvertJpgToBytes(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bytes = br.ReadBytes((int)fs.Length);
                    return bytes;
                }
            }
        }


        public BitmapSource ConvertWebpToBitmapSource(string filePath)
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
