using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Data.SqlClient;


namespace BUS
{
    public class BUS_KhachHang
    {
        DAO_KhachHang daokh = new DAO_KhachHang();
        public DataTable getKhachHang()
        {
            return daokh.getKhachHang();
        }
        public int kiemtramatrung(string makh)
        {
            return daokh.kiemtramatrung(makh);
        }
        public bool themkh(DTO_KhachHang kh)
        {
            return daokh.themkh(kh);

        }
        public bool suakh(DTO_KhachHang kh)
        {
            return daokh.suakh(kh);
        }
        public bool xoakh(string MaKH)
        {
            return daokh.xoakh(MaKH);
        }
        public DataTable TimKiemKH(string tenKH)
        {
            return daokh.TimKiemKH(tenKH);
        }
    }
}
