using DAO;
using GUI;
using System.Data.SqlClient;
using NUnit.Framework;
using System;
using DTO;
using System.Runtime.InteropServices;
using BUS;
using System.Data;

namespace TestProject1
{// Ngày sửa 20/5/2023 _ Nguyễn Minh Đức : xây dựng các hàm test chức năng
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        //hàm kiểm thử datatable xem co lay duoc du lieu tu bang sql 
        [Test]
        public void TestGetNhanVien()
        {
            // Khởi tạo đối tượng sut
            DAO_NhanVien sut = new DAO_NhanVien();
            // Khai báo biến rusult và gán hàm cần kiểm thử
            var result = sut.getNhanVien();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }

        [Test]
        public void TestGetKhachHang()
        {
            // Khởi tạo đối tượng sut
            DAO_KhachHang sut = new DAO_KhachHang();
            // Khai báo biến rusult và gán hàm cần kiểm thử
            var result = sut.getKhachHang();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }
        [Test]
        public void TestGetNhaCungCap()
        {
            // Khởi tạo đối tượng sut
            DAO_NhaCC sut = new DAO_NhaCC();
            // Khai báo biến rusult và gán hàm cần kiểm thử
            var result = sut.getNhaCungCap();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }
        [Test]
        public void TestGetTTLH()
        {
            // Khởi tạo đối tượng sut
            DAO_ThongTinLoaiHang sut = new DAO_ThongTinLoaiHang();
            // Khai báo biến rusult và gán hàm cần kiểm thử
            var result = sut.getLoaiHang();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }
        [Test]
        public void TestGetHDN()
        {
            // Khởi tạo đối tượng sut
            DAO_HDN sut = new DAO_HDN();
            // Khai báo biến rusult và gán hàm cần kiểm thử
            var result = sut.getHoaDonNhap();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }
        [Test]
        public void TestGetHDB()
        {
            // Khởi tạo đối tượng sut
            DAO_HDB sut = new DAO_HDB();
            // Khai báo biến rusult và gán hàm cần kiểm thử
            var result = sut.getHoaDonBan();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }
        [Test]
        public void TestGetCTHDB()
        {
            // Khởi tạo đối tượng sut
            DAO_ChiTietHoaDonBan sut = new DAO_ChiTietHoaDonBan();
            // Khai báo biến rusult và gán hàm cần kiểm thử
            var result = sut.getChiTietHoaDonBan();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }
        [Test]
        public void TestGetCTHDN()
        {
            // Khởi tạo đối tượng sut
            DAO_ChiTietHoaDonNhap sut = new DAO_ChiTietHoaDonNhap();
            // Khai báo biến rusult và gán hàm cần kiểm thử
            var result = sut.getChiTietHoaDonNhap();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }

        
       

        [Test]
        public void KiemTraMaNhanVien()
        {
            // Arrange
            BUS_NhanVien sut = new BUS_NhanVien();
            // Act
            var result = sut.getNhanVien();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }
        [Test]
        public void KiemTraMaKhachHang()
        {
            // Arrange
            BUS_KhachHang sut = new BUS_KhachHang();
            // Act
            var result = sut.getKhachHang();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }
        [Test]
        public void KiemTraMaNhaCC()
        {
            // Arrange
            BUS_NhaCC sut = new BUS_NhaCC();
            // Act
            var result = sut.getNhaCungCap();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }
        [Test]
        public void KiemTraMaHDB()
        {
            // Arrange
            BUS_HDB sut = new BUS_HDB();
            // Act
            var result = sut.GetHoaDonBan();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }
        [Test]
        public void KiemTraMaHDN()
        {
            // Arrange
            BUS_HDN sut = new BUS_HDN();
            // Act
            var result = sut.GetHoaDonNhap();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }
        [Test]
        public void KiemTraCTHHDB()
        {
            // Arrange
            BUS_ChiTietHoaDonBan sut = new BUS_ChiTietHoaDonBan();
            // Act
            var result = sut.getChiTietHoaDonBan();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }
        [Test]
        public void KiemTraCTHHDN()
        {
            // Arrange
            BUS_ChiTietHoaDonNhap sut = new BUS_ChiTietHoaDonNhap();
            // Act
            var result = sut.getChiTietDonHangNhap();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }

        [Test]
        public void BUS_ThongTinLoaiHang()
        {
            // Arrange
            BUS_ThongTinLoaiHang sut = new BUS_ThongTinLoaiHang();
            // Act
            var result = sut.getLoaiHang();
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }

        [Test]
        public void KiemTraMaNhanVien_NonExistingMaNhanVien_Returns0()
        {
            // Arrange
            
            string maNV = "11111";
            int expected = 0;

            // Act
            DAO_NhanVien dao = new DAO_NhanVien();
            
            int actual = dao.kiemtramatrung(maNV);

            // Assert
            Assert.AreEqual(expected, actual);
           
        }

        //Kiểm tra đăng nhập
    
            [Test]
            public void CheckLogin_ValidCredentials_ReturnsOne()
            {
                // Arrange
                string acc = "duc123";
                string pw = "123";
                string per = "ADMIN";
                DAO_CheckLogin dao = new DAO_CheckLogin();

                // Act
                int result = dao.CheckLogin(acc, pw, per);

                // Assert
                Assert.AreEqual(1, result);
            }

            [Test]
            public void CheckLogin_InvalidCredentials_ReturnsZero()
            {
                // Arrange
                string acc = "duc123";
                string pw = "1234";
                string per = "ADMIN";
                DAO_CheckLogin dao = new DAO_CheckLogin();

                // Act
                int result = dao.CheckLogin(acc, pw, per);

                // Assert
                Assert.AreEqual(0, result);
            }
       
        [Test]
        public void TinhThanhTien_CorrectCalculation_ReturnsTrue0()
        {
            // Khi nhập đơn giá là 1 số âm thì nó sẽ báo lỗi 
            // Khi nhập đơn giá là 1 số dương thì sẽ không báo lỗi 
            decimal donGia = 10;
            int soLuong = 5;
            decimal expected = 50;

            // Act
            decimal actual = TinhTongTien(donGia, soLuong);

            // Assert
            Assert.AreEqual(expected, actual);
        }
       
        // Thay thế điều này bằng chức năng tính toán thực tế của bạn
        private decimal TinhTongTien(decimal donGia, int soLuong)
        {
            // Thực hiện logic tính toán của bạn ở đây
            if (donGia < 0)
            {
                throw new ArgumentException("Đơn giá không thể là số âm.");
            }

            decimal tongTien = donGia * soLuong;
            return tongTien;
        }

        //Kiểm tra mã nhân viên 
        [Test]
        public void KiemTraMaNhanVien_ExistingMaNhanVien_Returns1()
        {
            // Arrange

            string maNV = "NV001";
            int expected = 1;

            // Act
            DAO_NhanVien dao = new DAO_NhanVien();
            int actual = dao.kiemtramatrung(maNV);

            // Assert
            Assert.AreEqual(expected, actual);

        }
        // them nhan vien 
        [Test]
        public void themNV_ValidNhanVien_ReturnsTrue()
            {
                // Arrange
                DTO_NhanVien nv = new DTO_NhanVien
                {
                    MaNhanVien = "NV012",
                    TenNhanVien = "Nguyen Van A",
                    GioiTinh = "Nam",
                    DiaChi = "123 ABC Street",
                    SoDienThoai = "0123456789",
                    Email = "nv@example.com",
                    NgaySinh = new DateTime(1990-02-16)
                };

                DAO_NhanVien dao = new DAO_NhanVien();

                // Act
                bool result = dao.themNV(nv);

                // Assert
                Assert.IsTrue(result);
            }
        // sua nhan vien 
        [Test]
        public void suaNV_ValidNhanVien_ReturnsTrue()
        {
            // Arrange
            DTO_NhanVien nv = new DTO_NhanVien
            {
                MaNhanVien = "NV012",
                TenNhanVien = "Nguyen Van An",
                GioiTinh = "Nam",
                DiaChi = "Nguyen Hue",
                SoDienThoai = "0123456789",
                Email = "nv@example.com",
                NgaySinh = new DateTime(1990-02-20)
            };

            DAO_NhanVien dao = new DAO_NhanVien();

            // Act
            bool result = dao.suaNV(nv);

            // Assert
            Assert.IsTrue(result);
        }
        // xoa nhan vien 
        [Test]
        public void xoaNV_ValidMaNhanVien_ReturnsTrue()
            {
                // Arrange
                string maNhanVien = "NV012";
                DAO_NhanVien dao = new DAO_NhanVien();

                // Act
                bool result = dao.xoaNV(maNhanVien);

                // Assert
                Assert.IsTrue(result);
            }
        // tim kiem nhan vien 
        [Test]
        public void TimKiemNV_ExistingName_ReturnsMatchingRecords()
        {
            // Arrange
            string tenNV = "Duc"; // Tên nhân viên tồn tại trong cơ sở dữ liệu
            DAO_NhanVien dao = new DAO_NhanVien();

            // Act
            DataTable result = dao.TimKiemNV(tenNV);

            // Assert
            Assert.NotNull(result); // Kiểm tra kết quả trả về khác null
            Assert.Greater(result.Rows.Count, 0); // Kiểm tra số lượng bản ghi trả về lớn hơn 0
        }
        // tim kiem nhan vien 
        [Test]
        public void TimKiemNV_NonExistingName_ReturnsEmptyTable()
        {
            // Arrange
            string tenNV = "Nguyen Van Truong "; // Tên nhân viên không tồn tại trong cơ sở dữ liệu
            DAO_NhanVien dao = new DAO_NhanVien();

            // Act
            DataTable result = dao.TimKiemNV(tenNV);

            // Assert
            Assert.NotNull(result); // Kiểm tra kết quả trả về khác null
            Assert.AreEqual(0, result.Rows.Count); // Kiểm tra số lượng bản ghi trả về bằng 0
        }

        // Them khach hang 
        [TestFixture]
        public class DAO_KhachHangTests
        {
            private DAO_KhachHang dao;

            [SetUp]
            public void Setup()
            {
                dao = new DAO_KhachHang();
            }

            [Test]
            public void KiemTraMaTrung_ExistingMaKH_ReturnsCountGreaterThanZero()
            {
                // Arrange
                string maKH = "KH001"; // Mã khách hàng tồn tại trong cơ sở dữ liệu

                // Act
                int result = dao.kiemtramatrung(maKH);

                // Assert
                Assert.Greater(result, 0); // Kiểm tra kết quả trả về lớn hơn 0
            }

            [Test]
            public void KiemTraMaTrung_NonExistingMaKH_ReturnsCountEqualsZero()
            {
                // Arrange
                string maKH = "NonExistingMaKH"; // Mã khách hàng không tồn tại trong cơ sở dữ liệu

                // Act
                int result = dao.kiemtramatrung(maKH);

                // Assert
                Assert.AreEqual(0, result); // Kiểm tra kết quả trả về bằng 0
            }

            [Test]
            public void ThemKH_ValidData_ReturnsTrue()
            {
                // Arrange
                DTO_KhachHang khachHang = new DTO_KhachHang
                {
                    MaKH = "KH012",
                    TenKH = "John Doe",
                    GioiTinh = "Nam",
                    DiaChi = "123 ABC Street",
                    SoDienThoai = "123456789"
                };

                // Act
                bool result = dao.themkh(khachHang);

                // Assert
                Assert.IsTrue(result); // Kiểm tra kết quả trả về là true
            }

            [Test]
            public void SuaKH_ValidData_ReturnsTrue()
            {
                // Arrange
                DTO_KhachHang khachHang = new DTO_KhachHang
                {
                    MaKH = "KH012",
                    TenKH = "John Doe",
                    GioiTinh = "Nam",
                    DiaChi = "123 XYZ Street",
                    SoDienThoai = "987654321"
                };

                // Act
                bool result = dao.suakh(khachHang);

                // Assert
                Assert.IsTrue(result); // Kiểm tra kết quả trả về là true
            }

            [Test]
            public void XoaKH_ExistingMaKH_ReturnsTrue()
            {
                // Arrange
                string maKH = "KH012"; // Mã khách hàng tồn tại trong cơ sở dữ liệu

                // Act
                bool result = dao.xoakh(maKH);

                // Assert
                Assert.IsTrue(result); // Kiểm tra kết quả trả về là true
            }

            [Test]
            public void TimKiemNV_ExistingMaKH_ReturnsMatchingRecords()
            {
                // Arrange
                string maKH = "KH001"; // Mã khách hàng tồn tại trong cơ sở dữ liệu

                // Act
                DataTable result = dao.TimKiemKH(maKH);

                // Assert
                Assert.NotNull(result); // Kiểm tra kết quả trả về khác null
                Assert.Greater(result.Rows.Count, 0); // Kiểm tra số lượng bản ghi trả về lớn hơn 0
            }

            [Test]
            public void TimKiemNV_NonExistingMaKH_ReturnsEmptyTable()
            {
                // Arrange
                string maKH = "KH014"; // Mã khách hàng không tồn tại trong cơ sở dữ liệu

                // Act
                DataTable result = dao.TimKiemKH(maKH);

                // Assert
                Assert.NotNull(result); // Kiểm tra kết quả trả về khác null
                Assert.AreEqual(0, result.Rows.Count); // Kiểm tra số lượng bản ghi trả về bằng 0
            }
        }


        [TestFixture]
        public class DAO_NhaCungCapTests
        {
            private DAO_NhaCC dao;

            [SetUp]
            public void Setup()
            {
                dao = new DAO_NhaCC();
            }

            [Test]
            public void KiemTraMaTrung_ExistingMaNhaCC_ReturnsCountGreaterThanZero()
            {
                // Arrange
                string maNhaCC = "10"; // Mã nhà cung cấp tồn tại trong cơ sở dữ liệu

                // Act
                int result = dao.kiemtramatrung(maNhaCC);

                // Assert
                Assert.Greater(result, 0); // Kiểm tra kết quả trả về lớn hơn 0
            }

            [Test]
            public void KiemTraMaTrung_NonExistingMaNhaCC_ReturnsCountEqualsZero()
            {
                // Arrange
                string maNhaCC = "12"; // Mã nhà cung cấp không tồn tại trong cơ sở dữ liệu

                // Act
                int result = dao.kiemtramatrung(maNhaCC);

                // Assert
                Assert.AreEqual(0, result); // Kiểm tra kết quả trả về bằng 0
            }

            [Test]
            public void ThemNCC_ValidData_ReturnsTrue()
            {
                // Arrange
                DTO_NhaCC nhaCC = new DTO_NhaCC
                {
                    NhaCungCapID = "12",
                    TenNhaCungCap = "ABC Supplier",
                    DiaChi = "456 XYZ Street",
                    SoDienThoai = "987654321"
                };

                // Act
                bool result = dao.themncc(nhaCC);

                // Assert
                Assert.IsTrue(result); // Kiểm tra kết quả trả về là true
            }

            [Test]
            public void SuaNCC_ValidData_ReturnsTrue()
            {
                // Arrange
                DTO_NhaCC nhaCC = new DTO_NhaCC
                {
                    NhaCungCapID = "12",
                    TenNhaCungCap = "DEF Supplier",
                    DiaChi = "789 ABC Street",
                    SoDienThoai = "123456789"
                };

                // Act
                bool result = dao.suancc(nhaCC);

                // Assert
                Assert.IsTrue(result); // Kiểm tra kết quả trả về là true
            }

            [Test]
            public void XoaNCC_ExistingMaNhaCC_ReturnsTrue()
            {
                // Arrange
                string maNhaCC = "12"; // Mã nhà cung cấp tồn tại trong cơ sở dữ liệu

                // Act
                bool result = dao.xoancc(maNhaCC);

                // Assert
                Assert.IsTrue(result); // Kiểm tra kết quả trả về là true
            }

            [Test]
            public void TimKiemNV_ExistingTenNCC_ReturnsMatchingRecords()
            {
                // Arrange
                string tenNCC = "Samsung"; // Tên nhà cung cấp tồn tại trong cơ sở dữ liệu

                // Act
                DataTable result = dao.TimKiemNCC(tenNCC);

                // Assert
                Assert.NotNull(result); // Kiểm tra kết quả trả về khác null
                Assert.Greater(result.Rows.Count, 0); // Kiểm tra số lượng bản ghi trả về lớn hơn 0
            }

            [Test]
            public void TimKiemNV_NonExistingTenNCC_ReturnsEmptyTable()
            {
                // Arrange
                string tenNCC = "Banh Keo"; // Tên nhà cung cấp không tồn tại trong cơ sở dữ liệu

                // Act
                DataTable result = dao.TimKiemNCC(tenNCC);

                // Assert
                Assert.NotNull(result); // Kiểm tra kết quả trả về khác null
                Assert.AreEqual(0, result.Rows.Count); // Kiểm tra số lượng bản ghi trả về bằng 0
            }
        }
        [TestFixture]
        public class DAO_LoaiHangTests
        {
            private DAO_ThongTinLoaiHang dao;

            [SetUp]
            public void Setup()
            {
                dao = new DAO_ThongTinLoaiHang();
            }

            [Test]
            public void KiemTraMaTrung_ExistingMaLH_ReturnsCountGreaterThanZero()
            {
                // Arrange
                string maLH = "LH001"; // Mã loại hàng tồn tại trong cơ sở dữ liệu

                // Act
                int result = dao.kiemtramatrung(maLH);

                // Assert
                Assert.Greater(result, 0); // Kiểm tra kết quả trả về lớn hơn 0
            }

            [Test]
            public void KiemTraMaTrung_NonExistingMaLH_ReturnsCountEqualsZero()
            {
                // Arrange
                string maLH = "NonExistingMaLH"; // Mã loại hàng không tồn tại trong cơ sở dữ liệu

                // Act
                int result = dao.kiemtramatrung(maLH);

                // Assert
                Assert.AreEqual(0, result); // Kiểm tra kết quả trả về bằng 0
            }

            [Test]
            public void ThemLH_ValidData_ReturnsTrue()
            {
                // Arrange
                DTO_ThongTinLoaiHang ttmt = new DTO_ThongTinLoaiHang
                {
                    MaLoaiHang = "LH010",
                    TenLoaiHang = "Laptop",
                    Mota = "Loại hàng máy tính Laptop"
                };

                // Act
                bool result = dao.themLH(ttmt);

                // Assert
                Assert.IsTrue(result); // Kiểm tra kết quả trả về là true
            }

            [Test]
            public void SuaLH_ValidData_ReturnsTrue()
            {
                // Arrange
                DTO_ThongTinLoaiHang ttmt = new DTO_ThongTinLoaiHang
                {
                    MaLoaiHang = "LH010",
                    TenLoaiHang = "Desktop",
                    Mota = "Loại hàng máy tính Desktop"
                };

                // Act
                bool result = dao.suaLH(ttmt);

                // Assert
                Assert.IsTrue(result); // Kiểm tra kết quả trả về là true
            }

            [Test]
            public void XoaLH_ExistingMaLH_ReturnsTrue()
            {
                // Arrange
                string maLH = "LH010"; // Mã loại hàng tồn tại trong cơ sở dữ liệu

                // Act
                bool result = dao.xoaLH(maLH);

                // Assert
                Assert.IsTrue(result); // Kiểm tra kết quả trả về là true
            }
        }

        [TestFixture]
        public class DAO_HangHoaTests
        {
            private DAO_HangHoa dao;

            [SetUp]
            public void Setup()
            {
                dao = new DAO_HangHoa();
            }

            [Test]
            public void KiemTraMaTrung_ExistingMaHang_ReturnsCountGreaterThanZero()
            {
                // Arrange
                string maHang = "HH001"; // Mã hàng tồn tại trong cơ sở dữ liệu

                // Act
                int result = dao.kiemtramatrung(maHang);

                // Assert
                Assert.Greater(result, 0); // Kiểm tra kết quả trả về lớn hơn 0
            }

            [Test]
            public void KiemTraMaTrung_NonExistingMaHang_ReturnsCountEqualsZero()
            {
                // Arrange
                string maHang = "NonExistingMaHang"; // Mã hàng không tồn tại trong cơ sở dữ liệu

                // Act
                int result = dao.kiemtramatrung(maHang);

                // Assert
                Assert.AreEqual(0, result); // Kiểm tra kết quả trả về bằng 0
            }

            [Test]
            public void ThemHH_ValidData_ReturnsTrue()
            {
                // Arrange
                DTO_HangHoa hh = new DTO_HangHoa
                {
                    MaHang = "HH002",
                    TenHang = "Laptop",
                    MaLoaiHang = "LH002",
                    SoLuong = 10,
                    DonGiaNhap = 1000,
                    DonGiaBan = 1500,
                    Anh = "laptop.jpg"
                };

                // Act
                bool result = dao.themhh(hh);

                // Assert
                Assert.IsTrue(result); // Kiểm tra kết quả trả về là true
            }

            [Test]
            public void SuaHH_ValidData_ReturnsTrue()
            {
                // Arrange
                DTO_HangHoa hh = new DTO_HangHoa
                {
                    MaHang = "HH002",
                    TenHang = "Desktop",
                    MaLoaiHang = "LH002",
                    SoLuong = 15,
                    DonGiaNhap = 1200,
                    DonGiaBan = 1800,
                    Anh = "desktop.jpg"
                };

                // Act
                bool result = dao.suahh(hh);

                // Assert
                Assert.IsTrue(result); // Kiểm tra kết quả trả về là true
            }

            [Test]
            public void XoaHH_ExistingMaHang_ReturnsTrue()
            {
                // Arrange
                string maHang = "HH002"; // Mã hàng tồn tại trong cơ sở dữ liệu

                // Act
                bool result = dao.xoahh(maHang);

                // Assert
                Assert.IsTrue(result); // Kiểm tra kết quả trả về là true
            }

            
           

            [Test]
            public void TimKiemHH_NonExistingTenHH_ReturnsEmptyDataTable()
            {
                // Arrange
                string tenHH = "Banh Keo "; // Tên hàng hóa không tồn tại trong cơ sở dữ liệu

                // Act
                DataTable result = dao.TimKiemhh(tenHH);

                // Assert
                Assert.IsNotNull(result); // Kiểm tra kết quả trả về không null
                Assert.AreEqual(0, result.Rows.Count); // Kiểm tra không có bản ghi phù hợp được trả về
            }
        }
        [TestFixture]
        public class DAOHoaDonBan
        {
            private DAO_HDB dao;

            [SetUp]
            public void Setup()
            {
                dao = new DAO_HDB();
                // Khởi tạo các đối tượng cần thiết cho việc test
            }

            [Test]
            public void KiemTraMaTrung_ExistingMaHDB_ReturnsCountGreaterThanZero()
            {
                string maHDB = "1";
                int result = dao.kiemtramatrung(maHDB);
                Assert.Greater(result, 0);
                // Kiểm tra rằng hàm kiemtramatrung trả về một số lượng bản ghi lớn hơn 0
            }

            [Test]
            public void ThemHDB_ValidHDB_ReturnsTrue()
            {
                DTO_HDB hdb = new DTO_HDB()
                {
                    MaHoaDonBan = "10",
                    MaNhanVien = "NV011",
                    NgayBan = DateTime.Now,
                    MaKhachHang = "KH010",
                    TrietKhauNhap = 1000
                };
                bool result = dao.themHDB(hdb);
                Assert.IsTrue(result);
                // Kiểm tra rằng hàm themHDB trả về true khi thêm một HDB hợp lệ
            }

            [Test]
            public void SuaHDB_ValidHDB_ReturnsTrue()
            {
                DTO_HDB hdb = new DTO_HDB()
                {
                    MaHoaDonBan = "10",
                    MaNhanVien = "NV011",
                    NgayBan = DateTime.Now,
                    MaKhachHang = "KH010",
                    TrietKhauNhap = 1200
                };
                bool result = dao.suaHDB(hdb);
                Assert.IsTrue(result);
                // Kiểm tra rằng hàm suaHDB trả về true khi sửa một HDB hợp lệ
            }

            [Test]
            public void XoaHDB_ValidMaHDB_ReturnsTrue()
            {
                string maHDB = "10";
                bool result = dao.xoaHDB(maHDB);
                Assert.IsTrue(result);
                // Kiểm tra rằng hàm xoaHDB trả về true khi xóa một HDB với mã hợp lệ
            }

            [Test]
            public void TimKiemHDB_ExistingMaHDB_ReturnsDataTableWithMatchingRecords()
            {
                string maHDB = "1";
                DataTable result = dao.TimKiemHDB(maHDB);
                Assert.IsNotNull(result);
                Assert.Greater(result.Rows.Count, 0);
                // Kiểm tra rằng hàm TimKiemHDB trả về một DataTable không null và có ít nhất một bản ghi phù hợp
            }
        }
        [TestFixture]
        public class DAOHoaDonNhap
        {
            private  DAO_HDN dao;

            [SetUp]
            public void Setup()
            {
                dao = new DAO_HDN();
                // Khởi tạo các đối tượng cần thiết cho việc test
            }

            [Test]
            public void KiemTraMaTrung_ExistingMaHDN_ReturnsCountGreaterThanZero()
            {
                string maHDN = "1";
                int result = dao.kiemtramatrung(maHDN);
                Assert.Greater(result, 0);
                // Kiểm tra rằng hàm kiemtramatrung trả về một số lượng bản ghi lớn hơn 0
            }

            [Test]
            public void ThemHDN_ValidHDN_ReturnsTrue()
            {
                DTO_HDN hdn = new DTO_HDN()
                {
                    MaHoaDonNhap = "10",
                    MaNhanVien = "NV010",
                    NhaCungCapID = "10",
                    NgayNhap = DateTime.Now,
                    TrietKhauNhap = 1000
                };
                bool result = dao.themHDN(hdn);
                Assert.IsTrue(result);
                // Kiểm tra rằng hàm themHDN trả về true khi thêm một HDN hợp lệ
            }

            [Test]
            public void SuaHDN_ValidHDN_ReturnsTrue()
            {
                DTO_HDN hdn = new DTO_HDN()
                {
                    MaHoaDonNhap = "9",
                    MaNhanVien = "NV009",
                    NhaCungCapID = "9",
                    NgayNhap = DateTime.Now,
                    TrietKhauNhap = 1200
                };
                bool result = dao.suaHDN(hdn);
                Assert.IsTrue(result);
                // Kiểm tra rằng hàm suaHDN trả về true khi sửa một HDN hợp lệ
            }

            [Test]
            public void XoaHDN_ValidMaHDN_ReturnsTrue()
            {
                string maHDN = "10";
                bool result = dao.xoaHDN(maHDN);
                Assert.IsTrue(result);
                // Kiểm tra rằng hàm xoaHDN trả về true khi xóa một HDN với mã hợp lệ
            }

            [Test]
            public void TimKiemMaHDN_ExistingMaHDN_ReturnsDataTableWithMatchingRecords()
            {
                string maHDN = "1";
                DataTable result = dao.TimKiemMaHDN(maHDN);
                Assert.IsNotNull(result);
                Assert.Greater(result.Rows.Count, 0);
                // Kiểm tra rằng hàm TimKiemMaHDN trả về một DataTable không null và có ít nhất một bản ghi phù hợp
            }
        }

        [TestFixture]
        public class DAOCTHDN
        {
            private DAO_ChiTietHoaDonNhap dao;

            [SetUp]
            public void Setup()
            {
                dao = new DAO_ChiTietHoaDonNhap();
                // Khởi tạo các đối tượng cần thiết cho việc test
            }

            [Test]
            public void KiemTraMaTrung_ExistingMaHDN_ReturnsCountGreaterThanZero()
            {
                string maHDN = "3";
                int result = dao.kiemtramatrung(maHDN);
                Assert.Greater(result, 0);
                // Kiểm tra rằng hàm kiemtramatrung trả về một số lượng bản ghi lớn hơn 0
            }

            [Test]
            public void ThemCTHDN_ValidCTHDN_ReturnsTrue()
            {
                DTO_ChiTietDonHangNhap cthdn = new DTO_ChiTietDonHangNhap()
                {
                    MaHoaDonNhap = "5",
                    MaHang = "HH005",
                    SoLuong = 10,
                    DonGia = 100,
                    ThanhTien = 1000
                };
                bool result = dao.themCTHDN(cthdn);
                Assert.IsTrue(result);
                // Kiểm tra rằng hàm themCTHDN trả về true khi thêm một CTHDN hợp lệ
            }

            [Test]
            public void SuaCTHDN_ValidCTHDN_ReturnsTrue()
            {
                DTO_ChiTietDonHangNhap cthdn = new DTO_ChiTietDonHangNhap()
                {
                    MaHoaDonNhap = "5",
                    MaHang = "MH005",
                    SoLuong = 20,
                    DonGia = 200,
                    ThanhTien = 4000
                };
                bool result = dao.suaCTHDN(cthdn);
                Assert.IsTrue(result);
                // Kiểm tra rằng hàm suaCTHDN trả về true khi sửa một CTHDN hợp lệ
            }

            [Test]
            public void XoaCTHDN_ValidMaHoaDonNhap_ReturnsTrue()
            {
                string maHoaDonNhap = "5";
                bool result = dao.xoaCTHDN(maHoaDonNhap);
                Assert.IsTrue(result);
                // Kiểm tra rằng hàm xoaCTHDN trả về true khi xóa một CTHDN với mã hợp lệ
            }

            [Test]
            public void TimKiemCTHDN_ExistingMaHoaDonNhap_ReturnsDataTableWithMatchingRecords()
            {
                string maHoaDonNhap = "3";
                DataTable result = dao.TimKiemCTHDN(maHoaDonNhap);
                Assert.IsNotNull(result);
                Assert.Greater(result.Rows.Count, 0);
                // Kiểm tra rằng hàm TimKiemCTHDN trả về một DataTable không null và có ít nhất một bản ghi phù hợp
            }
        }

        [TestFixture]
        public class DAOCTHDB
        {
            private DAO_ChiTietHoaDonBan dao;

            [SetUp]
            public void Setup()
            {
                dao = new DAO_ChiTietHoaDonBan();
                // Khởi tạo các đối tượng cần thiết cho việc test
            }

            [Test]
            public void KiemTraMaTrung_ExistingMaHDB_ReturnsCountGreaterThanZero()
            {
                string maHDB = "3";
                int result = dao.kiemtramatrung(maHDB);
                Assert.Greater(result, 0);
                // Kiểm tra rằng hàm kiemtramatrung trả về một số lượng bản ghi lớn hơn 0
            }

           

            [Test]
            public void SuaCTHDB_ValidCTHDB_ReturnsTrue()
            {
                DTO_ChiTietHoaDonBan cthdb = new DTO_ChiTietHoaDonBan()
                {
                    MaHoaDonBan = "3",
                    MaHang = "HH003",
                    SoLuong = 20,
                    DonGia = 200,
                    ThanhTien = 4000
                };
                bool result = dao.suaCTHDB(cthdb);
                Assert.IsTrue(result);
                // Kiểm tra rằng hàm suaCTHDB trả về true khi sửa một CTHDB hợp lệ
            }

            [Test]
            public void XoaCTHDB_ValidMaHoaDonBan_ReturnsTrue()
            {
                string maHoaDonBan = "5";
                bool result = dao.xoaCTHDB(maHoaDonBan);
                Assert.IsTrue(result);
                // Kiểm tra rằng hàm xoaCTHDB trả về true khi xóa một CTHDB với mã hợp lệ
            }

            [Test]
            public void TimKiemCTHDB_ExistingMaHoaDonBan_ReturnsDataTableWithMatchingRecords()
            {
                string maHoaDonBan = "3";
                DataTable result = dao.TimKiemCTHDB(maHoaDonBan);
                Assert.IsNotNull(result);
                Assert.Greater(result.Rows.Count, 0);
                // Kiểm tra rằng hàm TimKiemCTHDB trả về một DataTable không null và có ít nhất một bản ghi phù hợp
            }
        }
    }

        
}
