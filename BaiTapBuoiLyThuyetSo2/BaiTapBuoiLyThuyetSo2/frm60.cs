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
    public partial class frm60 : Form
    {
        public frm60()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection item;
            item = this.checkedListBox1.CheckedItems;
            string s = "";
            foreach (var ob in item)
            {
                s = s + ob.ToString() + ",";
            } 
            MessageBox.Show("Danh sách môn học: " + s);
        }
    }
}
