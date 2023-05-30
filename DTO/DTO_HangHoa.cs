using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DTO
{
    public  class DTO_HangHoa
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string MaLoaiHang { get;set; }
        public int SoLuong { get; set; }
        public int DonGiaNhap { get; set; }
        public int DonGiaBan { get; set; }

        public string Anh { get; set; }

        public DTO_HangHoa() { }
        public DTO_HangHoa(string maHang, string tenHang, string maLoaiHang, int soLuong, int donGiaNhap, int donGiaBan   , string anh)
        {
            MaHang = maHang;
            TenHang = tenHang;
            MaLoaiHang = maLoaiHang;
            SoLuong = soLuong;
            DonGiaNhap = donGiaNhap;
            DonGiaBan = donGiaBan;
            Anh = anh;
        }
    }
}
