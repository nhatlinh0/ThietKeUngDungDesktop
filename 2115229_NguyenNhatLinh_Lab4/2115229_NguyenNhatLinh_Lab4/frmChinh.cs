using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2115229_NguyenNhatLinh_Lab4
{
    public partial class frmChinh : Form
    {
        QuanLySinhVien qlsv;
        public frmChinh()
        {
            InitializeComponent();
        }

        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = this.mtxtMSSV.Text;
            sv.HoTen = this.txtHoVaTen.Text;
            sv.Phai = this.rdNam.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.Lop = this.cbbLop.Text;
            sv.SDT = this.mtxtSoDienThoai.Text;
            sv.Email = this.txtEmail.Text;
            sv.DiaChi = this.txtDiaChi.Text; 
            sv.Hinh = this.txtHinh.Text;
            return sv;
        }

        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.Phai = lvitem.SubItems[2].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.Lop = lvitem.SubItems[4].Text;
            sv.SDT = lvitem.SubItems[5].Text;
            sv.Email = lvitem.SubItems[6].Text;
            sv.DiaChi = lvitem.SubItems[7].Text;
            sv.Hinh = lvitem.SubItems[8].Text;
            return sv;
        }

        private void ThietLapThongTinSV(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.MSSV;
            this.txtHoVaTen.Text = sv.HoTen;
            if (sv.Phai.CompareTo("Nam") == 0)
                this.rdNam.Checked = true;
            else 
                this.rdNu.Checked = true;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.cbbLop.Text = sv.Lop;
            this.mtxtSoDienThoai.Text = sv.SDT;
            this.txtDiaChi.Text = sv.DiaChi;
            this.txtEmail.Text = sv.Email;
            this.pictureBox1.ImageLocation = sv.Hinh;
        }

        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.Phai);
            lvitem.SubItems.Add(sv.NgaySinh.ToString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SDT);
            lvitem.SubItems.Add(sv.Email);
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Hinh);
            this.listView1.Items.Add(lvitem);
        }

        private void LoadListView()
        {
            this.listView1.Items.Clear();
            foreach(SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocFile();
            LoadListView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = listView1.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem;
                lvitem = listView1.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTinSV(sv);
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (DialogResult.OK == result)
            {
                this.txtHinh.Text = openFileDialog1.FileName;
                this.pictureBox1.ImageLocation = txtHinh.Text;
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMSSV.Text = "";
            this.txtHoVaTen.Text = "";
            this.rdNam.Checked = true;
            this.dtpNgaySinh.Value = DateTime.Now;
            this.cbbLop.Text = cbbLop.Items[0].ToString();
            this.mtxtSoDienThoai.Text = "";
            this.txtDiaChi.Text = "";
            this.txtEmail.Text = "";
            this.pictureBox1.ImageLocation = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            int check = -1;
            for (int i = 0; i < qlsv.DanhSach.Count; i++)
            {
                if (sv.MSSV.CompareTo(qlsv.DanhSach[i].MSSV) == 0)
                {
                    check = i;
                    break;
                }
            }
            for (int j=0; j < qlsv.DanhSach.Count; j++ )
            {
                if (check != -1)
                {
                    qlsv.DanhSach[check].HoTen = sv.HoTen;
                    qlsv.DanhSach[check].Phai = sv.Phai;
                    qlsv.DanhSach[check].NgaySinh = sv.NgaySinh;
                    qlsv.DanhSach[check].Lop = sv.Lop;
                    qlsv.DanhSach[check].SDT = sv.SDT;
                    qlsv.DanhSach[check].Email = sv.Email;
                    qlsv.DanhSach[check].DiaChi = sv.DiaChi;
                    qlsv.DanhSach[check].Hinh = sv.Hinh;
                    break;
                }
                else if (sv.MSSV.CompareTo("") == 0)
                {
                    MessageBox.Show("Mã số sinh viên không được để trống", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    qlsv.DanhSach.Add(sv);
                break;
            }
            LoadListView();
        }

        private void tảiLạiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvitem;
            for (int i=0; i< listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Checked)
                {
                    lvitem = listView1.Items[i];
                    for (int j=0; j < qlsv.DanhSach.Count; j++)
                    {
                        if (qlsv.DanhSach[j].MSSV.CompareTo(lvitem.SubItems[0].Text) ==0)
                        {
                            qlsv.DanhSach.RemoveAt(j);
                        }
                    }
                }
            }
            LoadListView() ;
        }
    }
}
