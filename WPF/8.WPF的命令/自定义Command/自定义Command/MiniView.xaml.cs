
using System.Windows.Controls;


namespace 自定义Command
{
    /// <summary>
    /// MiniView.xaml 的交互逻辑
    /// </summary>
    public partial class MiniView : UserControl,IView
    {
        public MiniView()
        {
            InitializeComponent();
        }

        public bool IsChanged { get;set; }

        public void Clear()
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
        }
    }
}
