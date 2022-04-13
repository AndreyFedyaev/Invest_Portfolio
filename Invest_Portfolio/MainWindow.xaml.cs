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

namespace Invest_Portfolio
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

        private void Button_Menu_1 (object sender, RoutedEventArgs e)
        {
            Menu_1.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            Menu_2.Background = new SolidColorBrush(Color.FromArgb(229, 35, 35, 40));
            Menu_3.Background = new SolidColorBrush(Color.FromArgb(229, 35, 35, 40));
        }
        private void Button_Menu_2(object sender, RoutedEventArgs e)
        {
            Menu_1.Background = new SolidColorBrush(Color.FromArgb(229, 35, 35, 40));
            Menu_2.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            Menu_3.Background = new SolidColorBrush(Color.FromArgb(229, 35, 35, 40));
        }
        private void Button_Menu_3(object sender, RoutedEventArgs e)
        {
            Menu_1.Background = new SolidColorBrush(Color.FromArgb(229, 35, 35, 40));
            Menu_2.Background = new SolidColorBrush(Color.FromArgb(229, 35, 35, 40));
            Menu_3.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }
    }


}
