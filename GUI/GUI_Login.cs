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

namespace GUI
{
    public partial class GUI_Login : Form
    {
        // Tạo một đối tượng của lớp BUS_CheckLogin
        BUS_CheckLogin busclg = new BUS_CheckLogin();

        public GUI_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy tên tài khoản, mật khẩu và cấp quyền được nhập vào
            string acc = txtUserName.Text;
            string pw = txtPassword.Text;
            int per = cbbLoaiTK.SelectedIndex;

            // Kiểm tra thông tin đăng nhập
            bool loginResult = (busclg.CheckLogin(acc, pw, cbbLoaiTK.Text) == 1);

            if (loginResult)
            {
                if (per == 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    GUI_frmMenu frm = new GUI_frmMenu();
                    frm.Show();
                }
                else if (per == 1)
                {
                    this.Hide();
                    GUI_QLNhanVien frm = new GUI_QLNhanVien();
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại thông tin đăng nhập.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận để thoát chương trình
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn Yes, đóng chương trình
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GUI_Login_Load(object sender, EventArgs e)
        {
            // Tải các cấp quyền vào ComboBox
            cbbLoaiTK.DataSource = busclg.getLoaiTK();
            cbbLoaiTK.DisplayMember = "LoaiTK";
        }
    }
}