using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class DTO_HDN
    {
        public string  MaHoaDonNhap { get; set; }
        public string MaNhanVien { get; set; }
        public string NhaCungCapID { get; set; }
        public DateTime NgayNhap { get; set; }    
        public int TrietKhauNhap { get; set; }

        public DTO_HDN() { }

       public DTO_HDN(string  maHoaDonNhap, string maNhanVien, string nhaCungCapID, DateTime ngayNhap, int trietKhauNhap)
        {
            MaHoaDonNhap = maHoaDonNhap;
            MaNhanVien = maNhanVien;
            NhaCungCapID = nhaCungCapID;
            NgayNhap = ngayNhap;
            TrietKhauNhap = trietKhauNhap;
        }
    }
    

}
