using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_CheckLogin : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        // Lấy danh sách các loại tài khoản từ cơ sở dữ liệu
        public DataTable getLoaiTK()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from LoaiTaiKhoan", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

        // Thực thi câu lệnh SQL không trả về kết quả
        void thucthisql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }

        // Kiểm tra thông tin đăng nhập
        public int CheckLogin(string acc, string pw, string per)
        {
            _con.Open();
            int i;
            string sql = "EXEC CheckLogin '" + acc + "','" + pw + "','" + per + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }
    }
}