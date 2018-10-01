using System.Windows;
using System.Windows.Controls;


namespace 使用资源字典
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
            Resources["one"] = new TextBlock() { Text = "汗滴禾下土" };
            Resources["two"] = new TextBlock() { Text = "汗滴禾下土" };
        }
    }
}
