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
    public partial class TableDetails : Form
    {
        public TableDetails()
        {
            InitializeComponent();
        }

        public void LoadBill (string id)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select Bills.ID, Bills.[Name], Bills.TableID, Amount, Discount, Tax, Bills.[Status], CheckoutDate, Account from Bills, [Table] where Bills.TableID = [Table].ID and [Table].ID = '" + id+"'";
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTableDetails.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }
    }
}
