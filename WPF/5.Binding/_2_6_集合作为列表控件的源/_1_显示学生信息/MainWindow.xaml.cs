using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1_显示学生信息
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //初始化数据源
            List<Student> data = new List<Student>() {
                new Student() { Name="Jiuone",Sex='男',ID=10000},
                new Student() { Name="Student",Sex='女',ID=10001},
                new Student() { Name="Person",Sex='男',ID=10002},
                new Student() { Name="People",Sex='女',ID=10003},
                new Student() { Name="MyName",Sex='女',ID=10004}
            };

            //绑定数据到ListBox
            lst_test.ItemsSource = data;//绑定数据源到ListBox的条目容器
            lst_test.DisplayMemberPath = "Name";//指定用于显示的属性名
           
            //使用Binding关联数据与条目容器
            Binding binding = new Binding("SelectedItem.ID") { Source=lst_test}; //初始化BInding源  "."为取对象的子级元素
            txt_current.SetBinding(TextBox.TextProperty, binding); //关联Binding目标
        }
    }


    /// <summary>
    /// 学生信息类
    /// </summary>
    public class Student
    {
        public string Name { get; set; }

        public char Sex { get; set; }

        public int ID { get; set; }
    }
}
