﻿using System;
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
using System.Text.RegularExpressions;


namespace GUI
{
    public partial class GUI_HDB : Form
    {
        BUS_HDB bushdb = new BUS_HDB();
        public GUI_HDB()
        {
            InitializeComponent();
        }

        private void GUI_HDB_Load(object sender, EventArgs e)
        {
            dgvDHB.DataSource = bushdb.GetHoaDonBan();
        }

        private void dgvDHB_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int hang = e.RowIndex;
            txtmaHDB.Text = dgvDHB[0, hang].Value.ToString();
            txtMaNV.Text = dgvDHB[1, hang].Value.ToString();
            dtpNB.Text = dgvDHB[2, hang].Value.ToString();
            txtKH.Text = dgvDHB[3, hang].Value.ToString();
            txtTKN.Text = dgvDHB[4, hang].Value.ToString();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHoaDonBan = txtmaHDB.Text;
            string maNV = txtMaNV.Text;
            DateTime ngayBan = DateTime.Parse(dtpNB.Value.ToShortDateString());
            string maKH = txtKH.Text;
            int trietKhauNhap = int.Parse(txtTKN.Text);


            DTO_HDB hdb = new DTO_HDB(maHoaDonBan, maNV, ngayBan, maKH, trietKhauNhap);

            if (bushdb.kiemtramnatrung(maHoaDonBan) == 1)
            {
                MessageBox.Show("Mã trùng ");
            }
            else
            {
                if (bushdb.themHDB(hdb) == true)
                {
                    MessageBox.Show("Thêm thành công !");
                    dgvDHB.DataSource = bushdb.GetHoaDonBan();
                }
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtmaHDB.ReadOnly = true;

            string maHoaDonBan = txtmaHDB.Text;
            string maNV = txtMaNV.Text;
            string maKH = txtKH.Text;
            DateTime ngayBan = DateTime.Parse(dtpNB.Value.ToShortDateString());
            int trietKhauNhap = int.Parse(txtTKN.Text);



            DTO_HDB hdb = new DTO_HDB(maHoaDonBan, maNV, ngayBan, maKH, trietKhauNhap);

            {
                if (bushdb.suaHDB(hdb) == true)
                {
                    MessageBox.Show("Sửa thành công!");
                    dgvDHB.DataSource = bushdb.GetHoaDonBan();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaHoaDonBan = txtmaHDB.Text;

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                if (bushdb.xoaHDB(MaHoaDonBan) == true)
                {
                    MessageBox.Show("Xoa thanh cong !");
                    dgvDHB.DataSource = bushdb.GetHoaDonBan();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.txtmaHDB.Clear();
            this.txtMaNV.Clear();
            this.txtKH.Clear();
            this.txtTKN.Clear();
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
            dgvDHB.DataSource = bushdb.TimKiemHDB(txtTimKiem.Text);
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExportFile(bushdb.GetHoaDonBan(), "danh sach hoa don", "Danh sách hóa đơn bán");
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

            cl2.Value2 = "Mã Hàng";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Số Lương ";
            cl3.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Đơn Giá";

            cl4.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Thành Tiền ";

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