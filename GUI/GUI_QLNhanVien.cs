using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace GUI
{ 
    public partial class GUI_QLNhanVien : Form
    {
        BUS_NhanVien busnv = new BUS_NhanVien();
        public GUI_QLNhanVien()
        {
            InitializeComponent();
        }

        private void GUI_QLNhanVien_Load(object sender, EventArgs e)
        {
            dgvNV.DataSource = busnv.getNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text;
            string tenNV = txtTenNV.Text;
            string gioiTinh = txtGioiTinh.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSodienthoai.Text;
            string email = txtEmail.Text;
            DateTime ngaySinh =DateTime.Parse(dtpBir.Value.ToShortDateString());

            DTO_NhanVien nv = new DTO_NhanVien(maNV,tenNV, gioiTinh, diaChi, soDienThoai, email, ngaySinh);

            if (busnv.kiemtramatrung(maNV) == 1)
            {
                MessageBox.Show("Mã trùng ");
            }
            else
            {
                if (busnv.themNV(nv) == true)
                {
                    MessageBox.Show("Thêm thành công !");
                    dgvNV.DataSource = busnv.getNhanVien();
                }
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int hang = e.RowIndex;
            txtMaNhanVien.Text = dgvNV[0,hang].Value.ToString();
            txtTenNV.Text = dgvNV[1, hang].Value.ToString();
            txtGioiTinh.Text = dgvNV[2, hang].Value.ToString();
            txtDiaChi.Text = dgvNV[3, hang].Value.ToString();
            txtSodienthoai.Text = dgvNV[4, hang].Value.ToString();
            txtEmail.Text = dgvNV[5, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.ReadOnly = true;
            string maNV = txtMaNhanVien.Text;
            string tenNV = txtTenNV.Text;
            string gioiTinh = txtGioiTinh.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSodienthoai.Text;
            string email = txtEmail.Text;
            DateTime ngaySinh = DateTime.Parse(dtpBir.Value.ToShortDateString());

            DTO_NhanVien nv = new DTO_NhanVien(maNV, tenNV, gioiTinh, diaChi, soDienThoai, email, ngaySinh);
            
            {
                if (busnv.suaNV(nv) == true)
                {
                    MessageBox.Show("Sửa thành công!");
                    dgvNV.DataSource = busnv.getNhanVien();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaNhanVien = txtMaNhanVien.Text;

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                if (busnv.xoaNV(MaNhanVien) == true)
                {
                    MessageBox.Show("Xoa thanh cong !");
                    dgvNV.DataSource = busnv.getNhanVien();
                }
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.txtMaNhanVien.Clear();
            this.txtTenNV.Clear();
            this.txtGioiTinh.Clear();
            this.txtDiaChi.Clear();
            this.txtSodienthoai.Clear();
            this.txtEmail.Clear();
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            GUI_frmMenu menu= new GUI_frmMenu();
            menu.Show();
            this.Hide();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tim Kiem thanh cong ");
                dgvNV.DataSource = busnv.TimKiemNV(txtTimKiem.Text);
        }

        private void txtSodienthoai_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            ExportFile(busnv.getNhanVien(), "danh sách nhân viên ", "Danh sách nhân viên  ");
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã Nhân Viên ";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tên Nhân Viên";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Giới Tính ";
            cl3.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Địa Chỉ ";

            cl4.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Số Điện Thoại ";

            cl5.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Email ";

            cl6.ColumnWidth = 22.5;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Ngày Sinh ";

            cl7.ColumnWidth = 25.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "H3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    if (dataTable.Columns[col].DataType == typeof(DateTime))
                    {
                        DateTime dateValue = (DateTime)dataRow[col];
                        arr[row, col] = dateValue.ToShortDateString();

                    }

                    else
                    {
                        arr[row, col] = dataRow[col];
                    }
                }
            }
            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 1;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã 

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
    }
}

