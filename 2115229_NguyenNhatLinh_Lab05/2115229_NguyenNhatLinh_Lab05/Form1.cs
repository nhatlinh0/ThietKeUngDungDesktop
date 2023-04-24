using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2115229_NguyenNhatLinh_Lab05
{
    public partial class Form1 : Form
    {
        QuanLySinhVien qlsv;
        Form2 newform;
        public Form1()
        {
            InitializeComponent();
        }

        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = this.mtxtMSSV.Text;
            sv.Phai = false;
            if(this.rdNam.Checked)
                sv.Phai = true;
            sv.HoTenLot = this.txtHoTenLot.Text;
            sv.Ten = this.txtTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.Lop = this.cbLop.Text;
            sv.SoCMND = this.mtxtSoCMND.Text;
            sv.SDT = this.mtxtSDT.Text;
            sv.DiaChi = this.txtDiaChi.Text;
            for(int i =0;i<clbMonHoc.Items.Count;i++)
            {
                if (clbMonHoc.GetItemChecked(i))
                {
                    sv.MonHoc.Add(clbMonHoc.Items[i].ToString());
                }
            }
            return sv;
        }

        private SinhVien GetSinhSinhLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            sv.Phai = false;
            if (lvitem.SubItems[1].Text.CompareTo("Nam")==0)
                sv.Phai = true;
            sv.HoTenLot = lvitem.SubItems[2].Text;
            sv.Ten = lvitem.SubItems[3].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[4].Text);
            sv.Lop = lvitem.SubItems[5].Text;   
            sv.SoCMND = lvitem.SubItems[6].Text;
            sv.SDT = lvitem.SubItems[7].Text;
            sv.DiaChi = lvitem.SubItems[8].Text;
            string[] s = lvitem.SubItems[9].Text.Split(',');
            foreach (string t in s)
            {
                sv.MonHoc.Add(t);
            }
            return sv;
        }

        private void ThietLapThongTinSV(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.MSSV;
            if (sv.Phai == true)
                this.rdNam.Checked = true;
            else 
                this.rdNu.Checked = true;
            this.txtHoTenLot.Text = sv.HoTenLot;
            this.txtTen.Text = sv.Ten;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.cbLop.Text = sv.Lop;
            this.mtxtSoCMND.Text = sv.SoCMND;
            this.mtxtSDT.Text = sv.SDT;
            this.txtDiaChi.Text = sv.DiaChi;
            for(int i=0;i<clbMonHoc.Items.Count;i++)
            {
                clbMonHoc.SetItemChecked(i, false);
            }
            foreach(string mh in sv.MonHoc)
            {
                for(int i=0;i<this.clbMonHoc.Items.Count;i++)
                {
                    if (clbMonHoc.Items[i].ToString().CompareTo(mh)==0)
                    {
                        clbMonHoc.SetItemChecked(i, true);
                    }
                }
            }
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            if (sv.Phai == true)
                lvitem.SubItems.Add("Nam");
            else
                lvitem.SubItems.Add("Nữ");
            lvitem.SubItems.Add(sv.HoTenLot);
            lvitem.SubItems.Add(sv.Ten);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SoCMND);
            lvitem.SubItems.Add(sv.SDT);
            lvitem.SubItems.Add(sv.DiaChi);
            string mh = "";
            foreach (string s in sv.MonHoc)
            {
                mh = mh + s + ",";
            }
            lvitem.SubItems.Add(mh);
            this.lvDanhSachSV.Items.Add(lvitem);
        }

        private void LoadListView()
        {
            this.lvDanhSachSV.Items.Clear();
            foreach(SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocFile();
            LoadListView();
        }

        private void lvDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lvitem;
            SinhVien sv;
            if(lvDanhSachSV.SelectedItems.Count > 0)
            {
                lvitem = this.lvDanhSachSV.SelectedItems[0];
                sv = GetSinhSinhLV(lvitem);
                ThietLapThongTinSV(sv);
            }    
        }

        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<lvDanhSachSV.Items.Count;i++)
            {
                if (lvDanhSachSV.Items[i].Checked)
                {
                    SinhVien sv = GetSinhSinhLV(lvDanhSachSV.Items[i]);
                    qlsv.Xoa(sv.MSSV);
                }    
            }
            LoadListView();
        }

        private bool KiemTraMSSV(string ms)
        {
            bool check = true;
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                if (sv.MSSV.CompareTo(ms) == 0) 
                    check = false; 
            }
            return check;
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            bool check = true;
            SinhVien sv;
            if (this.mtxtMSSV.Text.Length < 7)
                MessageBox.Show("Mã số sinh viên phải có 7 chữ số", "Thông báo!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            else if (this.mtxtSoCMND.Text.Length < 9)
                MessageBox.Show("Số CMND phải có 9 chữ số", "Thông báo!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            else if (this.mtxtSDT.Text.Length < 10)
                MessageBox.Show("Số điện thoại phải có 10 chữ số", "Thông báo!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            else
            {
                if (this.mtxtMSSV.Text == "" || this.txtHoTenLot.Text == "" || this.txtTen.Text == "" ||
                this.mtxtSoCMND.Text == "" || this.mtxtSDT.Text == "" || this.txtDiaChi.Text == "" ||
                this.clbMonHoc.CheckedItems.Count == 0 || this.cbLop.Text == "")
                    check = false;
                if (check)
                {
                    sv = new SinhVien();
                    sv = GetSinhVien();
                    if (KiemTraMSSV(sv.MSSV)==true) 
                    {
                        qlsv.ThemSV(sv);
                        LoadListView();
                    }
                    else
                        MessageBox.Show("Mã số sinh viên đã tồn tại", "Thông báo!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool check = true;
            SinhVien sv;
            if (this.mtxtMSSV.Text.Length < 7)
                MessageBox.Show("Mã số sinh viên phải có 7 chữ số", "Thông báo!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            else if (this.mtxtSoCMND.Text.Length < 9)
                MessageBox.Show("Số CMND phải có 9 chữ số", "Thông báo!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            else if (this.mtxtSDT.Text.Length < 10)
                MessageBox.Show("Số điện thoại phải có 10 chữ số", "Thông báo!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            else
            {
                if (this.mtxtMSSV.Text == "" || this.txtHoTenLot.Text == "" || this.txtTen.Text == "" ||
                this.mtxtSoCMND.Text == "" || this.mtxtSDT.Text == "" || this.txtDiaChi.Text == "" ||
                this.clbMonHoc.CheckedItems.Count == 0 || this.cbLop.Text == "")
                    check = false;
                if (check)
                {
                    sv = new SinhVien();
                    sv = GetSinhVien();
                    if (KiemTraMSSV(sv.MSSV) == false)
                    {
                        for (int i = 0; i < qlsv.DanhSach.Count; i++) 
                        {
                            if (qlsv.DanhSach[i].MSSV.CompareTo(sv.MSSV) == 0)
                            {
                                qlsv.DanhSach[i] = sv;
                                LoadListView();
                                MessageBox.Show("Cập nhật thành công", "Thông báo!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                            }    
                        }    
                    }
                    else
                        MessageBox.Show("Mã số sinh viên không tồn tại", "Thông báo!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
                Application.Exit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            newform = new Form2();
            newform.Show();
            newform.btnTim.Click += BtnTim_Click;
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            qlsv.DanhSach1.Clear();
            if (newform.txtDuLieu.Text == "")
                MessageBox.Show("Vui lòng nhập dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (newform.rdMSSV.Checked)
                {
                    List<SinhVien> dssv = qlsv.TimTheoMSSV(newform.txtDuLieu.Text);
                    if (dssv != null)
                        foreach (SinhVien s in dssv)
                        {
                            qlsv.DanhSach1.Add(s);
                        }
                    if (qlsv.DanhSach1.Count == 0)
                        MessageBox.Show("Không tìm thấy sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        this.lvDanhSachSV.Items.Clear();
                        foreach (SinhVien s in qlsv.DanhSach1)
                        {
                            this.ThemSV(s);
                        }
                    }
                }
                if (newform.rdTen.Checked)
                {
                    List<SinhVien> dssv = qlsv.TimTheoTen(newform.txtDuLieu.Text);
                    if (dssv != null)
                        foreach (SinhVien s in dssv)
                        {
                            qlsv.DanhSach1.Add(s);
                        }
                    if (qlsv.DanhSach1.Count == 0)
                        MessageBox.Show("Không tìm thấy sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        this.lvDanhSachSV.Items.Clear();
                        foreach (SinhVien s in qlsv.DanhSach1)
                        {
                            this.ThemSV(s);
                        }
                    }
                }
                if(newform.rdLop.Checked)
                {
                    List<SinhVien> dssv = qlsv.TimTheoLop(newform.txtDuLieu.Text);
                    if (dssv != null)
                        foreach (SinhVien s in dssv)
                        {
                            qlsv.DanhSach1.Add(s);
                        }    
                    if (qlsv.DanhSach1.Count == 0)
                        MessageBox.Show("Không tìm thấy sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        this.lvDanhSachSV.Items.Clear();
                        foreach (SinhVien s in qlsv.DanhSach1)
                        {
                            this.ThemSV(s);
                        }
                    }
                }    
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadListView();
        }
    }
}
