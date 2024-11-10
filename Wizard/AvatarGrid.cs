using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WisardLib;

namespace Wizard
{
    public class AvatarGrid:Grid
    {
        public Image LocPic { get; set; }

        public AvatarGrid()
        {           
            LocPic = new Image();
            LocPic.Source = Global.ConvertWebpToBitmapSource("Pics\\Avatars\\result.png");
            System.Windows.Controls.Image MyImage = new();
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri("pack://application:,,,/Pics/Icons/sort.png");
            bitmapImage.EndInit();
            for (int i = 0; i < 20; i++)
            {
                RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 25; i++)
            {
                ColumnDefinitions.Add(new ColumnDefinition());
            }
            SetRow(LocPic, 0);
            SetRow(MyImage, 0);
            SetRowSpan(LocPic, 20);
            SetRowSpan(MyImage, 3);
            SetColumn(LocPic, 0);
            SetColumn(MyImage, 21);
            SetColumnSpan(LocPic, 25);
            SetColumnSpan(MyImage, 4);
            Children.Add(LocPic);
            

            // Устанавливаем изображение в Image элемент
            MyImage.Source = bitmapImage;
            Children.Add(MyImage);

        }


    }
}
