using System.Windows;
using System.Windows.Controls;

namespace 检索ControlTemplate内部控件
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
            TextBox one = uc_demo.Template.FindName("txt_1",uc_demo) as TextBox;
            one.Text = "Hello World!";

            //检索父控件以使用兄弟控件
            StackPanel sp = one.Parent as StackPanel;
            (sp.Children[1] as TextBox).Text = "我是txt_2";
            (sp.Children[2] as TextBox).Text = "我是txt_3";
            MessageBox.Show("检索完毕！");
        }
    }
}
