using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietDonHangNhap
    {
        public string MaHoaDonNhap { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int ThanhTien { get; set; }

        public DTO_ChiTietDonHangNhap() { }

        public DTO_ChiTietDonHangNhap(string maHDN, string maHang, int SL,int DG, int TT)
        {
            MaHoaDonNhap = maHDN;
            MaHang = maHang;
            SoLuong = SL;
            DonGia = DG;
            ThanhTien = TT;
        }
    }  
}
