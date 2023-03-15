using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2115229_Lab02_Bai02
{
    public partial class frmTimGiaoVien : Form
    {
        public frmTimGiaoVien()
        {
            InitializeComponent();
        }
        public static DanhSachGiaoVien ds = new DanhSachGiaoVien();
        public void GetDSGV(DanhSachGiaoVien dsgv)
        {
            ds = dsgv;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string value = this.txtThongTin.Text;
            frmTBGiaoVien tb = new frmTBGiaoVien();
            int count = 0;
            if(this.rdMaGV.Checked)
            {
                for(int i=0; i <ds.dsGiaoVien.Count; i++)
                {
                    if ( String.Compare(ds.dsGiaoVien[i].MaSo, value) == 0 )
                    {
                        tb.SetText(ds.dsGiaoVien[i].ToString());
                        tb.ShowDialog();
                        count = 1;
                    }
                }
                if(count ==0)
                {
                    tb.SetText("Không tìm thấy!"); 
                    tb.ShowDialog();
                }    
                
            }
            if (this.rdHoTen.Checked)
            {
                count = 0;
                for (int i = 0; i < ds.dsGiaoVien.Count; i++)
                {
                    if (String.Compare(ds.dsGiaoVien[i].HoTen, value) == 0)
                    {
                        tb.SetText(ds.dsGiaoVien[i].ToString());
                        tb.ShowDialog(); 
                        count = 1;
                    }
                }
                if (count == 0)
                {
                    tb.SetText("Không tìm thấy!");
                    tb.ShowDialog();
                }

            }
            if (this.rdSDT.Checked)
            {
                count = 0;
                for (int i = 0; i < ds.dsGiaoVien.Count; i++)
                {
                    if (String.Compare(ds.dsGiaoVien[i].SoDT, value) == 0)
                    {
                        tb.SetText(ds.dsGiaoVien[i].ToString());
                        tb.ShowDialog();
                        count = 1;
                    }
                }
                if (count == 0)
                {
                    tb.SetText("Không tìm thấy!");
                    tb.ShowDialog();
                }

            }
        }
    }
}
