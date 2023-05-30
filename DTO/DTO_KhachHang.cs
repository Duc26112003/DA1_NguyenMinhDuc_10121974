using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class DTO_KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set;}
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public DTO_KhachHang() { }

        public DTO_KhachHang (string maKH, string tenKH, string gioiTinh, string diaChi, string soDienThoai)
        {
            MaKH = maKH;
            TenKH = tenKH;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }
    }
}
