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
using System.Net.NetworkInformation;

namespace BaiTapNhom14_CTK45B
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }
        private string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=HotelManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";

        private int TongDoanhThu = 0;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TongDoanhThu = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("select Phong.ID, Phong.GiaTien, KhachHang.[Name], KhachHang.CCCD, DatPhong.NgayDatPhong, DatPhong.NgayNhanPhong ,DatPhong.NgayTraPhong    from Phong, LoaiPhong, KhachHang, DatPhong, HoaDon where Phong.ID = DatPhong.IDPhong and Phong.IDLoaiPhong = LoaiPhong.ID and KhachHang.ID = DatPhong.IDKhachHang and HoaDon.ID = DatPhong.IDHoaDon  and DatPhong.NgayTraPhong between '{0}' and '{1}'",
                  dtpTuNgay.Value.ToString("MM/dd/yyyy"), dtpDenNgay.Value.ToString("MM/dd/yyyy"));
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBaoCao.DataSource = dt;
            conn.Close();
            conn.Dispose();
            int count = dgvBaoCao.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataRowView row = dgvBaoCao.Rows[i].DataBoundItem as DataRowView;
                if (row != null)
                {
                    DateTime ngaynhan = DateTime.Parse(row["NgayNhanPhong"].ToString());
                    DateTime ngaytra = DateTime.Parse(row["NgayTraPhong"].ToString());
                    TimeSpan diff = ngaytra - ngaynhan;
                    int ngay = int.Parse(diff.TotalDays.ToString());
                    int giaTien = int.Parse(dgvBaoCao.Rows[i].Cells[1].Value.ToString());
                    TongDoanhThu = TongDoanhThu + (ngay * giaTien);
                }
            }
            this.txtTongDoanhThu.Text = TongDoanhThu.ToString();
        }
    }
}
