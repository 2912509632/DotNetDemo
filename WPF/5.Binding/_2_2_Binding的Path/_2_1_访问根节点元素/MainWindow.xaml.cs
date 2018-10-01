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

namespace _2_1_访问根节点元素
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitData();
        }

        /// <summary>
        /// 初始化默认数据
        /// </summary>
        private void InitData()
        {
            //Test集合
            List<string> Test = new List<string>() {"Jiuone","707Blog","宅独青年","wwwlyww" };
            //绑定数据到txt_default
            Binding binding1 = new Binding("/") { Source=Test,Mode=BindingMode.OneWay};
            this.txt_default.SetBinding(TextBox.TextProperty, binding1);
            //绑定数据到txt_two
            Binding binding2 = new Binding("[1]") { Source=Test,Mode=BindingMode.OneWay};
            this.txt_two.SetBinding(TextBox.TextProperty, binding2);
            //绑定数据到txt_default_four
            Binding binding3 = new Binding("/[3]") { Source=Test,Mode=BindingMode.OneWay};
            this.txt_default_four.SetBinding(TextBox.TextProperty, binding3);
        }
    }
}
