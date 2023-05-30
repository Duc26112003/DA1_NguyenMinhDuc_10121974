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
    public class DAO_ChiTietHoaDonBan : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        // hien thi danh sach chi tiet hoa don ban ra ngoai man hinh 
        public DataTable getChiTietHoaDonBan()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from ChiTietHoaDonBan", _con);
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
        public int kiemtramatrung(string maHDB)
        {
            _con.Open();
            int i;
            string sql = "Select count(*)  from ChiTietHoaDonBan where MaHoaDonBan ='" + maHDB.Trim() + "' ";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;

        }
        public bool themCTHDB(DTO_ChiTietHoaDonBan dhb)
        {

            string sql = "Insert into ChiTietHoaDonBan values ('" + dhb.MaHoaDonBan + "','" + dhb.MaHang + "','" + dhb.SoLuong + "','" + dhb.DonGia + "','" + dhb.ThanhTien + "')";
            thucthisql(sql);
            return true;

        }
        public bool suaCTHDB(DTO_ChiTietHoaDonBan dhb)
        {
            string sql = "Update ChiTietHoaDonBan set MaHoaDonBan ='" + dhb.MaHoaDonBan + "',MaHang ='" + dhb.MaHang + "', SoLuong = '" + dhb.SoLuong + "',ThanhTien='" + dhb.ThanhTien + "' where MaHoaDonBan = '" + dhb.MaHoaDonBan + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaCTHDB(string MaHoaDonBan)
        {
            string sql = "Delete from ChiTietHoaDonBan where MaHoaDonBan = '" + MaHoaDonBan + "'";
            thucthisql(sql);
            return true;
        }
        public DataTable TimKiemCTHDB(string MaHoaDonBan)
        {
            _con.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from ChiTietHoaDonBan where  MaHoaDonBan LIKE N'%" + MaHoaDonBan + "%'", _con);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            _con.Close();
            return dttk;
        }

    
    }
}
