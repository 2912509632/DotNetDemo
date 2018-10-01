using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace 检索DataTemplate内部控件
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


        //姓名TextBox出现焦点
        private void txt_name_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = e.OriginalSource as TextBox;//获取命令的源头
            ContentPresenter cp = tb.TemplatedParent as ContentPresenter; //获取模板目标
            Student stu = cp.Content as Student; //获取访问的当前对象
            lv_demo.SelectedItem = stu; //设置选中

            //访问界面元素
            ListViewItem lvi = lv_demo.ItemContainerGenerator.ContainerFromItem(stu) as ListViewItem;
            CheckBox chb = FindVisualChild<CheckBox>(lvi);
            MessageBox.Show("CheckBox的Name值："+chb.Name);
        }


        /// <summary>
        /// 检索子级控件
        /// </summary>
        /// <typeparam name="ChildType"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        private ChildType FindVisualChild<ChildType>(DependencyObject obj)
            where ChildType:DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is ChildType)
                    return child as ChildType;
                else //检索子级的子级控件
                {
                    ChildType chidOfChild = FindVisualChild<ChildType>(child);
                    if (chidOfChild != null)
                        return chidOfChild;
                }
            }
            return null;
        }
    }
}
