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

namespace _2_11_Binding的RelativeSource
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //使用RelativeSource对象
            RelativeSource rs = new RelativeSource();
            rs.AncestorLevel = 2; //位置偏移量
            rs.AncestorType = typeof(Grid); //指定检索元素类型

            //将查询得的元素的Name属性赋给TextBlock
            Binding binding = new Binding("Name") {RelativeSource=rs };
            txt_demo.SetBinding(TextBlock.TextProperty, binding);

        }
    }
}
