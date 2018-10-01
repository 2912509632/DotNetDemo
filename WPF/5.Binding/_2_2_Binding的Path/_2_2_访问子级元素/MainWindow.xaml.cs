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

namespace _2_2_访问子级元素
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
        /// 初始化绑定
        /// </summary>
        private void InitData()
        {
            //填充数据
            List<Test> data = new List<Test>() {
                new Test() { Name="One",Child=new List<string>() { "One1","One2","One3"} },
                new Test() { Name="Two",Child=new List<string>() { "Two1", "Two2", "Two3" } },
                new Test() { Name="Three",Child=new List<string>() { "Three1", "Three2", "Three3" } },
                new Test() { Name="Four",Child=new List<string>() { "Four1", "Four2", "Four3" } }
            };
            //Binding txt_val
            Binding binding = new Binding("/Child/") { Source = data, Mode = BindingMode.OneWay };
            this.txt_val.SetBinding(TextBox.TextProperty, binding);
            //Binding txt_two
            Binding binding1 = new Binding("/Child[1]") { Source = data, Mode = BindingMode.OneWay };
            this.txt_two.SetBinding(TextBox.TextProperty, binding1);

        }

    }

    public class Test
    {
        public string Name { get; set; }

        public List<string> Child { get; set; }
    }
}
