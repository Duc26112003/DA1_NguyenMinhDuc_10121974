using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;


namespace BUS
{
    public  class BUS_ChiTietHoaDonBan
    {
        DAO_ChiTietHoaDonBan daoctdhb =new DAO_ChiTietHoaDonBan();
        public DataTable getChiTietHoaDonBan()
        {
            return daoctdhb.getChiTietHoaDonBan();
        }
        public int kiemtramatrung(string maHDB)
        {
            return daoctdhb.kiemtramatrung(maHDB);
        }
        public bool themCTHDB(DTO_ChiTietHoaDonBan ctdhb)
        {
            return daoctdhb.themCTHDB(ctdhb);

        }
        public bool suaCTHDB(DTO_ChiTietHoaDonBan ctdhb)
        {
            return daoctdhb.suaCTHDB(ctdhb);
        }
        public bool xoaCTHDB(string MaHoaDonBan)
        {
            return daoctdhb.xoaCTHDB(MaHoaDonBan);
        }
        public DataTable TimKiemCTHDB(string MaHoaDonBan)
        {
            return daoctdhb.TimKiemCTHDB(MaHoaDonBan);
        }
    }
}
