using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public  class BUS_HangHoa
    {
        DAO_HangHoa daohh = new DAO_HangHoa();
        public DataTable getHangHoa()
        {
            return daohh.getHangHoa();
        }
        public int kiemtramatrung(string Mahh)
        {
            return daohh.kiemtramatrung(Mahh);
        }
        public bool themhh(DTO_HangHoa MaHang)
        {
            return daohh.themhh(MaHang);

        }
        public bool suahh(DTO_HangHoa MaHang)
        {
            return daohh.suahh(MaHang);
        }
        public bool xoahh(string MaHang)
        {
            return daohh.xoahh(MaHang);
        }
        public DataTable TimKiemhh(string MaHang)
        {
            return daohh.TimKiemhh(MaHang);
        }
    }
}
