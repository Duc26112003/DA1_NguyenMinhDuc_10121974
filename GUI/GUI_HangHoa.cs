using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_HangHoa : Form
    {
        BUS_HangHoa bushh = new BUS_HangHoa();
        public GUI_HangHoa()
        {
            InitializeComponent();
        }

     

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaHang = txtMaHang.Text;
            string TenHang = txtTenHang.Text;
            string MaLoaiHang = txtMaLoaiHang.Text;
            int SoLuong = int.Parse(txtSoLuong.Text);
            int DonGiaNhap = int.Parse(txtDGN.Text);
            int DonGiaBan = int.Parse(txtDGB.Text);
            string Anh   = txtAnh.Text;

            DTO_HangHoa hh = new DTO_HangHoa(MaHang, TenHang, MaLoaiHang, SoLuong, DonGiaNhap, DonGiaBan,Anh);
            if (bushh.kiemtramatrung(MaHang) == 1)
            {
                MessageBox.Show("Mã trùng ");
            }
            else
            {
                if (bushh.themhh(hh) == true)
                {
                    MessageBox.Show("Thêm thành công !");
                    dgvHH.DataSource = bushh.getHangHoa();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaHang.ReadOnly = true;
            string MaHang = txtMaHang.Text;
            string TenHang = txtTenHang.Text;
            string MaLoaiHang = txtMaLoaiHang.Text;
            int SoLuong = int.Parse(txtSoLuong.Text);
            int DonGiaNhap = int.Parse(txtDGN.Text);
            int DonGiaBan = int.Parse(txtDGB.Text);
            string Anh = txtAnh.Text;

            DTO_HangHoa hh = new DTO_HangHoa(MaHang, TenHang, MaLoaiHang, SoLuong, DonGiaNhap, DonGiaBan, Anh);
            {

                if (bushh.suahh(hh) == true)
                {
                    MessageBox.Show("Sửa thành công!");
                    dgvHH.DataSource = bushh.getHangHoa();
                }

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaHang = txtMaHang.Text;

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                if (bushh.xoahh(MaHang) == true)
                {
                    MessageBox.Show("Xoa thanh cong !");
                    dgvHH.DataSource = bushh.getHangHoa();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.txtMaHang.Clear();
            this.txtTenHang.Clear();
            this.txtMaLoaiHang.Clear();
            this.txtSoLuong.Clear();
            this.txtDGN.Clear();
            this.txtDGB.Clear();
            this.txtAnh.Clear();
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
            MessageBox.Show("Tim Kiem thanh cong ");
            dgvHH.DataSource = bushh.TimKiemhh(txtTimKiem.Text);
        }

        private void GUI_HangHoa_Load(object sender, EventArgs e)
        {
            dgvHH.DataSource = bushh.getHangHoa();
        }

        private void btnChonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 20;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
               
            }
        }

        private void dgvHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;

            // Lấy giá trị của ô chứa đường dẫn ảnh
            string duongDanAnh = dgvHH[6, hang].Value.ToString();

            // Kiểm tra nếu đường dẫn ảnh không rỗng
            if (!string.IsNullOrEmpty(duongDanAnh))
            {
                // Hiển thị ảnh trong PictureBox
                picAnh.ImageLocation = duongDanAnh;
            }
            else
            {
                // Nếu đường dẫn ảnh rỗng, xóa ảnh trong PictureBox
                picAnh.Image = null;
            }

            txtMaHang.Text = dgvHH[0, hang].Value.ToString();
            txtTenHang.Text = dgvHH[1, hang].Value.ToString();
            txtMaLoaiHang.Text = dgvHH[2, hang].Value.ToString();
            txtSoLuong.Text = dgvHH[3, hang].Value.ToString();
            txtDGN.Text = dgvHH[4, hang].Value.ToString();
            txtDGB.Text = dgvHH[5, hang].Value.ToString();
            txtAnh.Text = dgvHH[6, hang].Value.ToString();
        }

       
    }
}