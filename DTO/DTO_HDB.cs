using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class DTO_HDB
    {
        public string MaHoaDonBan { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayBan { get; set; }
        public string MaKhachHang { get; set; }
        public int TrietKhauNhap { get; set; }

        public DTO_HDB() { }

       public DTO_HDB(string maHoaDonBan, string maNhanVien, DateTime ngayBan, string maKhachHang, int trietKhauNhap)
        {
            MaHoaDonBan = maHoaDonBan;
            MaNhanVien = maNhanVien;
            NgayBan = ngayBan;
            MaKhachHang = maKhachHang;
            TrietKhauNhap = trietKhauNhap;
        }
    }
}
