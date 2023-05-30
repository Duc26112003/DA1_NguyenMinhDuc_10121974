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
    public  class DAO_NhaCC: DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        // hien thi danh sach nhan vien ra ngoai man hinh 

        public DataTable getNhaCungCap()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from NhaCungCap", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthisql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public int kiemtramatrung(string MaNhaCC)
        {
            _con.Open();
            int i;
            string sql = "Select count(*)  from NhaCungCap where NhaCungCapID ='" +MaNhaCC.Trim() + "' ";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;

        }
        public bool themncc(DTO_NhaCC ncc)
        {

            string sql = "Insert into NhaCungCap values ( '" + ncc.NhaCungCapID + "', '" + ncc.TenNhaCungCap + "', '" + ncc.DiaChi + "','" + ncc.SoDienThoai + "')";
            thucthisql(sql);
            return true;
        }
        public bool suancc(DTO_NhaCC ncc)
        {
            string  sql = "Update NhaCungCap set NhaCungCapID ='" + ncc.NhaCungCapID + "', TenNhaCungCap = '" + ncc.TenNhaCungCap + "', Diachi='" + ncc.DiaChi + "', SoDienThoai='" + ncc.SoDienThoai + "' where NhaCungCapID = '" + ncc.NhaCungCapID + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoancc(string Mancc)
        {
            string sql = "Delete from NhaCungCap where NhaCungCapID = '" +Mancc+ "'";
            thucthisql(sql);
            return true;
        }
        public DataTable TimKiemNCC(string tenNCC)
        {
            _con.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from NhaCungCap where  TenNhaCungCap LIKE N'%" + tenNCC + "%'", _con);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            _con.Close();
            return dttk;
        }
    }
}
