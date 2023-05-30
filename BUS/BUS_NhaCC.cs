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
    public  class BUS_NhaCC
    {
        DAO_NhaCC daoncc = new DAO_NhaCC();
        public DataTable getNhaCungCap()
        {
            return daoncc.getNhaCungCap();
        }
        public int kiemtramatrung(string MaNhaCC)
        {
            return daoncc.kiemtramatrung(MaNhaCC);
        }
        public bool themkh(DTO_NhaCC ncc)
        {
            return daoncc.themncc(ncc);

        }
        public bool suakh(DTO_NhaCC ncc)
        {
            return daoncc.suancc(ncc);
        }
        public bool xoakh(string Mancc)
        {
            return daoncc.xoancc(Mancc);
        }
        public DataTable TimKiemNCC(string tenNCC)
        {
            return daoncc.TimKiemNCC(tenNCC);
        }
    }
}
