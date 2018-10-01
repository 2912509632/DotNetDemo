using System;
using System.Windows;
using System.Windows.Controls;


namespace 使用内置路由事件
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //添加路由事件
            g_demo.AddHandler(Button.ClickEvent, new RoutedEventHandler(Btn_Clicked));
            /*
             * 添加路由事件可是使用等效XAML代码实现
             * 
             * < Grid x: Name = "g_demo" Background = "Blue" Button.Click = "Btn_Clicked" ></Grid>
             * 
             */ 
        }


        /// <summary>
        /// 事件响应方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Clicked(object sender, RoutedEventArgs e)
        {
            //展示事件源控件的Name属性值
            MessageBox.Show((e.OriginalSource as FrameworkElement).Name);
        }
    }
}
