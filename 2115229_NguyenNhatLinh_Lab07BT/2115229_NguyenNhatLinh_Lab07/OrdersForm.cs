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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }
        private void Load_Form()
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            string query = "EXECUTE ShowBills";
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            dgvBills.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            Load_Form();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                string query = string.Format("EXECUTE ShowBillsWithDate {0}, {1}", dtpTuNgay.Value.ToString("MM/dd/yyyy"), dtpDenNgay.Value.ToString("MM/dd/yyyy"));
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();
                da.Fill(dt);
                dgvBills.DataSource = dt;
                conn.Close();
                conn.Dispose();
            }
            catch
            {
                MessageBox.Show("Không tồn tại hoá đơn nào");
            }
            
        }

        private void dgvBills_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRowView row = dgvBills.SelectedRows[0].DataBoundItem as DataRowView;
            int id = int.Parse(row["ID"].ToString());
            OrderDetailsForm form = new OrderDetailsForm();
            form.Show(this);
            form.Load_Form(id);
        }
    }
}
