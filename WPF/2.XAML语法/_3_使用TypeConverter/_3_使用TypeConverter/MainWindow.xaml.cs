using System;
using System.Windows;


namespace _3_使用TypeConverter
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Student s = (Student)this.FindResource("test");
            MessageBox.Show(s.Name);
        }
    }
}
