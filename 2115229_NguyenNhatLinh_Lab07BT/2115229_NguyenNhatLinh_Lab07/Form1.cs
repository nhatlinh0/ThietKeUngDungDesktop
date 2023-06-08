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
    public partial class Form1 : Form
    {
        private DataTable foodTable;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadCategory()
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select ID, Name from Category";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            cbbCategory.DataSource = dt;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Food where FoodCategoryID = @categoryID ";
            cmd.Parameters.Add("@categoryID", SqlDbType.Int);
            if (cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
                cmd.Parameters["@categoryID"].Value = rowView["ID"];
            }                
            else
            {
                cmd.Parameters["@categoryID"].Value = cbbCategory.SelectedValue;
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            foodTable = new DataTable();
            conn.Open();
            da.Fill(foodTable);
            conn.Close();
            conn.Dispose();
            dgvFoodList.DataSource = foodTable;
            lblQuantity.Text = foodTable.Rows.Count.ToString();
            lblCatName.Text = cbbCategory.Text;
        }

        private void tsmCaculateQuantity_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select @numSaleFood = sum(Quantity) from BillDetails where FoodID = @foodId";
            if (dgvFoodList.SelectedRows.Count > 0 )
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                cmd.Parameters.Add("@foodId", SqlDbType.Int);
                cmd.Parameters["@foodId"].Value = rowView["ID"];
                cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
                cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.ExecuteNonQuery();
                string result = cmd.Parameters["@numSaleFood"].Value.ToString();
                MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là: " + result + " " + rowView["Unit"]);
                conn.Close();
            }
            cmd.Dispose();
            conn.Dispose();
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodInfoForm foodForm = new FoodInfoForm();
            foodForm.FormClosed += FoodForm_FormClosed;
            foodForm.Show(this);
        }

        private void FoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;
                FoodInfoForm foodForm = new FoodInfoForm();
                foodForm.FormClosed += FoodForm_FormClosed;
                foodForm.Show(this);
                foodForm.DisplayFoodInfo(rowView);
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;
            string fillterExpression = "Name like '% " + txtSearchByName.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
            DataView foodView = new DataView(foodTable,fillterExpression,sortExpression,rowStateFilter);
            dgvFoodList.DataSource = foodView;
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            form.Show(this);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountForm form = new AccountForm();
            form.Show(this);
        }
    }
}
