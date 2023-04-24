using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _2115229_NguyenNhatLinh_Lab4
{
    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;
        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }

        public SinhVien this[int index]
        {
            get { return this.DanhSach[index]; }
            set { this.DanhSach[index] = value; }
        }

        public void DocFile()
        {
            string filename = "DanhSachSV.txt";
            string[] s;
            string t;
            SinhVien sv;
            StreamReader sr = new StreamReader(filename);
            while ((t = sr.ReadLine()) != null )
            {
                s = t.Split(',');
                sv = new SinhVien();
                sv.MSSV = s[0];
                sv.HoTen = s[1];
                sv.Phai = s[2];
                sv.NgaySinh = DateTime.Parse(s[3]);
                sv.Lop = s[4];
                sv.SDT = s[5];
                sv.Email = s[6];
                sv.DiaChi = s[7];
                sv.Hinh = s[8];
                this.DanhSach.Add(sv); 
            }
        }
    }
}
