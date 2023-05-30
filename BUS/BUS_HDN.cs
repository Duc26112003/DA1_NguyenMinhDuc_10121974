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
    public class BUS_HDN
    {
        DAO_HDN daoHDN = new DAO_HDN();

        public DataTable GetHoaDonNhap()
        {
            return daoHDN.getHoaDonNhap();
        }

        public int kiemtramnatrung(string maHDN)
        {
            return daoHDN.kiemtramatrung(maHDN);
        }

        public bool themHDN(DTO_HDN hdn)
        {
            return daoHDN.themHDN(hdn);
        }

        public bool suaHDN(DTO_HDN hdn)
        {
            return daoHDN.suaHDN(hdn);
        }

        public bool XoaHDN(string  maHDN)
        {
          
            return daoHDN.xoaHDN(maHDN);
        }
        public DataTable TimKiemMaHDN(string maHoaDonNhap)
        {
            return daoHDN.TimKiemMaHDN(maHoaDonNhap);
        }
    }
}
