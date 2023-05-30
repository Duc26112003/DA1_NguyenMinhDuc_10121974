using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHoaDonBan
    {
        public string MaHoaDonBan { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int ThanhTien { get; set; }

        public DTO_ChiTietHoaDonBan () { }
        public  DTO_ChiTietHoaDonBan(string maHDB, string maHang, int soLuong, int donGia, int thanhTien)
        {
            MaHoaDonBan = maHDB;
            MaHang = maHang;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }
    }
}
