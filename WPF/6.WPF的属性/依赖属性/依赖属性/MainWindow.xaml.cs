using System.Windows;
using System.Windows.Data;


namespace 依赖属性
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Student stu;

        public MainWindow()
        {
            InitializeComponent();

            stu = new Student();
            Binding binding = new Binding("Text") { Source = txt_input };
            BindingOperations.SetBinding(stu, Student.MyNameProperty, binding);
        }

        private void btn_test_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(stu.MyName);
        }
    }

    //依赖对象
    public class Student : DependencyObject
    {
        //依赖属性声明
        public static readonly DependencyProperty MyNameProperty = DependencyProperty.Register("MyName", typeof(string), typeof(Student));

        //CLR属性包装器
        public string MyName
        {
            get
            {
                return (string)GetValue(MyNameProperty);
            }
            set
            {
                SetValue(MyNameProperty, value);
            }
        }
    }
}
