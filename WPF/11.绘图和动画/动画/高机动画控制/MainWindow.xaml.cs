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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 高机动画控制
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

        private void btn_move_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation daX = new DoubleAnimation();
            DoubleAnimation daY = new DoubleAnimation();

            //设置反弹
            BounceEase be = new BounceEase();
            be.Bounces = 3; //弹跳三次
            be.Bounciness = 3;//弹性程度，值越大反弹越低
            daY.EasingFunction = be;

            //指定终点
            daX.To =  300;
            daY.To =  300;

            //指定时长
            Duration dur = new Duration(TimeSpan.FromMilliseconds(300));
            daX.Duration = dur;
            daY.Duration = dur;

            //启动动画
            tt_demo.BeginAnimation(TranslateTransform.XProperty, daX);
            tt_demo.BeginAnimation(TranslateTransform.YProperty, daY);
        }
    }


}
