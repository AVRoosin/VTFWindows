using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VocbularyTutor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void TopTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void _menuTabControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow sw = new SettingsWindow();
            sw.ShowDialog();
        }

        private void _tabItem1_GotFocus_1(object sender, RoutedEventArgs e)
        {

        }

        private void _tabItem_GotFocus(object sender, RoutedEventArgs e)
        {
            Color ActiveColor = new Color();
            ActiveColor.A = 255;
            ActiveColor.R = 161;
            ActiveColor.G = 255;
            ActiveColor.B = 6;
            Color PassiveColor = new Color();
            PassiveColor.A = 255;
            PassiveColor.R = 88;
            PassiveColor.G = 105;
            PassiveColor.B = 113;
            if (this._tabItem1.IsSelected==true)
            {
                this._tabItem1.Foreground = new SolidColorBrush(PassiveColor);
            }
            else
            {
                this._tabItem1.Foreground = new SolidColorBrush(ActiveColor);
            }

            if (this._tabItem2.IsSelected == true)
            {
                this._tabItem2.Foreground = new SolidColorBrush(PassiveColor);
            }
            else
            {
                this._tabItem2.Foreground = new SolidColorBrush(ActiveColor);
            }

            if (this._tabItem3.IsSelected == true)
            {
                this._tabItem3.Foreground = new SolidColorBrush(PassiveColor);
            }
            else
            {
                this._tabItem3.Foreground = new SolidColorBrush(ActiveColor);
            }

            if (this._tabItem4.IsSelected == true)
            {
                this._tabItem4.Foreground = new SolidColorBrush(PassiveColor);
            }
            else
            {
                this._tabItem4.Foreground = new SolidColorBrush(ActiveColor);
            }
        }
    }
}
