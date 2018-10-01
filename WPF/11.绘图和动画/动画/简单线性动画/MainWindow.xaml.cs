using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;


namespace 简单线性动画
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

            //指定起点 不指定则从上一次结束的位置开始
            //daX.From = 0D;
            //daY.From = 0D;

            //指定终点
            Random rand = new Random();
            daX.To = rand.NextDouble() * 300;
            daY.To = rand.NextDouble() * 300;

            //指定市场
            Duration dur = new Duration(TimeSpan.FromMilliseconds(300));
            daX.Duration = dur;
            daY.Duration = dur;

            //启动动画
            tt_demo.BeginAnimation(TranslateTransform.XProperty, daX);
            tt_demo.BeginAnimation(TranslateTransform.YProperty, daY);

        }
    }
}
