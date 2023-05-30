using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DAO_ChiTietHoaDonNhap:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        // hien thi danh sach chi tiet hoa don nhap ra ngoai man hinh 
        public DataTable getChiTietHoaDonNhap()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from ChiTietHoaDonNhap", _con);
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
        public int kiemtramatrung(string maHDN)
        {
            _con.Open();
            int i;
            string sql = "Select count(*)  from ChiTietHoaDonNhap where MaHoaDonNhap ='" + maHDN.Trim() + "' ";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;

        }
        public bool themCTHDN(DTO_ChiTietDonHangNhap dhn)
        {

            string sql = "Insert into ChiTietHoaDonNhap values ('" + dhn.MaHoaDonNhap + "','" + dhn.MaHang + "','" + dhn.SoLuong + "','" + dhn.DonGia + "','" + dhn.ThanhTien + "')";
            thucthisql(sql);
            return true;

        }
        public bool suaCTHDN(DTO_ChiTietDonHangNhap dhn)
        {
            string sql = "Update ChiTietHoaDonNhap set MaHoaDonNhap ='" + dhn.MaHoaDonNhap + "',MaHang ='" + dhn.MaHang + "', SoLuong = '" + dhn.SoLuong + "',ThanhTien='" + dhn.ThanhTien + "' where MaHoaDonNhap = '" + dhn.MaHoaDonNhap + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaCTHDN(string MaHoaDonNhap)
        {
            string sql = "Delete from ChiTietHoaDonNhap where MaHoaDonNhap = '" + MaHoaDonNhap + "'";
            thucthisql(sql);
            return true;
        }
        public DataTable TimKiemCTHDN(string MaHoaDonNhap)
        {
            _con.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from ChiTietHoaDonNhap where  MaHoaDonNhap LIKE N'%" + MaHoaDonNhap + "%'", _con);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            _con.Close();
            return dttk;
        }
    }
}
