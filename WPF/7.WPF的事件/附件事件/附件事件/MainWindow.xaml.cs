using System.Windows;

namespace 附件事件
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

        /// <summary>
        /// 附件事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentNameChangedHandler(object sender, RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as Student).ID.ToString());
        }

        /// <summary>
        /// 单击事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //改变Student实例的值激发事件
            Student stu = new Student() { Name="Tim",ID=1000};
            stu.Name = "Tom";
            //准备事件消息并发送
            RoutedEventArgs args = new RoutedEventArgs(Student.NameChangedEvent, stu);
            this.btn_test.RaiseEvent(args);
        }
    }


    /// <summary>
    /// 附加事件，Nmae属性改变，显示Id
    /// </summary>
    public class Student
    {
        //声明注册附加路由事件
        public static readonly RoutedEvent NameChangedEvent  
            = EventManager.RegisterRoutedEvent("NameChanged",RoutingStrategy.Bubble,typeof(RoutedEventHandler),typeof(Student));

        //添加事件侦听器
        public static void AddNameChangedHandler(DependencyObject d,RoutedEventHandler r)
        {
            UIElement e = d as UIElement;
            if (e != null)
            {
                e.AddHandler(Student.NameChangedEvent, r);
            }
        }

        //移除事件侦听器
        public static void RemoveNameChangedHandler(DependencyObject d, RoutedEventHandler r)
        {
            UIElement e = d as UIElement;
            if (e != null)
            {
                e.RemoveHandler(Student.NameChangedEvent, r);
            }
        }


        public string Name { get; set; }

        public int ID { get; set; }
    }

}
