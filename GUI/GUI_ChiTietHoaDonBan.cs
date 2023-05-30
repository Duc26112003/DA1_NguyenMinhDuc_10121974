using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Data.SqlClient;
using System.IO;
using app = Microsoft.Office.Interop.Excel.Application;


namespace GUI
{   
    public partial class GUI_ChiTietHoaDonBan : Form
    {
        BUS_ChiTietHoaDonBan bushdb = new BUS_ChiTietHoaDonBan();
        public GUI_ChiTietHoaDonBan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maDHB = txtMaHDB.Text;
            string MaHang = txtMaHang.Text;
            int SoLuong = int.Parse(txtSoLuong.Text);
            int DonGia = int.Parse(txtDonGia.Text);
            int ThanhTien = int.Parse(txtThanhTien.Text);

            DTO_ChiTietHoaDonBan cthdb = new DTO_ChiTietHoaDonBan(maDHB,MaHang, SoLuong, DonGia, ThanhTien);

            if (bushdb.kiemtramatrung(maDHB) == 1)
            {
                MessageBox.Show("Mã trùng ");
            }
            else
            {
                if (bushdb.themCTHDB(cthdb) == true)
                {
                    MessageBox.Show("Thêm thành công !");
                    dgvHDB.DataSource = bushdb.getChiTietHoaDonBan();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaHDB.ReadOnly = true;
            string maHDB = txtMaHDB.Text;
            string MaHang = txtMaHang.Text;
            int SoLuong = int.Parse(txtSoLuong.Text);
            int DonGia = int.Parse(txtDonGia.Text);
            int ThanhTien = int.Parse(txtThanhTien.Text);

            DTO_ChiTietHoaDonBan ctdhb = new DTO_ChiTietHoaDonBan(maHDB, MaHang, SoLuong, DonGia, ThanhTien);

            {
                if (bushdb.suaCTHDB(ctdhb) == true)
                {
                    MessageBox.Show("Sửa thành công!");
                    dgvHDB.DataSource = bushdb.getChiTietHoaDonBan();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaHoaDonBan = txtMaHDB.Text;

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                if (bushdb.xoaCTHDB(MaHoaDonBan) == true)
                {
                    MessageBox.Show("Xoa thanh cong !");
                    dgvHDB.DataSource = bushdb.getChiTietHoaDonBan();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.txtMaHDB.Clear();
            this.txtMaHang.Clear();
            this.txtSoLuong.Clear();
            this.txtDonGia.Clear();
            this.txtThanhTien.Clear();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            GUI_frmMenu menu = new GUI_frmMenu();
            menu.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm kiếm thành công");
            dgvHDB.DataSource = bushdb.TimKiemCTHDB(txtTimKiem.Text);
        }

        private void GUI_ChiTietHoaDonBan_Load(object sender, EventArgs e)
        {
            dgvHDB.DataSource = bushdb.getChiTietHoaDonBan();
        }

        private void dgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaHDB.Text = dgvHDB[0, hang].Value.ToString();
            txtMaHang.Text = dgvHDB[1, hang].Value.ToString();
            txtSoLuong.Text = dgvHDB[2, hang].Value.ToString();
            txtDonGia.Text = dgvHDB[3, hang].Value.ToString();
            txtThanhTien.Text = dgvHDB[4, hang].Value.ToString();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
        }
        
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExportFile(bushdb.getChiTietHoaDonBan(), "danh sach hoa don", "Danh sách chi tiết hóa đơn bán ");
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

            cl1.Value2 = "Mã Hóa Đơn Bán  ";

            cl1.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Mã Nhân Viên ";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Ngày Bán ";
            cl3.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Mã Khách Hàng";

            cl4.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Triết Khấu Nhập  ";

            cl5.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

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

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
    }
}
