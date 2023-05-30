using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{ // Create by Nguyen Minh Duc - 20/4/2023: lưu trữ vào và truy xuất dữ liệu từ Bảng TaiKhoan trong CSDL
    public  class DAO_ThongTinLoaiHang :DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        
        
        // hien thi danh sach nhan vien ra ngoai man hinh 
        public DataTable getLoaiHang()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from LoaiHang", _con);
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
        public int kiemtramatrung(string maLH)
        {
            _con.Open();
            int i;
            string sql = "Select count(*)  from LoaiHang where MaLoaiHang ='" + maLH.Trim() + "' ";// Tạo truy vấn SQL để đếm số lượng bản ghi với giá trị MaNhanVien được cung cấp
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar();// Thực thi truy vấn SQL và lấy kết quả vô hướng (count)
            _con.Close();
            return i;

        }
        public bool themLH(DTO_ThongTinLoaiHang ttmt)
        {

            string sql = "Insert into LoaiHang values ('"+ttmt.MaLoaiHang+ "','" +ttmt.TenLoaiHang + "','" + ttmt.Mota + "')";
            thucthisql(sql);
            return true;

        }
        public bool suaLH(DTO_ThongTinLoaiHang ttmt)
        {
            string sql = "Update LoaiHang set MaLoaiHang='" + ttmt.MaLoaiHang + "',TenLoaiHang='" + ttmt.TenLoaiHang + "',Mota='" + ttmt.Mota + "' where MaLoaiHang = '" + ttmt.MaLoaiHang + "'";
            thucthisql(sql);
            return true;
        }
        public bool xoaLH(string MaLoaiHang)
        {
            string sql = "Delete from LoaiHang where MaLoaiHang= '" + MaLoaiHang + "'";
            thucthisql(sql);
            return true;

        }

    }
}
