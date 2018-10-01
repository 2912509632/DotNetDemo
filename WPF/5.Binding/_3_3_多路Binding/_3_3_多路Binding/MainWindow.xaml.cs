using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace _3_3_多路Binding
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetMultiBinding();
        }

        /// <summary>
        /// 设置多路Binding
        /// </summary>
        private void SetMultiBinding()
        {
            //实例化Binding
            Binding b1 = new Binding("Text") { Source = txt_v1 };
            Binding b2 = new Binding("Text") { Source = txt_v2 };
            Binding b3 = new Binding("Text") { Source = txt_v3 };

            //初始化多路Binding
            MultiBinding mbings = new MultiBinding() { Mode = BindingMode.OneWay,UpdateSourceTrigger=UpdateSourceTrigger.PropertyChanged };
            mbings.Bindings.Add(b1);
            mbings.Bindings.Add(b2);
            mbings.Bindings.Add(b3);
            mbings.Converter = new BtnStateConverter(); //设置数据转换器

            //关联MultiBinding
            btn_test.SetBinding(Button.IsEnabledProperty, mbings);
        }

    }

    /// <summary>
    /// 多路Binding数据转换器
    /// </summary>
    public class BtnStateConverter : IMultiValueConverter
    {
        //当数据源的值都相等时返回true否则false
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if(!values.Cast<string>().Any(text=>string.IsNullOrEmpty(text))) //判断是否有数据
            {
                if (values[0].ToString() == values[1].ToString() && values[1].ToString() == values[2].ToString())
                    return true;
                else
                    return false;
            }
            return false;
        }

        //禁止逆向转换
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
