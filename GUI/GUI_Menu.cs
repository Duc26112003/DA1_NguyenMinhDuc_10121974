using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_frmMenu : Form
    {
        public GUI_frmMenu()
        {
            InitializeComponent();
        }

       

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLNhanVien frm = new GUI_QLNhanVien();
            frm.Show();
            this.Hide();
        }

        private void thôngTinNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhaCC frm = new GUI_NhaCC();
            frm.Show();
            this.Hide();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_QLKhachHang frm = new GUI_QLKhachHang();
            frm.Show();
            this.Hide();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void GUI_frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void chiTiếtHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void chiTiếtHóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thôngTinMáyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ThongTinMayTinh frm = new GUI_ThongTinMayTinh();
            frm.Show();
            this.Hide();
        }



        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_HDB frm = new GUI_HDB();
            frm.Show();
            this.Hide();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            GUI_HDN frm = new GUI_HDN();
            frm.Show();
            this.Hide();
        }

        private void chiTiếtHóaĐơnBánToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            GUI_ChiTietHoaDonBan frm = new GUI_ChiTietHoaDonBan();
            frm.Show();
            this.Hide();
        }

        private void chiTiếtHóaĐơnNhậpToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            GUI_ChiTietHoaDonNhap frm = new GUI_ChiTietHoaDonNhap();
            frm.Show();
            this.Hide();
        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_HangHoa frm = new GUI_HangHoa();
            frm.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        this.Close();
        }
    }
}
