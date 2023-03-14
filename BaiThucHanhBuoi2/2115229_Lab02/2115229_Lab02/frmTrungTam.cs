using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2115229_Lab02
{
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ReSet();
        }

        private void ReSet()
        {
            this.cboMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.chkTiengAnhA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.txtTongTien.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;  
            if (chkTinHocA.Checked)
                s = s + int.Parse(lblTienTHA.Text.Split('.')[0]);
            if (chkTinHocB.Checked)
                s = s + int.Parse(lblTienTHB.Text.Split('.')[0]);
            if (chkTiengAnhA.Checked)
                s = s + int.Parse(lblTienTAA.Text.Split('.')[0]);
            if (chkTiengAnhB.Checked)
                s = s + int.Parse(lblTienTAB.Text.Split('.')[0]);
            this.txtTongTien.Text = s.ToString() + ".000 đồng";
        }
    }
}
