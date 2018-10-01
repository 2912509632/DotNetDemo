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

namespace 使用二进制资源
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Uri imgrelative = new Uri(@"img/me.jpg", UriKind.Relative);
            img.Source = new BitmapImage(imgrelative);

            Uri imgAbsolute = new Uri(@"pack://application:,,,/Img/me.jpg", UriKind.Absolute);
            img.Source = new BitmapImage(imgAbsolute);
        }
    }
}
