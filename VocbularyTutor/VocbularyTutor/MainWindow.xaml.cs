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
            this.translation1.MainText = "123123";
            this.translation1.CommentText = "123123";
            this.translation1.ToolTip = "123123";
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
        private void AddTranslationButton_Click(object sender, RoutedEventArgs e)
        {
            if (AddTranslationTextBox.Text != "Новый перевод" && AddTranslationTextBox.Text != " " && AddTranslationTextBox.Text != "" && AddTranslationTextBox.Text!="Введите новый перевод!!!")
            {
            RowDefinition NewRow=new RowDefinition();
            var height = new GridLength(40);
            int currentrownumber = Grid.GetRow((Button)sender);
            TranslationLocation.RowDefinitions[currentrownumber+2].Height = height;
            TranslationLocation.RowDefinitions.Add(NewRow);
            var NTB = new DoubleTextBlock();
            NTB.MainText = AddTranslationTextBox.Text;
            NTB.CommentText = AddCommentTextBox.Text;
            NTB.ToolTip = AddCommentTextBox.Text;
            TranslationLocation.Children.Add(NTB);
            NTB.SetValue(Grid.RowProperty, currentrownumber);
            NTB.SetValue(Grid.ColumnProperty, 0);
            var MinBut1 = new Button();
            MinBut1.Style = (Style) Application.Current.Resources["DialogButtonStyle"];
            TranslationLocation.Children.Add(MinBut1);
            MinBut1.Height = 30;
            MinBut1.Width = 30;
            Image img = new Image();
            BitmapImage bimg = new BitmapImage(new Uri("Minus.png", UriKind.Relative));
            img.Source = bimg;
            MinBut1.Content = img;
            MinBut1.SetValue(Grid.RowProperty, currentrownumber);
            MinBut1.SetValue(Grid.ColumnProperty, 1);
            this.AddTranslationTextBox.SetValue(Grid.RowProperty, currentrownumber+1);
            this.AddTranslationButton.SetValue(Grid.RowProperty, currentrownumber+1);
            AddCommentTextBox.SetValue(Grid.RowProperty, currentrownumber+2);
            AddTranslationTextBox.Text = "Новый перевод";
                AddCommentTextBox.Text = "Новый коментарий";
            }
            else
            {
                AddTranslationTextBox.Text = "Введите новый перевод!!!";
            }
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

        private void TextBoxDblClick(object sender, RoutedEventArgs e)
        {
            TextBox tb=new TextBox();
            tb = (TextBox) sender;
            tb.SelectionStart = 0;
            tb.SelectionLength = tb.Text.Length;
        }
    }
}
