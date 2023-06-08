using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _2115229_NguyenNhatLinh_Lab07
{
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        public void Load_Form(int id)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            string query = string.Format("EXECUTE ShowBillDetails {0}", id);
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            dgvBillDetails.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }
    }
}
