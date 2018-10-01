using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace _1_2_Binding基础
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

            //准备数据源
            stu = new Student();
            //准备Binding
            Binding bind = new Binding();
            bind.Source = stu; //数据源
            bind.Path = new PropertyPath("Str"); //绑定数据源的属性
            //使用Binding链接数据源与目标
            BindingOperations.SetBinding(txt_demo, TextBox.TextProperty, bind);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stu.Str += "Hello ";
        }
    }


    public class Student:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _Str;

        public string Str
        {
            get
            {
                return _Str;
            }
            set
            {
                _Str = value;
                if (PropertyChanged != null)
                {
                    //属性值改变激活事件
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Str"));
                }
            }
        }

        
    }


}
