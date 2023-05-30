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
namespace GUI
{
    public partial class GUI_ThongTinMayTinh : Form
    {
        BUS_ThongTinLoaiHang busttmt = new BUS_ThongTinLoaiHang();
        public GUI_ThongTinMayTinh()
        {
            InitializeComponent();
        }

        private void GUI_ThongTinMayTinh_Load(object sender, EventArgs e)
        {
            dgvTTMT.DataSource = busttmt.getLoaiHang();
        }

        private void dgvTTMT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int hang = e.RowIndex;
            txtMaMT.Text = dgvTTMT[0,hang].Value.ToString();
            txtTenMT.Text = dgvTTMT[1, hang].Value.ToString();
            txtMota.Text = dgvTTMT[2, hang].Value.ToString();
            


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLH = txtMaMT.Text;
            string tenLH = txtTenMT.Text;
            string Mota = txtMota.Text;


            DTO_ThongTinLoaiHang LH = new DTO_ThongTinLoaiHang(maLH, tenLH, Mota);
            if (busttmt.kiemtramatrung(maLH) == 1)
            {
                MessageBox.Show("Mã trùng ");
            }
            else
            {
                if (busttmt.themLH(LH) == true)
                {
                    MessageBox.Show("Thêm thành công !");
                    dgvTTMT.DataSource = busttmt.getLoaiHang();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaMT.ReadOnly = true;
            string maLH = txtMaMT.Text;
            string tenLH = txtTenMT.Text;
            string Mota = txtMota.Text;


            DTO_ThongTinLoaiHang LH = new DTO_ThongTinLoaiHang(maLH, tenLH,Mota);

            {
                if (busttmt.themLH(LH) == true)
                {
                    MessageBox.Show("Sửa thành công!");
                    dgvTTMT.DataSource = busttmt.getLoaiHang();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaLH = txtMaMT.Text;

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                if (busttmt.xoaLH(MaLH) == true)
                {
                    MessageBox.Show("Xoa thanh cong !");
                    dgvTTMT.DataSource = busttmt.getLoaiHang();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.txtMaMT.Clear();
            this.txtTenMT.Clear();
            this.txtMota.Clear();
            
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

        private void btnXuat_Click(object sender, EventArgs e)
        {
            ExportFile(busttmt.getLoaiHang(), "danh sách thông tin loại hàng ", "Danh sách thông tin loại hàng  ");
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

            cl1.Value2 = "Mã Loại Hàng ";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tên Lọai Hàng ";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Mô Tả ";

            cl3.ColumnWidth = 30.5;

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
