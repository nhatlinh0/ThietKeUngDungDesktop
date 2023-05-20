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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = "SELECT Id, Name, Type FROM Category";
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            this.DisplayCategory(sqlDataReader);
            sqlConnection.Close();
        }

        private void DisplayCategory(SqlDataReader reader)
        {
            lvCategory.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                lvCategory.Items.Add(item);
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = string.Format("insert into Category values({0}, N'{1}', {2})", txtID.Text, txtName.Text, txtType.Text);
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm món thành công");
                btnLoad.PerformClick();
                txtName.Text = "";
                txtType.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvCategory.SelectedItems[0];
            txtID.Text = item.SubItems[0].Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[2].Text == "0" ? "Thức uống" : "Đồ ăn";
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "DELETE FROM Category " + "WHERE ID = " + txtID.Text;
            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(numOfRowsEffected == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                lvCategory.Items.Remove(item);
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Xoá nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
            } 
                
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = string.Format("UPDATE Category SET ID = {0}, Name = N'{1}', Type = {2} WHERE ID = {3}", 
               txtID.Text, txtName.Text, txtType.Text, txtID.Text);
            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(numOfRowsEffected == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text = txtType.Text;
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Cập nhật món ăn thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
            }
        }

        private void xoáNhómSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvCategory.SelectedItems.Count > 0)
                btnDelete.PerformClick();
        }

        private void xemDanhSáchMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                frmFood foodForm = new frmFood();
                foodForm.Show(this);
                foodForm.LoadFood(Convert.ToInt32(txtID.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var billsForm = new BillsForm();
            billsForm.Show(this);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountManager accountManager = new AccountManager();
            accountManager.Show(this);
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show(this);
        }
    }
}
