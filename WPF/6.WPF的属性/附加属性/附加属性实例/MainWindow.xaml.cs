using System.Windows;


namespace 附加属性实例
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Human human = new Human();
            Student.SetNumIDProperty(human, 1000);

            MessageBox.Show("学生的学号是："+Student.GetNumIDProperty(human));
        }
    }


    /// <summary>
    /// 人类
    /// </summary>
    public class Human:DependencyObject
    {
        public string Name { get; set; }
    }

    /// <summary>
    /// 学生类 
    /// </summary>
    public class Student:Human
    {
        public static int GetNumIDProperty(DependencyObject obj)
        {
            return (int)obj.GetValue(NumIDPropertyProperty);
        }

        public static void SetNumIDProperty(DependencyObject obj, int value)
        {
            obj.SetValue(NumIDPropertyProperty, value);
        }

        //学生信息学号附加属性
        public static readonly DependencyProperty NumIDPropertyProperty =
            DependencyProperty.RegisterAttached("NumIDProperty", typeof(int), typeof(Student), new PropertyMetadata(0));
    }

}
