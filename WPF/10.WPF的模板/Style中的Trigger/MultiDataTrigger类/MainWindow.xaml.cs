using System.Collections.Generic;
using System.Windows;

namespace MultiDataTrigger类
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Student> data = new List<Student>()
            {
                new Student() { ID=1,Name="Demo",Age=21},
                new Student() { ID=2,Name="Jiuone",Age=21},
                new Student() { ID=1,Name="Demo",Age=21},
                new Student() { ID=1,Name="Demo",Age=21},
                new Student() { ID=1,Name="Demo",Age=21},
                new Student() { ID=1,Name="Demo",Age=21},
                new Student() { ID=1,Name="Demo",Age=21}
            };
            lb_demo.ItemsSource = data;
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
