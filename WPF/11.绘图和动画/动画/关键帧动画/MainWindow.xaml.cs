using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace 关键帧动画
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
            //声明关键帧动画属性实例
            DoubleAnimationUsingKeyFrames dukX = new DoubleAnimationUsingKeyFrames();
            DoubleAnimationUsingKeyFrames dukY = new DoubleAnimationUsingKeyFrames();

            //设置动画总时长
            dukX.Duration = new Duration(TimeSpan.FromMilliseconds(900));
            dukY.Duration = new Duration(TimeSpan.FromMilliseconds(900));

            //创建，添添加关键帧
            LinearDoubleKeyFrame x_kf_1 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame x_kf_2 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame x_kf_3 = new LinearDoubleKeyFrame();

            //添加X属性关键帧
            x_kf_1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(300));
            x_kf_1.Value = 200;
            x_kf_2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(600));
            x_kf_2.Value = 0;
            x_kf_3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(900));
            x_kf_3.Value = 200;

            dukX.KeyFrames.Add(x_kf_1);
            dukX.KeyFrames.Add(x_kf_2);
            dukX.KeyFrames.Add(x_kf_3);

            //添加Y属性关键帧
            //创建，添添加关键帧
            LinearDoubleKeyFrame y_kf_1 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame y_kf_2 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame y_kf_3 = new LinearDoubleKeyFrame();

            y_kf_1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(300));
            y_kf_1.Value = 0;
            y_kf_2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(600));
            y_kf_2.Value = 180;
            y_kf_3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(900));
            y_kf_3.Value = 180;

            dukY.KeyFrames.Add(y_kf_1);
            dukY.KeyFrames.Add(y_kf_2);
            dukY.KeyFrames.Add(y_kf_3);

            //执行动画
            tt_demo.BeginAnimation(TranslateTransform.XProperty, dukX);
            tt_demo.BeginAnimation(TranslateTransform.YProperty, dukY);
        }
    }
}
