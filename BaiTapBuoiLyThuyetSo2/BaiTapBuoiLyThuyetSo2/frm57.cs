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
    public partial class frm57 : Form
    {
        public frm57()
        {
            InitializeComponent();
        }

        private void ckbMauChu_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbMauChu.Checked)
            {
                btnButton.ForeColor = Color.Red;
            }
            else
            {
                btnButton.ForeColor = Color.Black;
            }
        }

        private void ckbMauNen_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbMauNen.Checked)
            {
                btnButton.BackColor = Color.LightCyan;
            }
            else
            {
                btnButton.BackColor = btnButtonFlat.BackColor;
            } 
                
        }

        private void rdFlat_CheckedChanged(object sender, EventArgs e)
        {
            if(rdFlat.Checked)
            {
                btnButtonFlat.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                btnButtonFlat.FlatStyle = FlatStyle.Popup;
            }
        }
    }
}
