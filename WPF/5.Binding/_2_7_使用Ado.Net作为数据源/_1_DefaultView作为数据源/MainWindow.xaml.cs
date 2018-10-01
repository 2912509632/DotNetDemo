using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Data;

//namespace _1_DefaultView作为数据源
//{
//    /// <summary>
//    /// MainWindow.xaml 的交互逻辑
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            InitializeComponent();

//            //从数据库读取数据到DataTable
//            DataTable dt = new DataTable();
//            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Student;Integrated Security=True");
//            string sql = "select * from Info";
//            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
//            sda.Fill(dt);

//            //绑定数据到ListView
//            lsv_demo.ItemsSource = dt.DefaultView;
//        }
//    }
//}


namespace _1_DefaultView作为数据源
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //从数据库读取数据到DataTable
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Student;Integrated Security=True");
            string sql = "select * from Info";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(dt);

            //借助DataContext属性绑定数据到ListView
            //1.将DataTable赋值给ListView的DataContext属性
            lsv_demo.DataContext = dt;
            //2.将ItemSource的Binding值设置为无Source无Path的实例。
            lsv_demo.SetBinding(System.Windows.Controls.ListView.ItemsSourceProperty, new Binding());
        }
    }
}
