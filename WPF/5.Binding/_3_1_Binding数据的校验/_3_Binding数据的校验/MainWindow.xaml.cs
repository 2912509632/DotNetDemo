using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace _3_Binding数据的校验
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //关联TextBox与Slider的值
            Binding binding = new Binding("Value") { Source = sli_val };
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged; //触发时机
            //添加校验规则
            RangeValidationRule range = new RangeValidationRule();
            range.ValidatesOnTargetUpdated = true; //指定验证在目标更新时运行
            binding.ValidationRules.Add(range);
            //防止源数据出现问题
            binding.NotifyOnValidationError = true; //是否绑定错误附加事件
            //设置Binding
            txt_val.SetBinding(TextBox.TextProperty, binding);

            //订阅错误事件
            txt_val.AddHandler(Validation.ErrorEvent, new RoutedEventHandler(ValidationError));
        }

        /// <summary>
        /// 错误错误信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ValidationError(object sender,RoutedEventArgs e)
        {
            if(Validation.GetErrors(txt_val).Count>0)
            {
                txt_val.Text=Validation.GetErrors(txt_val)[0].ErrorContent.ToString(); //将错误信息展现在txt_val的文本框
            }
        }
    }

    /// <summary>
    /// 范围校验规则
    /// </summary>
    public class RangeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double num = 0;
            if (double.TryParse(value.ToString(), out num))
            {
                if (num >= 0 && num <= 100)
                {
                    return new ValidationResult(true, null);
                }
            }
            return new ValidationResult(false, "数据校验失败！");
        }

    }
}
