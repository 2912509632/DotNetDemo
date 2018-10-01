using System.Windows;
using System.Windows.Input;

namespace 命令参数
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_text.Text) && string.IsNullOrEmpty(txt_title.Text))
                e.CanExecute = false;
            else
                e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Parameter.ToString() == "Title")
            {
                txt_title.Clear();
            }
            if (e.Parameter.ToString() == "Text")
            {
                txt_text.Clear();
            }
        }
    }
}
