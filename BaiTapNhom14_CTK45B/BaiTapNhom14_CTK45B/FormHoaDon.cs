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

namespace BaiTapNhom14_CTK45B
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }
        private string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=HotelManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
        private string ID;
        public void FormLoad (string id)
        {
            SqlConnection conn = new SqlConnection (connectionString);
            SqlCommand cmd = conn.CreateCommand ();
            cmd.CommandText = "select Phong.ID, LoaiPhong.LoaiPhong, KhachHang.[Name], KhachHang.PhoneNumber, KhachHang.CCCD, NgayDatPhong, NgayNhanPhong, NgayTraPhong, TrangThai, GiaTien\r\nfrom Phong, KhachHang, LoaiPhong, DatPhong , HoaDon\r\nwhere Phong.ID = DatPhong.IDPhong and KhachHang.ID = DatPhong.IDKhachHang and Phong.IDLoaiPhong = LoaiPhong.ID and DatPhong.IDHoaDon = HoaDon.ID and Phong.ID = " + id;
            conn.Open ();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill (dt);
            dgvTienPhong.DataSource = dt;
            conn.Close ();
            conn.Dispose ();
        }

        private void dgvTienPhong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRowView row = this.dgvTienPhong.SelectedRows[0].DataBoundItem as DataRowView;
            if (row == null)
                return;
            string id = row["ID"].ToString();
            ID = id;
            DateTime ngaynhan = DateTime.Parse(row["NgayNhanPhong"].ToString());
            DateTime ngaytra = DateTime.Parse(row["NgayTraPhong"].ToString());
            TimeSpan diff = ngaytra - ngaynhan;
            int ngay = int.Parse(diff.TotalDays.ToString());
            int tongTien = int.Parse(row["GiaTien"].ToString())  * 
              ngay;
            txtTongTien.Text = tongTien.ToString();
        }
        private int setEmpty(string id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand ();
            cmd.CommandText = "update Phong set status = N'Trống' where ID = "+ ID;
            conn.Open();
            int num = 0;
            num = cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            return num;
        }
        private void insertHoaDon ()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("insert into [dbo].[HoaDon] ([TongTienPhong]) values ({0})",txtTongTien.Text);
            conn.Open();
            int num = 0;
            num = cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }
        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            double tongTien = double.Parse(txtTongTien.Text);
            double tienKhach = double.Parse(txtKhachThanhToan.Text);
            double tienThua = tienKhach - tongTien;
            if (tienThua > 0)
            {
                txtTienThua.Text = tienThua.ToString();
                setEmpty(ID);
                insertHoaDon();
                MessageBox.Show("Thanh toán thành công\n Tiền thừa là :"+tienThua.ToString(),"Thông báo", MessageBoxButtons.OK);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                txtTienThua.Text = "";
                MessageBox.Show("Thanh toán không thành công","Thông báo");
            }
        }

        private void btnTinhTienThua_Click(object sender, EventArgs e)
        {
            double tongTien = double.Parse(txtTongTien.Text);
            double tienKhach = double.Parse(txtKhachThanhToan.Text);
            double tienThua = tienKhach - tongTien;
            if (tienThua > 0)
            {
                txtTienThua.Text = tienThua.ToString();
            }
            else
            {
                txtTienThua.Text = "";
            }
        }
    }
}
