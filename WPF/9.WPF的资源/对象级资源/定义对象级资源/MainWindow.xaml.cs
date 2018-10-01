using System.Windows;

namespace 定义对象级资源
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string title = this.FindResource("title").ToString();
            string text = this.FindResource("text").ToString();

            MessageBox.Show(text, title);
        }
    }
}
