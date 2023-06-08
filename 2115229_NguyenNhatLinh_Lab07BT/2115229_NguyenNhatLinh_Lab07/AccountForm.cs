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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        public void LoadAccount()
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            string query = "EXEC ShowAccount";
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            dgvAccount.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            DataRowView row = dgvAccount.SelectedRows[0].DataBoundItem as DataRowView;
            string accountname = row["AccountName"].ToString();
            string password = row["Password"].ToString();
            string fullname = row["FullName"].ToString();
            string email = row["Email"].ToString();
            string tell = row["Tell"].ToString();
            DateTime date = DateTime.Parse(row["DateCreated"].ToString());

            string query = string.Format("EXEC InsertAccount N'{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5}'", accountname, password, fullname, email, tell, date.ToString("MM/dd/yyyy"));
            cmd.CommandText = query;
            conn.Open();
            int num = cmd.ExecuteNonQuery();
            if (num >0)
            {
                MessageBox.Show("Đã thêm tài khoản thành công");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }    
            conn.Close() ;
            conn.Dispose() ;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            DataRowView row = dgvAccount.SelectedRows[0].DataBoundItem as DataRowView;
            string accountname = row["AccountName"].ToString();
            string password = row["Password"].ToString();
            string fullname = row["FullName"].ToString();
            string email = row["Email"].ToString();
            string tell = row["Tell"].ToString();
            DateTime date = DateTime.Parse(row["DateCreated"].ToString());
            string query = string.Format("exec UpdateAccount N'{0}', N'{1}', N'{2}', N'{3}', N'{4}','{5}'", accountname, password, fullname, email, tell, date.ToString("MM/dd/yyyy"));
            cmd.CommandText = query;
            conn.Open();
            int num = cmd.ExecuteNonQuery();
            if (num > 0)
            {
                MessageBox.Show("Đã thêm tài khoản thành công");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.Close();
            conn.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            DataRowView row = dgvAccount.SelectedRows[0].DataBoundItem as DataRowView;
            string accountname = row["AccountName"].ToString();
            string query = string.Format("EXEC ResetAccount N'{0}'", accountname);
            cmd.CommandText = query;
            conn.Open();
            int num = cmd.ExecuteNonQuery();
            if (num > 0)
            {
                MessageBox.Show("Đã cập nhật mật khẩu thành 123");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.Close();
            conn.Dispose();

        }
    }
}
