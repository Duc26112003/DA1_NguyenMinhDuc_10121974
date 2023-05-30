using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public  class BUS_HDB
    {
        DAO_HDB daoHDB = new DAO_HDB();

        public DataTable GetHoaDonBan()
        {
            return daoHDB.getHoaDonBan();
        }

        public int kiemtramnatrung(string maHDB)
        {
            return daoHDB.kiemtramatrung(maHDB);
        }

        public bool themHDB(DTO_HDB hdb)
        {
            return daoHDB.themHDB(hdb);
        }

        public bool suaHDB(DTO_HDB hdb)
        {
            return daoHDB.suaHDB(hdb);
        }

        public bool xoaHDB(string maHDB)
        {

            return daoHDB.xoaHDB(maHDB);
        }
        public DataTable TimKiemHDB(string MaHoaDonBan)
        {
            return daoHDB.TimKiemHDB(MaHoaDonBan);
        }
    }
}

