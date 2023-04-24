using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab4
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }

        public string Phai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Hinh { get; set; }
        
        public SinhVien()
        {

        }

        public SinhVien(string mssv, string hoten, string phai, DateTime ngaysinh, string lop, string sdt, string email, string diachi, string hinh )
        {
            this.MSSV = mssv;
            this.HoTen = hoten;
            this.Phai = phai;
            this.NgaySinh = ngaysinh;
            this.Lop = lop;
            this.SDT = sdt;
            this.Email = email;
            this.DiaChi = diachi;
            this.Hinh = hinh;
        }
    }
}
