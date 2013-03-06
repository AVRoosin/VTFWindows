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
        Color PassiveColor;
        Color ActiveColor;

        private void Window_Load(object sender, RoutedEventArgs e)
        {
            this._tabItem1.Focus();
        }

        public MainWindow()
        {
            InitializeComponent();
            PassiveColor = new Color();
            PassiveColor.A = 255;
            PassiveColor.R = 161;
            PassiveColor.G = 255;
            PassiveColor.B = 6;
            ActiveColor = new Color();
            ActiveColor.A = 255;
            ActiveColor.R = 88;
            ActiveColor.G = 105;
            ActiveColor.B = 113;

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_Drag(object sender, MouseButtonEventArgs e)
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
        private void _tabItem_LostFocus(object sender, RoutedEventArgs e)
        {
            TabItem tab = new TabItem();
            tab = (TabItem)sender;
            tab.Foreground = new SolidColorBrush(PassiveColor);
        }
        private void _tabItem_GotFocus(object sender, RoutedEventArgs e)
        {
            TabItem tab = new TabItem();
            tab = (TabItem)sender;
            tab.Foreground = new SolidColorBrush(ActiveColor);
        }
    }
}
