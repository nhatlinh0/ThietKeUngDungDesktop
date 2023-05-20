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
    public partial class BillDetailsForm : Form
    {
        public BillDetailsForm()
        {
            InitializeComponent();
        }
        
        public void LoadForm ()
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;User ID=sa; Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = string.Format("select * from Bills A, BillDetails B where A.ID = B.InvoiceID");
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable("BillDetails");
            da.Fill(dataTable);
            dgvBillsDetails.DataSource = dataTable;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }
    }
}
