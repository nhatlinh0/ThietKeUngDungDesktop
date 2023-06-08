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
using System.Runtime.CompilerServices;

namespace _2115229_NguyenNhatLinh_Lab07
{
    public partial class FoodInfoForm : Form
    {
        public FoodInfoForm()
        {
            InitializeComponent();
        }
        private AddNew formCat;
        private void InitValues()
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select ID, Name from Category";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            da.Fill(ds, "Category");
            cbbCatName.DataSource = ds.Tables["Category"];
            cbbCatName.DisplayMember = "Name";
            cbbCatName.ValueMember = "ID";
            conn.Close();
            conn.Dispose();

        }
        private void ResetText()
        {
            txtFoodID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cbbCatName.ResetText();
            nudPrice.ResetText();
        }
        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            this.InitValues();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "execute InsertFood @id OUTPUT, @name, @unit, @foodCategorId, @price, @notes";
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@price"].Value = nudPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;

                conn.Open();
                int num = cmd.ExecuteNonQuery();

                if (num > 0)
                {
                    string foodID = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show("Successful adding new food. Food ID = " + foodID, "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Adding food failed");
                }
                conn.Close();
                conn.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show("SQL error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        public void DisplayFoodInfo(DataRowView rowView)
        {
            try
            {
                txtFoodID.Text = rowView["ID"].ToString();
                txtName.Text = rowView["Name"].ToString();
                txtUnit.Text = rowView["Unit"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
                nudPrice.Text = rowView["Price"].ToString();
                cbbCatName.SelectedIndex = -1;
                for (int i = 0; i < cbbCatName.Items.Count; i++)
                {
                    DataRowView cat = cbbCatName.Items[i] as DataRowView;
                    if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
                    {
                        cbbCatName.SelectedIndex = i;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE UpdateFood @id, @name, @unit, @foodCategoryID, @price, @notes";
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@id"].Value = int.Parse(txtFoodID.Text);
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryID"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@price"].Value = nudPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;

                conn.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("Succesfully updating food", "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Updating food failed");
                }
                conn.Close();
                conn.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            formCat = new AddNew();
            formCat.Show();
            formCat.btnAddCat.Click += BtnAddCat_Click;
        }

        private void BtnAddCat_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement10;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            string query = string.Format("EXECUTE AddNewCategory {0}, {1}", formCat.txtCatName.Text, formCat.txtCatType.Text);
            cmd.CommandText = query;
            conn.Open();
            int num = cmd.ExecuteNonQuery();
            if (num > 0)
            {
                MessageBox.Show("Đã thêm thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
            conn.Close();
            conn.Dispose();
            InitValues();
        }
    }
}
