using System.Collections.Generic;
using System.Windows;


namespace DataTemplate
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            List<Car> data = new List<Car>()
            {
                new Car() { Name="ferrari",Year=1998,Area="China",Speed=456},
                new Car() { Name="lamborghini",Year=1999,Area="China",Speed=567},
                new Car() { Name="maserati",Year=2000,Area="China",Speed=678},
                new Car() { Name="maybach",Year=2001,Area="China",Speed=789}
            };

            lb_car.ItemsSource = data;
        }
    }
}
