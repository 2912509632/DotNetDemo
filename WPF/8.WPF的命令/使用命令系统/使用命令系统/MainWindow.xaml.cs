using System.Windows;
using System.Windows.Input;


namespace 使用命令系统
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitCommand();
        }

        //声明定义命令
        private RoutedCommand clearCMD = new RoutedCommand("ClearTxt", typeof(MainWindow));

        /// <summary>
        /// 初始化命令系统
        /// </summary>
        private void InitCommand()
        {
            //命令赋值给命令源并绑定快捷键
            btn_demo.Command = clearCMD;
            clearCMD.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));

            //指定命令目标
            btn_demo.CommandTarget = txt_demo;

            //创建命令关联
            CommandBinding cb = new CommandBinding();
            cb.Command = clearCMD; //只关注clearCMD相关的事件
            cb.CanExecute += new CanExecuteRoutedEventHandler(cb_CanExecute);
            cb.Executed += new ExecutedRoutedEventHandler(cb_Executed);

            //将命令关联在外围控件上
            sp_root.CommandBindings.Add(cb);

        }

        private void cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_demo.Text))
            {
                e.CanExecute = false;  //命令不可执行
            }
            else
            {
                e.CanExecute = true; //命令可执行
            }
            e.Handled = true; //事件不再向上传递
        }

        private void cb_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txt_demo.Clear();
            e.Handled = true; //事件不再向上传递
        }


    }
}
