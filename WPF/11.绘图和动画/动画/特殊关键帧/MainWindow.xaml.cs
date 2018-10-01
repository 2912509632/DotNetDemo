using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;


namespace 特殊关键帧
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
            //创建动画
            DoubleAnimationUsingKeyFrames dukX = new DoubleAnimationUsingKeyFrames();
            dukX.Duration = new Duration(TimeSpan.FromMilliseconds(1000));

            //创建，添加关键帧
            SplineDoubleKeyFrame kf = new SplineDoubleKeyFrame();
            kf.KeyTime = KeyTime.FromPercent(1);
            kf.Value = 400;
            KeySpline ks = new KeySpline();
            ks.ControlPoint1 = new Point(0,1);
            ks.ControlPoint2 = new Point(1, 0);
            kf.KeySpline = ks;
            dukX.KeyFrames.Add(kf);

            //执行动画
            tt_demo.BeginAnimation(TranslateTransform.XProperty, dukX);
        }
    }
}
