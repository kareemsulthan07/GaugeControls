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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GaugeControl1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void valueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                fillPathRT.Angle = valueSlider.Value;

                var angle = 180 + valueSlider.Value;
                double radius = 250, centerX = needleLine.X1, centerY = needleLine.Y1;

                double x2 = (radius * Math.Cos(angle * Math.PI / 180)) + centerX;
                double y2 = (radius * Math.Sin(angle * Math.PI / 180)) + centerY;

                needleLine.X2 = x2;
                needleLine.Y2 = y2;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
