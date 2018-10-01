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

namespace _2_10_使用ObjectDataProvider作为数据源
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetBinding();
        }

        //绑定数据源
        private void SetBinding()
        {
            //使用ObjectDataProvider数据提供器
            ObjectDataProvider odp = new ObjectDataProvider();
            odp.ObjectInstance = new Computer();   //设置odp的数据源
            odp.MethodName = "Sum"; //设置操作的函数名
            odp.MethodParameters.Add("0"); //设置函数传入参数
            odp.MethodParameters.Add("0");

            //设置txt_a的数据源
            Binding bindToA = new Binding("MethodParameters[0]")  //Path 为参数1
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            //设置txt_b的数据源
            Binding bindToB = new Binding("MethodParameters[1]")  //Parh 为参数2
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            //设置txt_sum的数据源
            Binding bindToSum = new Binding(".") { Source = odp }; //Path 为Binding本身

            //设置Binding
            txt_a.SetBinding(TextBox.TextProperty, bindToA);
            txt_b.SetBinding(TextBox.TextProperty, bindToB);
            txt_sum.SetBinding(TextBox.TextProperty, bindToSum);

        }
    }


    /// <summary>
    /// 数字计算类
    /// </summary>
    public class Computer
    {
        public string Sum(string a, string b)
        {
            double x = 0;
            double y = 0;
            double sum = 0;

            if (double.TryParse(a, out x) && double.TryParse(b, out y))
            {
                sum = x + y;
            }
            return sum.ToString();
        }
    }
}
