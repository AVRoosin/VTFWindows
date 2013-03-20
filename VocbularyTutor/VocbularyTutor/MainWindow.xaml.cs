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
<<<<<<< HEAD
    public partial class MainWindow : Window,IAuthorisationProvider
=======
    public partial class MainWindow : Window
>>>>>>> def41f0... Поправил код, переименовал переменные и функции
    {
        Color PassiveColor;
        Color ActiveColor;


        private void Window_Load(object sender, RoutedEventArgs e)
        {
            this.UsersTabItem.Focus();
            this.translation1.MainText =    "MainText";
            this.translation1.CommentText = "Сюда мы запишем новый комментарий и поглядим, как он отобразится";
            this.translation1.ToolTip =     "Сюда мы запишем новый комментарий и поглядим, как он отобразится";
        }

        public MainWindow()
        {
            InitializeComponent();
            PassiveColor   = new Color();
            PassiveColor.A = 255;
            PassiveColor.R = 161;
            PassiveColor.G = 255;
            PassiveColor.B = 6;
            ActiveColor    = new Color();
            ActiveColor.A  = 255;
            ActiveColor.R  = 88;
            ActiveColor.G  = 105;
            ActiveColor.B  = 113;

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
            if (AddTranslationTextBox.Text != "Новый перевод" && AddTranslationTextBox.Text != " " && AddTranslationTextBox.Text != "" && AddTranslationTextBox.Text!="Введите новый перевод")
            {
                //LoginGrid.Children.Remove(LoginTextBox);

                RowDefinition NewRow   = new RowDefinition();
                var height             = new GridLength(35);
                var translationTextBox = new DoubleTextBlock();
                int i = 20;                                         // Магические числа? Продефайнь, где можно, пожалуйста.

                int currentRowNumber = Grid.GetRow((Button)sender);
                TranslationLocation.RowDefinitions[currentRowNumber + 2].Height = height;
                TranslationLocation.RowDefinitions.Add(NewRow);
                translationTextBox.MainText    = AddTranslationTextBox.Text;
                translationTextBox.CommentText = AddCommentTextBox.Text;
                while (translationTextBox.ChangeCommentTextBlockLinesNumber(height.Value) && height.Value < 75)
                {
                    height = new GridLength(35 + i);
                    TranslationLocation.RowDefinitions[currentRowNumber].Height = height;
                    i += 20;
                }
                translationTextBox.ToolTip = AddCommentTextBox.Text;
                TranslationLocation.Children.Add(translationTextBox);
                translationTextBox.SetValue(Grid.RowProperty, currentRowNumber);
                translationTextBox.SetValue(Grid.ColumnProperty, 0);
                var MinBut1    = new Button();
                MinBut1.Style  = (Style) Application.Current.Resources["DialogButtonStyle"];
                TranslationLocation.Children.Add(MinBut1);
                MinBut1.Height = 30;
                MinBut1.Width  = 30;
                Image image    = new Image();
                BitmapImage bitmapImage = new BitmapImage(new Uri("Minus.png", UriKind.Relative));
                image.Source    = bitmapImage;
                MinBut1.Content = image;
                MinBut1.SetValue(Grid.RowProperty, currentRowNumber);
                MinBut1.SetValue(Grid.ColumnProperty, 1);
                this.AddTranslationTextBox.SetValue(Grid.RowProperty, currentRowNumber + 1);
                this.AddTranslationButton.SetValue(Grid.RowProperty, currentRowNumber + 1);
                AddCommentTextBox.SetValue(Grid.RowProperty, currentRowNumber + 2);
                AddTranslationTextBox.Text = "Новый перевод";
                AddCommentTextBox.Text     = "Новый коментарий";
            }
            else
            {
                AddTranslationTextBox.Text = "Введите новый перевод";
            }
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

		 private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow sw = new SettingsWindow();
            sw.ShowDialog();
        }

        private void tabItem_LostFocus(object sender, RoutedEventArgs e)
        {
            TabItem tab = new TabItem();
            tab = (TabItem)sender;
            tab.Foreground = new SolidColorBrush(PassiveColor);
        }

        private void tabItem_GotFocus(object sender, RoutedEventArgs e)
        {
            TabItem tab = new TabItem();
            tab = (TabItem)sender;
            tab.Foreground = new SolidColorBrush(ActiveColor);
        }

<<<<<<< HEAD
        private void textBox_DoubleClick(object sender, RoutedEventArgs e)
=======
        private void TextBoxDblClick(object sender, RoutedEventArgs e)
>>>>>>> def41f0... Поправил код, переименовал переменные и функции
        {
            TextBox tb = new TextBox();
            tb = (TextBox) sender;
            tb.SelectionStart  = 0;
            tb.SelectionLength = tb.Text.Length;
        }

        private void NewUserButton_Click(object sender, RoutedEventArgs e)
        {
            LoginGrid.Children.Remove(StoredLoginComboBox);
            TextBox LoginTextBox = new TextBox();
            LoginTextBox.Text    = "Имя пользователя";
            LoginGrid.Children.Add(LoginTextBox);
            LoginTextBox.SetValue(Grid.ColumnProperty, 1);
            LoginTextBox.SetValue(Grid.RowProperty, 0);
            LoginTextBox.FontSize     = 24;
            LoginTextBox.TextWrapping = TextWrapping.Wrap;
            LoginTextBox.HorizontalAlignment = HorizontalAlignment.Stretch;
            LoginTextBox.VerticalAlignment   = VerticalAlignment.Center;
        }
<<<<<<< HEAD

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (Authorisation.Authorise() == AuthorisationResult.Success)
            {
                //Success!
            }
            else
            {
                //Failed!!
            }
        }

        public string GetLogin()
        {
            return StoredLoginComboBox.Text;
        }

        public string GetPassword()
        {
            return PasswordTextBox.Password;
        }
=======
>>>>>>> def41f0... Поправил код, переименовал переменные и функции
    }
}
