using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Globalization;

namespace _2115229_NguyenNhatLinh_Lab05
{
    class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;
        public List<SinhVien> DanhSach1;
        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
            DanhSach1 = new List<SinhVien>();
        }

        public SinhVien this[int index]
        {
            get { return this.DanhSach[index]; }
            set { this.DanhSach[index] = value;  }
        }

        public void ThemSV(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }

        public List<SinhVien> TimTheoMSSV(string MSSV)
        {
            List<SinhVien> dssv = new List<SinhVien>();
            foreach (SinhVien s in DanhSach)
            {
                if (s.MSSV.CompareTo(MSSV) == 0)
                {
                    dssv.Add(s);
                }
            }
            return dssv;
        }

        public List<SinhVien> TimTheoLop(string Lop)
        {
            List <SinhVien> dssv= new List<SinhVien>();
            foreach (SinhVien s in DanhSach)
            {
                if(s.Lop.CompareTo(Lop)==0)
                {
                    dssv.Add(s);
                }
            }
            return dssv;

        }

        public List<SinhVien> TimTheoTen(string Ten)
        {
            List<SinhVien> dssv = new List<SinhVien>();
            foreach (SinhVien s in DanhSach)
            {
                if (s.Ten.CompareTo(Ten) == 0)
                {
                    dssv.Add(s);
                }
            }
            return dssv;
        }
        
        public void Xoa(string MSSV)
        {
            for(int i=0; i < DanhSach.Count ;i++)
            {
                if(DanhSach[i].MSSV.CompareTo(MSSV)==0)
                {
                    this.DanhSach.RemoveAt(i);
                }
            }
        }
        public void DocFile()
        {
            StreamReader sr = new StreamReader("DanhSachSV.txt");
            string t;
            string[] s;
            SinhVien sv;
            while((t = sr.ReadLine()) != null )
            {
                s= t.Split(',');
                sv = new SinhVien();
                sv.MSSV = s[0];
                sv.Phai = false;
                if (s[1].CompareTo("Nam") == 0)
                    sv.Phai = true;
                sv.HoTenLot = s[2];
                sv.Ten = s[3];
                sv.NgaySinh = DateTime.Parse(s[4]);
                sv.Lop = s[5];
                sv.SoCMND = s[6];
                sv.SDT = s[7];
                sv.DiaChi = s[8];
                string[] monhoc = s[9].Split('*');
                foreach(string mh in monhoc)
                {
                    sv.MonHoc.Add(mh);
                }
                this.ThemSV(sv);
            }
        }
    }
}
