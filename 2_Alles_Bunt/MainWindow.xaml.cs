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

namespace _2_Alles_Bunt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Figura.Content = new kreis();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Figura.Content = new kreis();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Figura.Content = new rechteck();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Figura.Content = new linie();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Figura.Content = new dreieck();
        }
    }
}
