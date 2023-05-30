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
    public  class DAO_HDB:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DataTable getHoaDonBan()
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM HoaDonBan", _con);
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

        public int kiemtramatrung(string Mahdb)
        {
            _con.Open();
            int i;
            string sql = "SELECT COUNT(*) FROM HoaDonBan WHERE MaHoaDonBan='" + Mahdb.Trim() + "'";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;
        }


        public bool themHDB(DTO_HDB hdb)
        {
            string ngay = string.Format("{0}/{1}/{2}", hdb.NgayBan.Year, hdb.NgayBan.Month, hdb.NgayBan.Day);
            string sql = "INSERT INTO HoaDonBan VALUES ('" + hdb.MaHoaDonBan + "','" + hdb.MaNhanVien + "','" + ngay + "','"+hdb.MaKhachHang+ "','" + hdb.TrietKhauNhap + "')";
            thucthisql(sql);
            return true;
        }


        public bool suaHDB(DTO_HDB hdb)
        {
            string ngay = string.Format("{0}/{1}/{2}", hdb.NgayBan.Year, hdb.NgayBan.Month, hdb.NgayBan.Day);
            string sql = "Update HoaDonBan set MaHoaDonBan ='" + hdb.MaHoaDonBan + "',MaNhanVien='" + hdb.MaNhanVien + "',NgayBan='" + ngay + "',TrietKhauNhap='" + hdb.TrietKhauNhap + "' where MaHoaDonBan = '" + hdb.MaHoaDonBan + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaHDB(string  MaHoaDonBan)
        {
            string sql = "Delete from HoaDonBan where MaHoaDonBan = '" + MaHoaDonBan + "'";
            thucthisql(sql);
            return true;
        }
        public DataTable TimKiemHDB(string MaHoaDonBan)
        {
            _con.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from HoaDonBan  where  MaHoaDonBan LIKE N'%" + MaHoaDonBan + "%'", _con); // Tạo một đối tượng SqlDataAdapter mới với truy vấn và kết nối SQL
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            _con.Close();
            return dttk;
        }
    }
}
