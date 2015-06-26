using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HexPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Brush brush;
        public MainWindow()
        {
            InitializeComponent();
            var appObject = App.Current as App;
            this.Title = "Player " + appObject.name;
            string playerPipeName = "player" + appObject.name;
            brush = (Brush)new BrushConverter().ConvertFromString(appObject.color);
            
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ellip.Fill = brush;
        }

        private void Clicked(object sender, MouseButtonEventArgs e)
        {            
            ((System.Windows.Shapes.Ellipse)this.FindName((sender as Ellipse).Name)).Fill = brush;            
            (sender as Ellipse).MouseDown -= Clicked;
        }
    }
}
