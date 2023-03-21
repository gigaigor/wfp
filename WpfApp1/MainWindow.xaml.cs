using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public string ConnString= "Data Source=GMCV04;Initial Catalog=Nova_hac_new;Integrated Security=True;TrustServerCertificate=True";
        private DataTable dataTable = new DataTable();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void testBtn_click(object sender, System.EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM DBO.nastavit", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            conn.Close();

        }
    }
}
