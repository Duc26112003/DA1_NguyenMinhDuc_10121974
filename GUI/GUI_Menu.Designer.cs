namespace GUI
{
    partial class GUI_frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinMáyTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtHóaĐơnBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtHóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýThôngTinToolStripMenuItem,
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1342, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýThôngTinToolStripMenuItem
            // 
            this.quảnLýThôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinMáyTínhToolStripMenuItem,
            this.thôngTinNhânViênToolStripMenuItem,
            this.thôngTinNhàCungCấpToolStripMenuItem,
            this.thôngTinKháchHàngToolStripMenuItem});
            this.quảnLýThôngTinToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quảnLýThôngTinToolStripMenuItem.Image = global::GUI.Properties.Resources.project;
            this.quảnLýThôngTinToolStripMenuItem.Name = "quảnLýThôngTinToolStripMenuItem";
            this.quảnLýThôngTinToolStripMenuItem.Size = new System.Drawing.Size(214, 27);
            this.quảnLýThôngTinToolStripMenuItem.Text = "Quản Lý Thông Tin ";
            // 
            // thôngTinMáyTínhToolStripMenuItem
            // 
            this.thôngTinMáyTínhToolStripMenuItem.Name = "thôngTinMáyTínhToolStripMenuItem";
            this.thôngTinMáyTínhToolStripMenuItem.Size = new System.Drawing.Size(322, 28);
            this.thôngTinMáyTínhToolStripMenuItem.Text = "Thông Tin Loại Hàng ";
            this.thôngTinMáyTínhToolStripMenuItem.Click += new System.EventHandler(this.thôngTinMáyTínhToolStripMenuItem_Click);
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            this.thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            this.thôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(322, 28);
            this.thôngTinNhânViênToolStripMenuItem.Text = "Thông Tin Nhân Viên ";
            this.thôngTinNhânViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNhânViênToolStripMenuItem_Click);
            // 
            // thôngTinNhàCungCấpToolStripMenuItem
            // 
            this.thôngTinNhàCungCấpToolStripMenuItem.Name = "thôngTinNhàCungCấpToolStripMenuItem";
            this.thôngTinNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(322, 28);
            this.thôngTinNhàCungCấpToolStripMenuItem.Text = "Thông Tin Nhà Cung Cấp   ";
            this.thôngTinNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNhàCungCấpToolStripMenuItem_Click);
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(322, 28);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "Thông Tin Khách Hàng ";
            this.thôngTinKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchHàngToolStripMenuItem_Click);
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnBánToolStripMenuItem,
            this.hóaĐơnNhậpToolStripMenuItem,
            this.chiTiếtHóaĐơnBánToolStripMenuItem,
            this.chiTiếtHóaĐơnNhậpToolStripMenuItem,
            this.quảnLýHàngHóaToolStripMenuItem});
            this.quảnLýHóaĐơnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.quảnLýHóaĐơnToolStripMenuItem.Image = global::GUI.Properties.Resources.money_management;
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(203, 27);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản Lý Hóa Đơn ";
            // 
            // hóaĐơnBánToolStripMenuItem
            // 
            this.hóaĐơnBánToolStripMenuItem.Name = "hóaĐơnBánToolStripMenuItem";
            this.hóaĐơnBánToolStripMenuItem.Size = new System.Drawing.Size(297, 28);
            this.hóaĐơnBánToolStripMenuItem.Text = "Hóa Đơn Bán ";
            this.hóaĐơnBánToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnBánToolStripMenuItem_Click);
            // 
            // hóaĐơnNhậpToolStripMenuItem
            // 
            this.hóaĐơnNhậpToolStripMenuItem.Name = "hóaĐơnNhậpToolStripMenuItem";
            this.hóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(297, 28);
            this.hóaĐơnNhậpToolStripMenuItem.Text = "Hóa Đơn Nhập";
            this.hóaĐơnNhậpToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnNhậpToolStripMenuItem_Click_2);
            // 
            // chiTiếtHóaĐơnBánToolStripMenuItem
            // 
            this.chiTiếtHóaĐơnBánToolStripMenuItem.Name = "chiTiếtHóaĐơnBánToolStripMenuItem";
            this.chiTiếtHóaĐơnBánToolStripMenuItem.Size = new System.Drawing.Size(297, 28);
            this.chiTiếtHóaĐơnBánToolStripMenuItem.Text = "Chi Tiết Hóa Đơn Bán ";
            this.chiTiếtHóaĐơnBánToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtHóaĐơnBánToolStripMenuItem_Click_2);
            // 
            // chiTiếtHóaĐơnNhậpToolStripMenuItem
            // 
            this.chiTiếtHóaĐơnNhậpToolStripMenuItem.Name = "chiTiếtHóaĐơnNhậpToolStripMenuItem";
            this.chiTiếtHóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(297, 28);
            this.chiTiếtHóaĐơnNhậpToolStripMenuItem.Text = "Chi Tiết Hóa Đơn Nhập ";
            this.chiTiếtHóaĐơnNhậpToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtHóaĐơnNhậpToolStripMenuItem_Click_2);
            // 
            // quảnLýHàngHóaToolStripMenuItem
            // 
            this.quảnLýHàngHóaToolStripMenuItem.Name = "quảnLýHàngHóaToolStripMenuItem";
            this.quảnLýHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(297, 28);
            this.quảnLýHàngHóaToolStripMenuItem.Text = "Quản Lý Hàng Hóa ";
            this.quảnLýHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHàngHóaToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thoátToolStripMenuItem.Image = global::GUI.Properties.Resources.exit;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.thoátToolStripMenuItem.Text = "Thoát ";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(335, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "CỬA HÀNG QUẢN LÝ MÁY TÍNH ";
            // 
            // GUI_frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.thiet_ke_cua_hang_may_tinh_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1342, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI_frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Menu";
            this.Load += new System.EventHandler(this.GUI_frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinMáyTínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHóaĐơnBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHàngHóaToolStripMenuItem;
    }
}

