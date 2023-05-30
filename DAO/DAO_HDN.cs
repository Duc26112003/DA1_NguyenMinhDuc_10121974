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
    public  class DAO_HDN:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DataTable getHoaDonNhap()
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM HoaDonNhap", _con);
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

        public int kiemtramatrung(string MaHDN)
        {
            _con.Open();
            int i;
            string sql = "SELECT COUNT(*) FROM HoaDonNhap WHERE MaHoaDonNhap='" + MaHDN.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }


        public bool themHDN(DTO_HDN hdn)
        {
            string ngay = string.Format("{0}/{1}/{2}", hdn.NgayNhap.Year, hdn.NgayNhap.Month, hdn.NgayNhap.Day);
            string sql = "INSERT INTO HoaDonNhap VALUES ('" + hdn.MaHoaDonNhap + "','" + hdn.MaNhanVien + "','" + hdn.NhaCungCapID + "','" + ngay + "','" + hdn.TrietKhauNhap + "')";
            thucthisql(sql);
            return true;
        }


        public bool suaHDN(DTO_HDN hdn)
        {
            string ngay = string.Format("{0}/{1}/{2}", hdn.NgayNhap.Year, hdn.NgayNhap.Month, hdn.NgayNhap.Day);
            string sql = "Update HoaDonNhap set MaHoaDonNhap='" + hdn.MaHoaDonNhap + "',MaNhanVien='" + hdn.MaNhanVien + "',NhaCungCapID = '" + hdn.NhaCungCapID + "',NgayNhap='" + ngay + "', TrietKhauNhap='" + hdn.TrietKhauNhap + "' where MaHoaDonNhap = '" + hdn.MaHoaDonNhap + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaHDN(string  maHoaDonNhap)
        {
            string sql = "Delete from HoaDonNhap where MaHoaDonNhap= '" + maHoaDonNhap+ "'";
            thucthisql(sql);
            return true;
        }
        public DataTable TimKiemMaHDN(string maHoaDonNhap)
        {
            _con.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from HoaDonNhap where  MaHoaDonNhap LIKE N'%" + maHoaDonNhap + "%'", _con);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            _con.Close();
            return dttk;
        }


    }
}
