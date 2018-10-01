using System;
using System.Windows;
using System.Windows.Controls;


namespace 自定义路由事件
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


        private void Test_OnReport(object sender,ReportEvnetArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            string now = e.Time.ToLongTimeString();
            string item = now + "：当前到达控件【" + element.Name + "】";
            lb_data.Items.Add(item);
        }
    }


    /// <summary>
    /// RoutedEventArgs派生类
    /// </summary>
    class ReportEvnetArgs : RoutedEventArgs
    {
        public ReportEvnetArgs(RoutedEvent routedEvent, object source)
            : base(routedEvent,source) { }

        //报告时间属性
        public DateTime Time { get; set; }
    }


    /// <summary>
    /// 继承自Button的自定义Button类型
    /// </summary>
    class DiyButton : Button
    {
        //声明和注册路由事件Report
        public static readonly RoutedEvent ReportEvnet 
            = EventManager.RegisterRoutedEvent("Report",RoutingStrategy.Bubble,typeof(EventHandler<ReportEvnetArgs>),typeof(DiyButton));

        //包装CLR事件
        public event RoutedEventHandler Report
        {
            add { this.AddHandler(ReportEvnet, value); }
            remove { this.RemoveHandler(ReportEvnet, value); }
        }

        //关联RoutedEventArgs和路由事件
        //借助Button的Click事件激发方法。
        protected override void OnClick()
        {
            base.OnClick(); //保证Button的原有功能

            ReportEvnetArgs args = new ReportEvnetArgs(ReportEvnet, this);
            args.Time = DateTime.Now; //为arg的Time属性赋值
            this.RaiseEvent(args);
        }
    
    }
}
