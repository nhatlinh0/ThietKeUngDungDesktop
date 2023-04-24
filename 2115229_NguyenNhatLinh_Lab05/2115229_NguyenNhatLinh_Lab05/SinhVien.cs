using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115229_NguyenNhatLinh_Lab05
{
    class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTenLot { get; set; }
        public DateTime NgaySinh { get; set; }
       public string SoCMND { get; set; }
        public string Ten { get; set; }
        public bool Phai { get; set; }
        public string Lop { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public List<string> MonHoc { get; set; }

        public SinhVien()
        {
            MonHoc = new List<string>();
        }
        
        public SinhVien(string MSSV, bool GioiTinh, string HoTenLot, string Ten, DateTime NgaySinh, string Lop,
            string SoCMND, string SDT, string DiaChi, List<string>MonHoc)
        {
            this.MSSV = MSSV;
            this.Phai = GioiTinh;
            this.HoTenLot = HoTenLot;
            this.Ten = Ten;
            this.NgaySinh = NgaySinh;
            this.Lop = Lop;
            this.SoCMND = SoCMND;
            this.SDT = SDT;
            this.DiaChi = DiaChi;
            this.MonHoc = MonHoc;
        }
    }
}
