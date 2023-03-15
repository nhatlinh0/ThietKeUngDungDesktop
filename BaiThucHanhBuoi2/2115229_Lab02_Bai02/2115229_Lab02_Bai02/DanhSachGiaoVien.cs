using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace _2115229_Lab02_Bai02
{
    public class DanhSachGiaoVien
    {
        public List<GiaoVien> dsGiaoVien;
        public DanhSachGiaoVien()
        {
            this.dsGiaoVien = new List<GiaoVien>();
        }
        
        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index] as GiaoVien; }
            set { dsGiaoVien[index] = value; }
        }
        public void Them (GiaoVien gv)
        {
            this.dsGiaoVien.Add(gv);
        }
        public override string ToString()
        {
            string s = "Danh sách giáo viên: ";
            foreach (object ob in this.dsGiaoVien)
            {
                s += ob as GiaoVien + ";";
            }    
            return s;
        }
    }
}
