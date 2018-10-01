using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;


namespace 路径动画
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //从Grid资源字典里获取路径数据
            PathGeometry pg = gv_demo.FindResource("movingPath") as PathGeometry;
            Duration dur = new Duration(TimeSpan.FromMilliseconds(600));

            //创建动画
            DoubleAnimationUsingPath dapX = new DoubleAnimationUsingPath();
            dapX.PathGeometry = pg;
            dapX.Source = PathAnimationSource.X;
            dapX.Duration = dur;

            DoubleAnimationUsingPath dapY = new DoubleAnimationUsingPath();
            dapY.PathGeometry = pg;
            dapY.Source = PathAnimationSource.Y;
            dapY.Duration = dur;

            //自动返回，永远循环
            dapX.AutoReverse = true;
            dapX.RepeatBehavior = RepeatBehavior.Forever;

            dapY.AutoReverse = true;
            dapY.RepeatBehavior = RepeatBehavior.Forever;


            //执行动画
            tt_demo.BeginAnimation(TranslateTransform.XProperty, dapX);
            tt_demo.BeginAnimation(TranslateTransform.YProperty, dapY);
        }
    }
}
