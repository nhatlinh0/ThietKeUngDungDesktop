using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2115229_Lab02_Bai02
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
            this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachMH.SelectedItems.Count - 1 ;
            while (i >= 0)
            {
                this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
                this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
                i--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbMonHocDay.SelectedItems.Count - 1 ;
            while (i >= 0)
            {
                this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
                this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
                i--;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = true;

            for (int i =0; i< chklbNgoaiNgu.Items.Count; i++)
            {
                chklbNgoaiNgu.SetItemChecked(i, false);
            }

            foreach (object ob in lbMonHocDay.Items)
            {
                this.lbDanhSachMH.Items.Add(ob);
            }
            lbMonHocDay.Items.Clear();
        }

        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = e.Link.LinkData.ToString();
            Process.Start(link);
        }

        public GiaoVien GetGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text;
            gv.SoDT = this.mtxtSoDT.Text;

            string ngoaingu = "";
            for(int i=0; i< chklbNgoaiNgu.Items.Count; i++)
            {
                if(chklbNgoaiNgu.GetItemChecked(i))
                {
                    ngoaingu += chklbNgoaiNgu.Items[i] + ";";
                }    
            }
            gv.NgoaiNgu = ngoaingu.Split(';');

            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach ( object ob in lbMonHocDay.Items)
            {
                mh.Them(new MonHoc(ob.ToString()));
            }    
            gv.dsMonHoc= mh;
            return gv;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmTBGiaoVien tb = new frmTBGiaoVien();
            tb.SetText(GetGiaoVien().ToString());
            tb.ShowDialog();
        }

        private void lbDanhSachMH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static DanhSachGiaoVien ds = new DanhSachGiaoVien();
        public static frmTBGiaoVien tb = new frmTBGiaoVien();
        public static frmTimGiaoVien tim = new frmTimGiaoVien();
        private void btnThem_Click(object sender, EventArgs e)
        {
            string s = "Danh sách giáo viên: \n";
            if (ds.dsGiaoVien.Count  < 1)
            {
                ds.dsGiaoVien.Add(GetGiaoVien());
                tb.SetText(ds.dsGiaoVien[0].ToString());
                tb.ShowDialog();
            }
            else
            {
                for(int i=0;i< ds.dsGiaoVien.Count;i++)
                {
                    if ( String.Compare(ds.dsGiaoVien[i].MaSo, GetGiaoVien().MaSo) == 0)
                    {
                        MessageBox.Show("Mã số phải khác nhau");
                        return;
                    }    
                }
                ds.dsGiaoVien.Add(GetGiaoVien());
                for (int i = 0; i < ds.dsGiaoVien.Count; i++)
                {
                    s = s + ds.dsGiaoVien[i].ToString() + "\n\n";
                } 
                    
                tb.SetText(s);
                tb.ShowDialog();
            }
            tim.GetDSGV(ds);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            tim.ShowDialog();
        }
    }
}
