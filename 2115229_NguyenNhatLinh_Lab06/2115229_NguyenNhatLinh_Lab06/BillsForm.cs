using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _2115229_NguyenNhatLinh_Lab06
{
    public partial class BillsForm : Form
    {
        public BillsForm()
        {
            InitializeComponent();
        }

        private void BillsForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;User ID=sa; Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = string.Format("select *, Amount as SoTienChuaGiamGia, (Amount * Discount) as TongSoTienGiamGia, (Amount) - (Amount * Discount) as ThucThu from Bills ");
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Bills");
            da.Fill(dt);
            dgvBills.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=RestaurantManagement;User ID=sa; Password=lumiagalaxi1";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            string query = string.Format("select *, Amount as SoTienChuaGiamGia, (Amount * Discount) as TongSoTienGiamGia, (Amount) - (Amount * Discount) as ThucThu from Bills where CheckoutDate between '{0}' and '{1}'",
                this.dtpTuNgay.Value.ToString("MM/dd/yyyy"), this.dtpDenNgay.Value.ToString("MM/dd/yyyy"));
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Bills");
            da.Fill(dt);
            dgvBills.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }

        private void dgvBills_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BillDetailsForm btf = new BillDetailsForm();
            btf.Show();
            btf.LoadForm();
        }
    }
}
