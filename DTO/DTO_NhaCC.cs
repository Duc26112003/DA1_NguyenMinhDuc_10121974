using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaCC
    {
        public string NhaCungCapID{ get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public DTO_NhaCC() { }
         public DTO_NhaCC(string maNhaCC, string tenNhaCC, string diaChi, string soDienThoai)
        {
            NhaCungCapID = maNhaCC;
            TenNhaCungCap = tenNhaCC;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }
    }
}
