using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace 自定义Command
{
    public class DiyCommandSource :UserControl,ICommandSource
    {
        //实现接口的属性
        public ICommand Command
        {
            get; set;
        }

        public object CommandParameter
        {
            get; set;
        }

        public IInputElement CommandTarget
        {
            get; set;
        }

        //组件被单击时执行的命令
        //重写左键单击方法
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            //在命令目标上执行命令
            if (this.CommandTarget != null)
            {
                this.Command.Execute(this.CommandTarget);
            }
        }
    }
}
