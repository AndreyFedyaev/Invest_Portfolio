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
        SolidColorBrush Click_Background;
        SolidColorBrush Click_Foreground;
        SolidColorBrush Button_Background;
        SolidColorBrush Button_Foreground;
        public MainWindow()
        {
            InitializeComponent();
            Style_Button_Menu();
        }
        public void Style_Button_Menu ()
        {
           Click_Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
           Click_Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

           Button_Background = new SolidColorBrush(Color.FromArgb(255, 35, 35, 35));
           Button_Foreground = new SolidColorBrush(Color.FromArgb(255, 155, 155, 155));
        }

        private void Button_Menu_1 (object sender, RoutedEventArgs e)
        {
            Menu_1.Background = Click_Background;
            Menu_2.Background = Button_Background;
            Menu_3.Background = Button_Background;
            Menu_4.Background = Button_Background;

            Menu_1.Foreground = Click_Foreground;
            Menu_2.Foreground = Button_Foreground;
            Menu_3.Foreground = Button_Foreground;
            Menu_4.Foreground = Button_Foreground;
        }
        private void Button_Menu_2(object sender, RoutedEventArgs e)
        {
            Menu_1.Background = Button_Background;
            Menu_2.Background = Click_Background;
            Menu_3.Background = Button_Background;
            Menu_4.Background = Button_Background;

            Menu_1.Foreground = Button_Foreground;
            Menu_2.Foreground = Click_Foreground;
            Menu_3.Foreground = Button_Foreground;
            Menu_4.Foreground = Button_Foreground;
        }
        private void Button_Menu_3(object sender, RoutedEventArgs e)
        {
            Menu_1.Background = Button_Background;
            Menu_2.Background = Button_Background;
            Menu_3.Background = Click_Background;
            Menu_4.Background = Button_Background;

            Menu_1.Foreground = Button_Foreground;
            Menu_2.Foreground = Button_Foreground;
            Menu_3.Foreground = Click_Foreground;
            Menu_4.Foreground = Button_Foreground;
        }
        private void Button_Menu_4(object sender, RoutedEventArgs e)
        {
            Menu_1.Background = Button_Background;
            Menu_2.Background = Button_Background;
            Menu_3.Background = Button_Background;
            Menu_4.Background = Click_Background;

            Menu_1.Foreground = Button_Foreground;
            Menu_2.Foreground = Button_Foreground;
            Menu_3.Foreground = Button_Foreground;
            Menu_4.Foreground = Click_Foreground;
        }
    }


}
