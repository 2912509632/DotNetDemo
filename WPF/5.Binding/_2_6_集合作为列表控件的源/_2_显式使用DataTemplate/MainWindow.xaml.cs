using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2_显式使用DataTemplate
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
                new Student() { Name="MyName",Sex='女',ID=10004},
                new Student() { Name="YourName",Sex='男',ID=10005},
                new Student() { Name="WeName",Sex='男',ID=10006}
            };

            //绑定数据
            lst_demo.ItemsSource = data;


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
