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
using System.Xml.Linq;

namespace _2115229_NguyenNhatLinh_Lab06
{
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
        }

        private void Form_Load ()
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "SELECT * FROM Account";
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAccount.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }

        private int Account_Check(string name)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = string.Format("select count(*) from Account where AccountName = N'{0}'", name);
            sqlConnection.Open();
            int num =int.Parse(sqlCommand.ExecuteScalar().ToString());
            sqlConnection.Close();
            return num;
        }
        private void AccountManager_Load(object sender, EventArgs e)
        {
            Form_Load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                DataGridViewRow row = dgvAccount.SelectedRows[0];
                string name = row.Cells[0].Value.ToString();
                string password = row.Cells[1].Value.ToString();
                string fullname = row.Cells[2].Value.ToString();
                string email = row.Cells[3].Value.ToString();
                DateTime date = DateTime.Parse(row.Cells[5].Value.ToString());
                string query = string.Format("insert into Account values (N'{0}',N'{1}',N'{2}',N'{3}',NULL,'{4}')",
                      name, password, fullname, email, date.ToString("MM/dd/yyyy"));
                sqlCommand.CommandText = query;
                int num1 = Account_Check(name);
                sqlConnection.Open();
                int num = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (num == 1 && num1 == 0)
                {
                    MessageBox.Show("Đã thêm tài khoản thành công");
                    Form_Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            DataGridViewRow row = dgvAccount.SelectedRows[0];
            string name = row.Cells[0].Value.ToString();
            string password = row.Cells[1].Value.ToString();
            string fullname = row.Cells[2].Value.ToString();
            string email = row.Cells[3].Value.ToString();
            DateTime date = DateTime.Parse(row.Cells[5].Value.ToString());
            string query = string.Format("update Account set Password = N'{0}', FullName = N'{1}', Email = N'{2}', Tell = NULL, DateCreated = '{3}' where AccountName = N'{4}'",
                  password, fullname, email, date.ToString("MM/dd/yyyy"), name);
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 1)
            {
                MessageBox.Show("Đã cập nhật tài khoản thành công");
                Form_Load();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại");
            } 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            DataGridViewRow row = dgvAccount.SelectedRows[0];
            string name = row.Cells[0].Value.ToString();
            string query = string.Format("update Account set Password = N'123' where AccountName = N'{0}'", name);
            sqlCommand .CommandText = query;
            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(num ==1)
            {
                MessageBox.Show("Mật khẩu đã được reset là 123");
                Form_Load();
            }    
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
            }
        }

        private void xoáTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            DataGridViewRow row = dgvAccount.SelectedRows[0];
            string name = row.Cells[0].Value.ToString();
            string query = string.Format("delete Account where AccountName = N'{0}'", name);
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 1)
            {
                MessageBox.Show("Đã xoá thành công");
                Form_Load();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
            }
        }

        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            DataGridViewRow row = dgvAccount.SelectedRows[0];
            string name = row.Cells[0].Value.ToString();
            string query = string.Format("select RoleName from Account a, Role b, RoleAccount c where a.AccountName = c.AccountName and c.RoleID = b.ID and a.AccountName = N'{0}'", name);
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            string role = sqlCommand.ExecuteScalar().ToString();
            MessageBox.Show(role, "vai trò của " + name);
        }
    }
}
