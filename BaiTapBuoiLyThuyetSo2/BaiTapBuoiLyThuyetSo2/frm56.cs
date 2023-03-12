using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoiLyThuyetSo2
{
    public partial class frm56 : Form
    {
        public frm56()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
            {
                MessageBox.Show($"Giới tính của bạn là: {rdNam.Text}", "Thông báo");
            }
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNu.Checked)
            {
                MessageBox.Show($"Giới tính của bạn là: {rdNu.Text}", "Thông báo");
            }
        }
    }
}
