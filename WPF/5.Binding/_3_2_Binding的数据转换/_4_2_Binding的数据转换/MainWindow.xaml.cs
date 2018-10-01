using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;


namespace _4_2_Binding的数据转换
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //初始化数据
            List<Student> data = new List<Student>()
            {
                new Student() { Name="Jiuone",CardID="42062522"},
                new Student() { Name="SoftAnts",CardID="42062542"},
                new Student() { Name="707Blog",CardID="42062532"},
                new Student() { Name="Hmister",CardID="42062582"},
                new Student() { Name="HackPlay",CardID="42062572"}
            };

            lb_data.ItemsSource = data;
        }
    }


    /// <summary>
    /// 学生信息类
    /// </summary>
    public class Student
    {
        public string Name { get; set; }

        public string CardID { get; set; } 
    }

    /// <summary>
    /// CardID转为bool类型，根据证件号倒数第二位判断是否为男
    /// </summary>
    public class CardIDToBool:IValueConverter
    {
        //从Source到Targett的数据转换
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = (string)value;
            int num=int.Parse(str[str.Length - 2].ToString());
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //逆向转换，从Target到Source的数据转换
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //不可以逆向转换，即bool值不可转换为身份证号
            throw new NotImplementedException();
        }
    }
}
