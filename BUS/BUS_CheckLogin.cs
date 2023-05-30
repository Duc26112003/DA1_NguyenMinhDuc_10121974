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
    public class BUS_CheckLogin
    {
        DAO_CheckLogin daoclg = new DAO_CheckLogin();

        // Lấy danh sách các loại tài khoản từ DAO_CheckLogin
        public DataTable getLoaiTK()
        {
            return daoclg.getLoaiTK();
        }

        // Gọi phương thức CheckLogin từ DAO_CheckLogin để kiểm tra thông tin đăng nhập
        public int CheckLogin(string acc, string pw, string per)
        {
            return daoclg.CheckLogin(acc, pw, per);
        }
    }
}