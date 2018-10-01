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

namespace _2_9_使用LINQ结果作为数据源
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

            //使用LINQ检索数据
            lv_data.ItemsSource = from x in data
                                  where x.ID > 0
                                  select x;


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
