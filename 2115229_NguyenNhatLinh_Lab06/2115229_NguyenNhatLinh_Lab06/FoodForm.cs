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
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }

        public void LoadFood (int categoryID)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;User ID=sa; Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID; 
            sqlConnection.Open();
            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;
            sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Food");
            da.Fill(dt);
            dgvFood.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }

        private void btnFoodSave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;User ID=sa; Password=lumiagalaxi1";
            string id = dgvFood.SelectedRows[0].Cells[0].Value.ToString();
            string name = dgvFood.SelectedRows[0].Cells[1].Value.ToString();
            string unit = dgvFood.SelectedRows[0].Cells[2].Value.ToString();
            string foodcategoryid = dgvFood.SelectedRows[0].Cells[3].Value.ToString();
            string price = dgvFood.SelectedRows[0].Cells[4].Value.ToString();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = string.Format("EXEC usp_ThemMonAn {0}, N'{1}', N'{2}', {3}, {4}",
                id, name, unit, foodcategoryid, price);
            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 1)
            {
                MessageBox.Show("Đã cập nhật thành công");
                LoadFood(int.Parse(foodcategoryid));
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
            }
        }

        private void btnFoodDelete_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;User ID=sa; Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            DataGridViewRow row = dgvFood.SelectedRows[0];
            string query = string.Format("delete from Food where Food.ID = {0}", row.Cells[0].Value);
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close() ;
            if (num == 1)
            {
                dgvFood.Rows.Remove(row);
                MessageBox.Show("Xoá món ăn thành công");
            }
            else
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
        }
    }
}
