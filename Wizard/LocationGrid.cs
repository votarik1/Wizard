using ImageMagick;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WisardLib;


namespace Wizard
{
    public class LocationGrid:Grid
    {
        public TextBox LocName { get; set; }
        public Image LocPic { get; set; }

        public LocationGrid()
        {
          
        }

        public LocationGrid(Location location)
        {
            LocName = new TextBox();
            LocName.Text = location.name;
            LocName.FontSize = 12;
            LocName.HorizontalAlignment = HorizontalAlignment.Center;                
            LocPic = new Image();
            LocPic.Source = Global.ConvertWebpToBitmapSource(location.Img);
            for (int i = 0; i < 20; i++)
            {
                RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 25; i++)
            {
                ColumnDefinitions.Add(new ColumnDefinition());
            }
            SetRow(LocName, 0);
            SetRowSpan(LocName, 1);
            SetColumn(LocName, 7);
            SetColumnSpan(LocName, 11);
            SetRow(LocPic, 0);
            SetRowSpan(LocPic, 20);
            SetColumn(LocPic, 0);
            SetColumnSpan(LocPic, 25);
            Children.Add(LocPic);
            Children.Add(LocName);
            
        }       
    }

}
