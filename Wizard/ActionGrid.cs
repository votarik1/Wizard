using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using WisardLib;

namespace Wizard
{
    public class ActionGrid:StackPanel
    {
        public List<int> Locations { get; set; }
        public ActionGrid(Location location)
        {
            Locations = new();
            foreach (var item in location.WaysOut)
            {
                Locations.Add(item.Id);
                STextBlock textBlock = new();
                textBlock.Id = item.Id;
                textBlock.Text = item.name;
                textBlock.FontSize = 16;
                textBlock.Background = new SolidColorBrush(Colors.Snow);
                textBlock.TextAlignment = System.Windows.TextAlignment.Center;
                textBlock.MouseEnter += MouseOn;
                textBlock.MouseLeave += MouseLeft;
                textBlock.MouseLeftButtonDown += MouseLeftButtonClick;
                this.Children.Add(textBlock);
            }
        }

        private void MouseOn(object o, MouseEventArgs mouseEventArgs)
        {
            STextBlock textBlock = (STextBlock)o;
            textBlock.Background = new SolidColorBrush(Colors.LightSteelBlue);
        }

        private void MouseLeft(object o, MouseEventArgs mouseEventArgs)
        {
            STextBlock textBlock = (STextBlock)o;
            textBlock.Background = new SolidColorBrush(Colors.Snow);
        }

        private void MouseLeftButtonClick(object o, MouseButtonEventArgs args)
        {
            STextBlock textBlock = (STextBlock)o;
            Global.ChangeLocation(textBlock.Id);
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.UpdateMainGrid();
            }
        }


        private class STextBlock:TextBlock
        {
            public int Id { get; set; }
        }


    }
}
