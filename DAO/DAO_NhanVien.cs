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
    // Create by Nguyen Minh Duc - 20/4/2023: lưu trữ vào và truy xuất dữ liệu từ Bảng TaiKhoan trong CSDL

    public class DAO_NhanVien: DBConnect
    {
        /// <summary>
        /// khai báo các đối tượng 
        /// </summary>
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        // hien thi danh sach nhan vien ra ngoai man hinh 
        /// <summary>
        /// lấy danh sách các tài khoản 
        /// </summary>
        /// <returns></returns>
        public DataTable getNhanVien()
        {   
           _con.Open();
            da = new SqlDataAdapter("Select * from NhanVien",_con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        /// <summary>
        /// Hàm thực thi 
        /// </summary>
        /// <param name="sql">Co sở dữ liệu </param>
        void thucthisql(string sql )
        {
            
            _con.Open();// Mở liên kết 
            cmd = new SqlCommand(sql, _con);// Tạo một đối tượng SqlCommand mới với truy vấn và kết nối SQL được cung cấp
            cmd.ExecuteNonQuery();
            _con.Close(); // Đóng liên kết 
        }
        /// <summary>
        /// Hàm kiểm tra mã trùng 
        /// </summary>
        /// <param name="maNV">Nhân Viên </param>
        /// <returns></returns>
        public int kiemtramatrung(string maNV)
        {
            _con.Open();
            int i;
            string sql = "Select count(*)  from NhanVien where MaNhanVien ='" + maNV.Trim() + "' "; // Tạo truy vấn SQL để đếm số lượng bản ghi với giá trị MaNhanVien được cung cấp
            cmd = new SqlCommand(sql, _con);
            i = (int)cmd.ExecuteScalar(); // Thực thi truy vấn SQL và lấy kết quả vô hướng (count)
            _con.Close();
            return i;

        }/// <summary>
        /// Hàm thêm nhân viên 
        /// </summary>
        /// <param name="nv">Nhân Viên</param>
        /// <returns></returns>
        public bool themNV(DTO_NhanVien nv)
        {
            // Định dạng ngày dưới dạng chuỗi theo định dạng: năm/tháng/ngày
            string ngay = string.Format("{0}/{1}/{2}", nv.NgaySinh.Year, nv.NgaySinh.Month ,nv.NgaySinh.Day);
            // Tạo truy vấn SQL để chèn một bản ghi mới vào bảng NhanVien với các giá trị được cung cấp
            string sql = "Insert into NhanVien values ( '" + nv.MaNhanVien + "','" + nv.TenNhanVien + "','"+nv.GioiTinh+"','"+nv.DiaChi+ "','"+nv.SoDienThoai+ "','"+nv.Email+ "','"+ngay+"')";
            thucthisql(sql);
            return true;

        }
        /// <summary>
        /// Hàm sửa thông tin nhân viên 
        /// </summary>
        /// <param name="nv">Nhân viên </param>
        /// <returns></returns>
        public bool suaNV(DTO_NhanVien nv )
        {
            // Định dạng ngày dưới dạng chuỗi theo định dạng: năm/tháng/ngày
            string ngay = string.Format("{0}/{1}/{2}", nv.NgaySinh.Year, nv.NgaySinh.Month, nv.NgaySinh.Day);
            // Tạo truy vấn SQL để cập nhật bảng NhanVien với các giá trị được cung cấp
            string sql = "Update NhanVien set MaNhanVien='"+nv.MaNhanVien+ "',TenNhanVien='"+nv.TenNhanVien+ "',Gioitinh = '"+nv.GioiTinh+ "',Diachi='"+nv.DiaChi+ "',SoDienThoai='"+nv.SoDienThoai+ "',Email='"+nv.Email+"' where MaNhanVien = '" +nv.MaNhanVien+ "'";
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Hàm xóa thông tin nhân viên 
        /// </summary>
        /// <param name="MaNhanVien">Thông tin nhân viên </param>
        /// <returns></returns>
        public bool xoaNV(string MaNhanVien)
        {// Tạo truy vấn SQL để xóa bảng NhanVien với các giá trị được cung cấp
            string sql = "Delete from Nhanvien where MaNhanVien= '" +MaNhanVien+ "'";
            thucthisql(sql);
            return true;

        }
        /// <summary>
        /// Hàm tìm kiếm theo tên nhân viên 
        /// </summary>
        /// <param name="tenNV">Tên Nhân Viên </param>
        /// <returns></returns>
        public DataTable TimKiemNV(string tenNV)
        {
            _con.Open();
            SqlDataAdapter datk = new SqlDataAdapter("Select * from NhanVien where  TenNhanVien LIKE N'%" + tenNV + "%'", _con); // Tạo một đối tượng SqlDataAdapter mới với truy vấn và kết nối SQL
            DataTable dttk = new DataTable();
            datk.Fill(dttk);
            _con.Close();
            return dttk;
        }



    }
}
