using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace _1_外部XML文件作为源
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btn_load_Click(object sender, RoutedEventArgs e)
        {

            ////读取XAML数据
            //XmlDocument xml = new XmlDocument();
            //xml.Load(System.IO.Directory.GetCurrentDirectory() + @"/Data.xml");

            ////传递数据到数据提供器
            //XmlDataProvider provider = new XmlDataProvider();
            //provider.Document = xml;  //指定数据源
            //provider.XPath = @"/Info/Student"; //指定需要暴露的对象，XAML中XPath指定暴露的数据。


            //数据提供器
            XmlDataProvider provider = new XmlDataProvider();
            provider.Source = new Uri(System.IO.Directory.GetCurrentDirectory()+@"/Data.xml");
            provider.XPath = @"/Info/Student";

            //Binding数据
            lv_demo.DataContext = provider;
            lv_demo.SetBinding(ListView.ItemsSourceProperty, new Binding());
 
        }
    }
}
