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
using System.Threading;
using System.Drawing.Printing;

namespace BaiTapNhom14_CTK45B
{
    public partial class FormRoom : Form
    {
        public FormRoom()
        {
            InitializeComponent();
        }
        private string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=HotelManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";
        
        private void FormRoom_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd= conn.CreateCommand();
            cmd.CommandText = "select * from LoaiPhong";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            cbbLoaiPhong.DataSource = dt;
            cbbLoaiPhong.DisplayMember = "LoaiPhong";
            cbbLoaiPhong.ValueMember = "ID";
            btnChuaSD.PerformClick();
        }

        private void btnChuaSD_Click(object sender, EventArgs e)
        {
            flpRoom.Controls.Clear();
            btnThanhToan.Enabled = false;
            btnSuDung.Enabled = true;
            btnDatPhong.Enabled = true;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from Phong where status = N'Trống'";
            conn.Open();
            string count = cmd.ExecuteScalar().ToString();
            conn.Close();
            cmd.CommandText = "select * from Phong where status like N'Trống'";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            for (int i = 0; i < int.Parse(count); i++)
            {
                DataRow row = dt.Rows[i];
                string id = row["ID"].ToString();
                string status = row["Status"].ToString();
                string tang = row["Tang"].ToString();
                int soPhong = int.Parse(tang) * 100 + int.Parse(id);
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 100;
                btn.Text = soPhong.ToString();
                btn.Click += Btn_Click;
                flpRoom.Controls.Add(btn);
            }
        }

        private void btnDangSD_Click(object sender, EventArgs e)
        {
            flpRoom.Controls.Clear();
            btnSuDung.Enabled = false;
            btnDatPhong.Enabled = false;
            btnThanhToan.Enabled = true;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from Phong where status = N'Đang dùng'";
            conn.Open();
            string count = cmd.ExecuteScalar().ToString();
            conn.Close();
            cmd.CommandText = "select * from Phong where status like N'Đang dùng'";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            for (int i = 0; i < int.Parse(count); i++)
            {
                DataRow row = dt.Rows[i];
                string id = row["ID"].ToString();
                string status = row["Status"].ToString();
                string tang = row["Tang"].ToString();
                int soPhong = int.Parse(tang) * 100 + int.Parse(id);
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 100;
                btn.Text = soPhong.ToString();
                btn.BackColor = Color.Green;
                btn.Click += Btn_Click;
                flpRoom.Controls.Add(btn);
            }
        }

        private void btnDaDat_Click(object sender, EventArgs e)
        {
            flpRoom.Controls.Clear();
            btnDatPhong.Enabled = false;
            btnThanhToan.Enabled = false;
            btnSuDung.Enabled = true;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from Phong where status = N'Đã đặt'";
            conn.Open();
            string count = cmd.ExecuteScalar().ToString();
            conn.Close();
            cmd.CommandText = "select * from Phong where status like N'Đã đặt'";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            for (int i = 0; i < int.Parse(count); i++)
            {
                DataRow row = dt.Rows[i];
                string id = row["ID"].ToString();
                string status = row["Status"].ToString();
                string tang = row["Tang"].ToString();
                int soPhong = int.Parse(tang) * 100 + int.Parse(id);
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 100;
                btn.Text = soPhong.ToString();
                btn.BackColor = Color.Yellow;
                btn.Click += Btn_Click;
                flpRoom.Controls.Add(btn);
            }
        }

        private void btnDangBaoTri_Click(object sender, EventArgs e)
        {
            flpRoom.Controls.Clear();
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from Phong";
            conn.Open();
            string count = cmd.ExecuteScalar().ToString();
            conn.Close();
            cmd.CommandText = "select * from Phong";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            for (int i = 0; i < int.Parse(count); i++)
            {
                DataRow row = dt.Rows[i];
                string id = row["ID"].ToString();
                string status = row["Status"].ToString();
                string tang = row["Tang"].ToString();
                int soPhong = int.Parse(tang) * 100 + int.Parse(id);
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 100;
                btn.Text = soPhong.ToString();
                switch (status)
                {
                    case "Trống":
                        btnThanhToan.Enabled = false;
                        btnSuDung.Enabled = true;
                        btnDatPhong.Enabled = true;
                        break;
                    case "Đang dùng":
                        btnThanhToan.Enabled = true;
                        btnSuDung.Enabled = false;
                        btnDatPhong.Enabled = false;
                        btn.BackColor = Color.Green;
                        break;
                    case "Đã đặt":
                        btnThanhToan.Enabled = false;
                        btnSuDung.Enabled = true;
                        btnDatPhong.Enabled = false;
                        btn.BackColor = Color.Yellow;
                        break;
                }
                btn.Tag = id;
                btn.Click += Btn_Click;
                flpRoom.Controls.Add(btn);
            }
        }

        private void getRoom (string id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format(" select * from Phong A, LoaiPhong B, DatPhong C, KhachHang D where A.IDLoaiPhong = B.ID and C.IDPhong = A.ID and C.IDKhachHang = D.ID and A.ID = {0}", id);
            SqlDataAdapter da = new SqlDataAdapter (cmd);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill (dt);
            conn.Close ();
            conn.Dispose ();
            DataRow row = dt.Rows[0];
            string status = row["Status"].ToString();
            DateTime ngaydat = DateTime.Parse(row["NgayDatPhong"].ToString());
            DateTime ngaynhan = DateTime.Parse(row["NgayNhanPhong"].ToString());
            DateTime ngaytra = DateTime.Parse(row["NgayTraPhong"].ToString());
            if (status == "Trống")
            {
                txtTenKH.Text = "";
                txtSDT.Text = "";
                txtCCCD.Text = "";
                txtIDPhong.Text = id;
                txtStatus.Text = row["Status"].ToString();
                txtLoaiPhong.Text = row["LoaiPhong"].ToString();
                txtTang.Text = row["Tang"].ToString();
                dtpDatPhong.Value = DateTime.Today;
                dtpNhanPhong.Value = DateTime.Today;
                dtpTraPhong.Value = DateTime.Today;
            }  
            else
            {
                txtIDPhong.Text = id;
                txtStatus.Text = row["Status"].ToString();
                txtLoaiPhong.Text = row["LoaiPhong"].ToString();
                txtTang.Text = row["Tang"].ToString();
                txtTenKH.Text = row["Name"].ToString();
                txtSDT.Text = row["PhoneNumber"].ToString();
                txtCCCD.Text = row["CCCD"].ToString();
                dtpDatPhong.Value = DateTime.Parse(row["NgayDatPhong"].ToString());
                dtpNhanPhong.Value = DateTime.Parse(row["NgayNhanPhong"].ToString());
                dtpTraPhong.Value = DateTime.Parse(row["NgayTraPhong"].ToString());
            }
        }
        private string getIDKhachHang(string id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format(" select D.ID from Phong A, LoaiPhong B, DatPhong C, KhachHang D where A.IDLoaiPhong = B.ID and C.IDPhong = A.ID and C.IDKhachHang = D.ID and A.ID = {0}", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            DataRow row = dt.Rows[0];
            string idkhachhang = row["ID"].ToString();
            return idkhachhang;
        }
        private int setDate (string id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format(" update [DatPhong] set [NgayDatPhong] = '{0}', [NgayNhanPhong]= '{1}', [NgayTraPhong]='{2}' where IDPhong = {3}",
                dtpDatPhong.Value.ToString("MM/dd/yyyy"), dtpNhanPhong.Value.ToString("MM/dd/yyyy"), dtpTraPhong.Value.ToString("MM/dd/yyyy"), id);
            conn.Open();
            int num = cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            return num;
        }
        private int setRoom (string id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            txtIDPhong.Text = id;
            string idKhachHang = getIDKhachHang(id);
            string name = txtTenKH.Text;
            string sdt = txtSDT.Text;
            string cccd = txtCCCD.Text;
            if (txtTenKH.Text == "" || txtSDT.Text == ""|| txtCCCD.Text == "")
            {
                return 0;
            }
            cmd.CommandText = string.Format("update KhachHang set Name = N'{0}', PhoneNumber = '{1}', CCCD = '{2}' where id = {3}", name,sdt,cccd, idKhachHang);
            conn.Open();
            int num = cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            return num;
        }
        private string checkStatusRoom (string id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Phong where Phong.ID =" + id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            DataRow row = dt.Rows[0];
            string status = row["Status"].ToString();
            return status;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int length = sender.ToString().Length;
            string stringid = sender.ToString().Substring(length -2, 2);
            getRoom (stringid);
            string status = checkStatusRoom (stringid);
            switch (status)
            {
                case "Trống":
                    btnThanhToan.Enabled = false;
                    btnSuDung.Enabled = true;
                    btnDatPhong.Enabled = true;
                    btnHuy.Enabled = false;
                    break;
                case "Đang dùng":
                    btnThanhToan.Enabled = true;
                    btnSuDung.Enabled = false;
                    btnDatPhong.Enabled = false;
                    btnHuy.Enabled = false;
                    break;
                case "Đã đặt":
                    btnThanhToan.Enabled = false;
                    btnSuDung.Enabled = true;
                    btnDatPhong.Enabled = false;
                    btnHuy.Enabled = true;
                    break;
            }
        }

        private int insertKhachHang ()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("EXEC InsertKhachHang @id OUTPUT, N'{0}','{1}','{2}' ", txtTenKH.Text, txtSDT.Text, txtCCCD.Text);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Direction = ParameterDirection.Output;
            string idkh = cmd.Parameters["id"].ToString();
            MessageBox.Show(idkh);
            int num = 0;
            conn.Open();
            num = cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            return num;
        }

        private void insertHoaDon()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("insert into [dbo].[HoaDon] ([TongTienPhong],[TrangThai]) values (0,0)");
            conn.Open();
            int num = 0;
            num = cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }


        private void btnSuDung_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtIDPhong.Text;
                int check = setRoom(id);
                if (check != 0 && setDate(id) > 0)
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format("update Phong set status = N'Đang dùng' where ID = {0}", id);
                    
                    conn.Open();
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0 && check > 0)
                    {
                        MessageBox.Show("Đã sử dụng phòng thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Sử dụng phòng không thành công", "Có lỗi");
                    }
                    conn.Close();
                    conn.Dispose();
                    btnChuaSD.PerformClick();
                }
                else
                    MessageBox.Show("Thông tin khách hàng không được để trống", "Có lỗi");
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ngày tháng không hợp lệ", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phòng", "Thông báo");
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtIDPhong.Text;
                int check = setRoom(id);
                if (check != 0 && setDate(id) > 0)
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format("update Phong set status = N'Đã đặt' where ID = {0}", id);
                    conn.Open();
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0 && check > 0)
                    {
                        MessageBox.Show("Đã đặt phòng thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Đặt phòng không thành công", "Có lỗi");
                    }
                    conn.Close();
                    conn.Dispose();
                    btnDaDat.PerformClick();
                }
                else
                    MessageBox.Show("Thông tin khách hàng không được để trống", "Có lỗi");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ngày tháng không hợp lệ", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phòng", "Thông báo");
            } 
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "" || txtSDT.Text == "" || txtCCCD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                 return;
            }
            string id = txtIDPhong.Text;
           FormHoaDon form = new FormHoaDon();
            form.Show(this);
            form.FormLoad(id);
            btnChuaSD.PerformClick();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string id = txtIDPhong.Text;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = string.Format("update Phong set status = N'Trống' where ID = {0}", id);
            conn.Open();
            int num = cmd.ExecuteNonQuery();
            if (num > 0)
            {
                MessageBox.Show("Đã huỷ đặt phòng thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Huỷ đặt phòng không thành công", "Có lỗi");
            }
            conn.Close();
            conn.Dispose();
            btnChuaSD.PerformClick();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            flpRoom.Controls.Clear();
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from Phong, LoaiPhong where Phong.IDLoaiPhong = LoaiPhong.ID and LoaiPhong.ID =" + cbbLoaiPhong.SelectedValue;
            conn.Open();
            string count = cmd.ExecuteScalar().ToString();
            conn.Close();
            cmd.CommandText = "select * from Phong, LoaiPhong where Phong.IDLoaiPhong = LoaiPhong.ID and LoaiPhong.ID =" + cbbLoaiPhong.SelectedValue;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            conn.Dispose();
            for (int i = 0; i < int.Parse(count); i++)
            {
                DataRow row = dt.Rows[i];
                string id = row["ID"].ToString();
                string status = row["Status"].ToString();
                string tang = row["Tang"].ToString();
                int soPhong = int.Parse(tang) * 100 + int.Parse(id);
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 100;
                btn.Text = soPhong.ToString();
                switch (status)
                {
                    case "Đang dùng":
                        btn.BackColor = Color.Green;
                        break;
                    case "Đã đặt":
                        btn.BackColor = Color.Yellow;
                        break;
                }
                btn.Click += Btn_Click;
                flpRoom.Controls.Add(btn);
            }
        }

        private void btnThietLap_Click(object sender, EventArgs e)
        {
            FormThietLapPhong form = new FormThietLapPhong();
            form.Show(this);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FormBaoCao form = new FormBaoCao();
            form.Show(this);
        }
    }
}
