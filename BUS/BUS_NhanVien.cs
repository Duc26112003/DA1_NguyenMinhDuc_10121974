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
    // 20/4/2023_Nguyễn Minh Đức : Thêm lớp BUS cho quản lí nhân viên 
    public class BUS_NhanVien
    {
        DAO_NhanVien dalnv = new DAO_NhanVien();// khai báo đối tượng 
        /// <summary>
        /// ham tra về giá trị ở tầng dao
        /// </summary>
        /// <returns></returns>
        public DataTable getNhanVien()
        {
             return dalnv.getNhanVien();
        }
        public int kiemtramatrung(string maNV)
        {
            return dalnv.kiemtramatrung(maNV);
        }
        public bool themNV(DTO_NhanVien nv)
        {
            return dalnv.themNV(nv);

        }
        public bool suaNV(DTO_NhanVien nv)
        {
            return dalnv.suaNV(nv);
        }
        public bool xoaNV(string MaNhanVien)
        {
            return dalnv.xoaNV(MaNhanVien);
        }
        public DataTable TimKiemNV(string tenNV)
        {
            return dalnv.TimKiemNV(tenNV);
        }

    }
    

}
