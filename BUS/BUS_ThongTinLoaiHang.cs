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
{// 20/4/2023_Nguyễn Minh Đức : Thêm lớp BUS cho thông tin loại hàng 
    public class BUS_ThongTinLoaiHang
    {
        DAO_ThongTinLoaiHang daottmt = new DAO_ThongTinLoaiHang(); // khai báo đối tượng 
        public DataTable getLoaiHang()
        {
            return daottmt.getLoaiHang();
        }
        public int kiemtramatrung(string maLH)
        {
            return daottmt.kiemtramatrung(maLH);
        }
        public bool themLH(DTO_ThongTinLoaiHang ttmt)
        {
            return daottmt.themLH(ttmt);

        }
        public bool suaLH(DTO_ThongTinLoaiHang ttmt)
        {
            return daottmt.suaLH(ttmt);
        }
        public bool xoaLH(string MaLoaiHang)
        {
            return daottmt.xoaLH(MaLoaiHang);
        }
    }
}
