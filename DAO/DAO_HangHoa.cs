using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public  class DAO_HangHoa:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        // hien thi danh sach hoa don  ngoai man hinh 
        public DataTable getHangHoa()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from HangHoa ", _con);
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
        public int kiemtramatrung(string MaHang)
        {
            _con.Open();
            int i;
            string sql = "Select count(*)  from HangHoa where MaHang ='" + MaHang.Trim() + "' ";
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();
            _con.Close();
            return i;

        }
        public bool themhh(DTO_HangHoa hh)
        {
            
            string sql = "Insert into HangHoa values ( '" + hh.MaHang + "','" + hh.TenHang + "','" + hh.MaLoaiHang + "','" + hh.SoLuong + "','" + hh.DonGiaNhap + "','" + hh.DonGiaBan + "','" + hh.Anh + "')";
            thucthisql(sql);
            return true;

        }
        public bool suahh(DTO_HangHoa hh)
        {
            
            string sql = "Update HangHoa set MaHang ='" + hh.MaHang + "',TenHang='" + hh.TenHang + "',MaLoaiHang = '" + hh.MaLoaiHang + "',SoLuong='" + hh.SoLuong + "', DonGiaNhap  ='" + hh.DonGiaNhap + "',DonGiaBan  ='" + hh.DonGiaBan + "',Anh = '" + hh.Anh + "' where MaHang = '" + hh.MaHang + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoahh(string MaHang)
        {
            string sql = "Delete from HangHoa where MaHang = '" + MaHang + "'";
            thucthisql(sql);
            return true;

        }
        public DataTable TimKiemhh(string tenhh)
        {
            _con.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from HangHoa where  MaHang LIKE N'%" + tenhh + "%'", _con);
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            _con.Close();
            return dttk;
        }
    }
}
