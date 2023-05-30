using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        public string MaNhanVien { get; set; }

        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public DateTime NgaySinh { get; set; }

        public DTO_NhanVien() 
        { 
                    
        }
        public DTO_NhanVien(string maNV, string tenNV, string gioiTinh, string diaChi, string soDienThoai, string email, DateTime ngaySinh)
        {
            MaNhanVien = maNV;
            TenNhanVien = tenNV;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
            NgaySinh = ngaySinh;
        }
    }
}
