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
    public class DAO_KhachHang:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        // hien thi danh sach nhan vien ra ngoai man hinh 

        public DataTable getKhachHang()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from KhachHang", _con);
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
        public int kiemtramatrung(string maKH)
        {
            _con.Open();
            int i;
            string sql = "Select count(*)  from KhachHang where MaKhachHang ='" + maKH.Trim() + "' ";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;

        }
        public bool themkh(DTO_KhachHang kh)
        {
           
            string sql = "Insert into KhachHang values ( '" + kh.MaKH + "','" + kh.TenKH + "','" + kh.GioiTinh + "','" + kh.DiaChi + "','" + kh.SoDienThoai+ "')";
            thucthisql(sql);
            return true;
        }
        public bool suakh (DTO_KhachHang kh)
        {
            string sql = "Update KhachHang set MaKhachHang='" + kh.MaKH + "',TenKhachHang='" + kh.TenKH + "',Gioitinh = '" + kh.GioiTinh + "',Diachi='" + kh.DiaChi + "',SoDienThoai='" + kh.SoDienThoai + "'where MaKhachHang = '" + kh.MaKH + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoakh(string MaKH)
        {
            string sql = "Delete from KhachHang where MaKhachHang = '" +MaKH+ "'";
            thucthisql(sql);
            return true;
        }
        public DataTable TimKiemKH(string MaKH)
        {
            _con.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from KhachHang where  MaKhachHang LIKE N'%" + MaKH + "%'", _con);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            _con.Close();
            return dttk;
        }
    }
}
