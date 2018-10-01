using System.Windows;


namespace 自定义Command
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //声明命令并将源于目标关联
            ClearCommand cc = new ClearCommand();
            clear_val.Command = cc;
            clear_val.CommandTarget = myView;
        }
    }
}
