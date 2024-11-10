using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.CompilerServices;

namespace Wizard
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Global.ChangeLocation(0);
            UpdateMainGrid();
        }



        public void UpdateMainGrid()
        {
            MainGrid.Children.Clear();
            Grid.SetRow(Global.LocationGrid, 0);
            Grid.SetRow(Global.ActionGrid, 14);
            Grid.SetRow(Global.AvatarGrid, 0);
            Grid.SetRowSpan(Global.LocationGrid, 14);
            Grid.SetRowSpan(Global.ActionGrid, 6);
            Grid.SetRowSpan(Global.AvatarGrid, 8);
            Grid.SetColumn(Global.LocationGrid, 0);
            Grid.SetColumn(Global.ActionGrid, 0);
            Grid.SetColumn(Global.AvatarGrid, 20);
            Grid.SetColumnSpan(Global.LocationGrid, 20);            
            Grid.SetColumnSpan(Global.ActionGrid, 20);
            Grid.SetColumnSpan(Global.AvatarGrid, 5);
            Global.ActionGrid.Background = new SolidColorBrush(Colors.AliceBlue);
            Global.AvatarGrid.Background = new SolidColorBrush(Colors.LightGray);
            MainGrid.Children.Add(Global.LocationGrid);
            MainGrid.Children.Add(Global.ActionGrid);
            MainGrid.Children.Add(Global.AvatarGrid);

           

        }
    }
}
