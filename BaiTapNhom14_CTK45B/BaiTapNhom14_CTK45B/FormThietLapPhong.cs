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
    public partial class FormThietLapPhong : Form
    {
        public FormThietLapPhong()
        {
            InitializeComponent();
        }
        private string connectionString = @"Data Source=DESKTOP-KSD365U;Initial Catalog=HotelManagement;Persist Security Info=True;User ID=sa;Password=lumiagalaxi1";

        private void FormLoad ()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd= conn.CreateCommand();
            cmd.CommandText = "select * from Phong";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            conn.Open();
            da.Fill(dt);
            dgvDanhSachPhong.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }
        private void FormThietLapPhong_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void dgvDanhSachPhong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRowView row = dgvDanhSachPhong.SelectedRows[0].DataBoundItem as DataRowView;
            if (row != null)
            {
                txtIDPhong.Text = row["ID"].ToString();
                txtLoaiPhong.Text = row["IDLoaiPhong"].ToString();
                txtGiaTien.Text = row["GiaTien"].ToString();
                txtTang.Text = row["Tang"].ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("insert into Phong values (N'{0}',{1},{2},{3})", "Trống", txtLoaiPhong.Text, txtGiaTien.Text, txtTang.Text);
                conn.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    FormLoad();
                    MessageBox.Show("Đã thêm phòng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm phòng không thành công", "Có lỗi");
                }
                conn.Close();
                conn.Dispose();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông báo");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("update Phong set status = N'{0}', IDLoaiPhong = {1}, GiaTien = {2}, Tang = {3} where ID = {4}", "Trống", txtLoaiPhong.Text, txtGiaTien.Text, txtTang.Text, txtIDPhong.Text);
                conn.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    FormLoad();
                    MessageBox.Show("Đã sửa phòng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa phòng không thành công", "Có lỗi");
                }
                conn.Close();
                conn.Dispose();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("delete Phong where ID = {0}",txtIDPhong.Text);
                conn.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    FormLoad();
                    MessageBox.Show("Đã xoá phòng thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xoá phòng không thành công", "Có lỗi");
                }
                conn.Close();
                conn.Dispose();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
        }
    }
}
