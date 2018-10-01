using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace 自定义Command
{
    public class ClearCommand : ICommand
    {
        //当命令可执行状态发生改变时，应当被激发。
        public event EventHandler CanExecuteChanged;

        //判断命令是否可以实现
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        //命令执行带有与业务逻辑相关的内容
        public void Execute(object parameter)
        {
            IView view = parameter as IView;
            if (view != null)
            {
                view.Clear();
            }
        }
    }
}
