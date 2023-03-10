using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2115229_NguyenNhatLinh_Lab02
{
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int so;
            for(int i = 1; i <= 10; i++)
            {
                so = rand.Next(1, 100);
                listBox1.Items.Add(so);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtSo.Text);
            lbKetQua.Text = "Không tìm thấy";
            foreach (int so in listBox1.Items)
            {
                if (so == soCanTim)
                {
                    lbKetQua.Text = "Tìm thấy";
                    break;
                }
            }
        }
    }
}
