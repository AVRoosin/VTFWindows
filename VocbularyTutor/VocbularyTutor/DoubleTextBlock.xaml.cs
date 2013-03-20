using System;
using System.Collections.Generic;
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
	/// Interaction logic for DoubleTextBlock.xaml
	/// </summary>
    public partial class DoubleTextBlock : UserControl
    {
        public string MainText
        {get { return (string)GetValue(MainTextProperty); }
            set { SetValue(MainTextProperty, value); } }
        public static readonly DependencyProperty MainTextProperty = DependencyProperty.Register("MainText", typeof(string), typeof(DoubleTextBlock), new UIPropertyMetadata(""));
        
        public string CommentText
        {
            get { return (string)GetValue(CommentTextProperty); }
            set { SetValue(CommentTextProperty, value); }
        }
        public static readonly DependencyProperty CommentTextProperty = DependencyProperty.Register("CommentText", typeof(string), typeof(DoubleTextBlock), new UIPropertyMetadata(""));
	    
        public DoubleTextBlock()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Comment_Loaded(object sender, RoutedEventArgs e)
        {
            //ChangeCommentTextBlockLinesNumber();
        }
        public bool ChangeCommentTextBlockLinesNumber(double actualGridHeight)
        {
            return ((CommentText.Length -actualGridHeight+35) > 20);
        }
    }
}