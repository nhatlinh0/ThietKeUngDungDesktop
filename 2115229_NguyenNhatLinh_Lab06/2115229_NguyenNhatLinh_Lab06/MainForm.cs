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

namespace _2115229_NguyenNhatLinh_Lab06
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form_Load()
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select * from [dbo].[Table]";
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Table");
            da.Fill(dt);
            dgvTables.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Form_Load();
        }

        private void dgvTables_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvTables.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            TableDetails tb = new TableDetails();
            tb.Show(this);
            tb.LoadBill(id);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                DataGridViewRow row = dgvTables.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                string status = row.Cells[2].Value.ToString();
                string capacity = row.Cells[3].Value.ToString();
                string query = string.Format("insert into [Table] values ({0},N'{1}',{2},{3})", id, name, status, capacity);
                sqlCommand.CommandText = query;
                sqlConnection.Open();
                int num = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (num == 1)
                {
                    MessageBox.Show("Đã thêm bàn thành công");
                    Form_Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            DataGridViewRow row = dgvTables.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            string name = row.Cells[1].Value.ToString();
            string status = row.Cells[2].Value.ToString();
            string capacity = row.Cells[3].Value.ToString();
            string query = string.Format("update [Table] set [Name] = N'{0}',[Status]={1},Capacity={2} where [ID] = {3}", name, status, capacity, id);
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 1)
            {
                MessageBox.Show("Đã cập nhật bàn thành công");
                Form_Load();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
            }
        }

        private void xoáBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            DataGridViewRow row = dgvTables.SelectedRows[0];
            string id = row.Cells[0].Value.ToString();
            sqlCommand.CommandText = string.Format("delete [Table] where ID = '{0}'", id);
            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 1)
            {
                MessageBox.Show("Đã xoá bàn thành công");
                Form_Load();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
            }
        }
    }
}
