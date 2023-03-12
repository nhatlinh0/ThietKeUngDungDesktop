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
    public partial class frm52 : Form
    {
        public frm52()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lbDanhSach.SelectedItems.Count; i++)
            {
                lbChon.Items.Add(lbDanhSach.SelectedItems[i]);
                lbDanhSach.Items.RemoveAt(lbDanhSach.SelectedIndices[i]);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lbChon.SelectedItems.Count; i++)
            {
                lbDanhSach.Items.Add(lbChon.SelectedItems[i]);
                lbChon.Items.RemoveAt(lbChon.SelectedIndices[i]);
            }
        }
    }
}
