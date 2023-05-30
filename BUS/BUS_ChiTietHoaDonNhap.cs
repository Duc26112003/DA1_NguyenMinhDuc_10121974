using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class BUS_ChiTietHoaDonNhap
    {
        DAO_ChiTietHoaDonNhap daoctdhn = new DAO_ChiTietHoaDonNhap();

        public DataTable getChiTietDonHangNhap()
        {
            return daoctdhn.getChiTietHoaDonNhap();
        }
        public int kiemtramatrung(string maHDN)
        {
            return daoctdhn.kiemtramatrung(maHDN);
        }
        public bool themCTHDN(DTO_ChiTietDonHangNhap ctdhn)
        {
            return daoctdhn.themCTHDN(ctdhn);

        }
        public bool suaCTHDN(DTO_ChiTietDonHangNhap ctdhn)
        {
            return daoctdhn.suaCTHDN(ctdhn);
        }
        public bool xoaCTHDN(string MaHoaDonNhap)
        {
            return daoctdhn.xoaCTHDN(MaHoaDonNhap);
        }
        public DataTable TimKiemCTHDN(string MaHoaDonNhap)
        {
            return daoctdhn.TimKiemCTHDN(MaHoaDonNhap);
        }
    }
}
