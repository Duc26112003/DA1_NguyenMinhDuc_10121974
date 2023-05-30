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
    public partial class GUI_NhaCC : Form
    {
        BUS_NhaCC busncc = new BUS_NhaCC();
        public GUI_NhaCC()
        {
            InitializeComponent();
        }

        

        private void GUI_NhaCC_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = busncc.getNhaCungCap();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNhaCC.Text;
            string tenNCC = txtTenNCC.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSoDienThoai.Text;

            DTO_NhaCC ncc = new DTO_NhaCC(maNCC, tenNCC, diaChi, soDienThoai);
            if (busncc.kiemtramatrung(maNCC) == 1)
            {
                MessageBox.Show("Mã trùng ");
            }
            else
            {
                if (busncc.themkh(ncc) == true)
                {
                    MessageBox.Show("Thêm thành công !");
                    dgvNCC.DataSource = busncc.getNhaCungCap();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNhaCC.ReadOnly = true;

            string maNCC = txtMaNhaCC.Text;
            string tenNV = txtTenNCC.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSoDienThoai.Text;
            DTO_NhaCC ncc = new DTO_NhaCC(maNCC, tenNV, diaChi, soDienThoai);

            {
                if (busncc.suakh(ncc) == true)
                {
                    MessageBox.Show("Sửa thành công!");
                    dgvNCC.DataSource = busncc.getNhaCungCap();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaNhaCC = txtMaNhaCC.Text;

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                if (busncc.xoakh(MaNhaCC) == true)
                {
                    MessageBox.Show("Xoa thanh cong !");
                    dgvNCC.DataSource = busncc.getNhaCungCap();
                }
            }
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.txtMaNhaCC.Clear();
            this.txtTenNCC.Clear();
            this.txtDiaChi.Clear();
            this.txtSoDienThoai.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            

                MessageBox.Show("Tìm kiếm thành công");
                dgvNCC.DataSource = busncc.TimKiemNCC(txtTimKiem.Text);


            
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaNhaCC.Text = dgvNCC[0, hang].Value.ToString();
            txtTenNCC.Text = dgvNCC[1, hang].Value.ToString();
            txtDiaChi.Text = dgvNCC[2, hang].Value.ToString();
            txtSoDienThoai.Text = dgvNCC[3, hang].Value.ToString();
        }
    }
}
