namespace DoAnWinform
{
    partial class FormHeThongAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBanThuoc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đôiMâtKhâuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuâtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmThuôcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themThuocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DoAnWinform.Properties.Resources.sd;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBanThuoc);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 407);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý thuốc";
            // 
            // btnBanThuoc
            // 
            this.btnBanThuoc.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanThuoc.Location = new System.Drawing.Point(202, 226);
            this.btnBanThuoc.Name = "btnBanThuoc";
            this.btnBanThuoc.Size = new System.Drawing.Size(380, 110);
            this.btnBanThuoc.TabIndex = 2;
            this.btnBanThuoc.Text = "BÁN THUỐC";
            this.btnBanThuoc.UseVisualStyleBackColor = true;
            this.btnBanThuoc.Click += new System.EventHandler(this.btnBanThuoc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::DoAnWinform.Properties.Resources.pexels_cup_of_couple_8015823__1_;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hêThôngToolStripMenuItem,
            this.adminToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hêThôngToolStripMenuItem
            // 
            this.hêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đôiMâtKhâuToolStripMenuItem,
            this.đăngXuâtToolStripMenuItem});
            this.hêThôngToolStripMenuItem.Name = "hêThôngToolStripMenuItem";
            this.hêThôngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hêThôngToolStripMenuItem.Text = "Hệ Thống";
            this.hêThôngToolStripMenuItem.Click += new System.EventHandler(this.hêThôngToolStripMenuItem_Click);
            // 
            // đôiMâtKhâuToolStripMenuItem
            // 
            this.đôiMâtKhâuToolStripMenuItem.Name = "đôiMâtKhâuToolStripMenuItem";
            this.đôiMâtKhâuToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.đôiMâtKhâuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đôiMâtKhâuToolStripMenuItem.Click += new System.EventHandler(this.đôiMâtKhâuToolStripMenuItem_Click);
            // 
            // đăngXuâtToolStripMenuItem
            // 
            this.đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            this.đăngXuâtToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.đăngXuâtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuâtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuâtToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem1
            // 
            this.adminToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmNhânViênToolStripMenuItem,
            this.thêmThuôcToolStripMenuItem});
            this.adminToolStripMenuItem1.Name = "adminToolStripMenuItem1";
            this.adminToolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem1.Text = "admin";
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            this.thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            this.thêmNhânViênToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.thêmNhânViênToolStripMenuItem.Text = "Thêm nhân viên";
            this.thêmNhânViênToolStripMenuItem.Click += new System.EventHandler(this.thêmNhânViênToolStripMenuItem_Click);
            // 
            // thêmThuôcToolStripMenuItem
            // 
            this.thêmThuôcToolStripMenuItem.Name = "thêmThuôcToolStripMenuItem";
            this.thêmThuôcToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.thêmThuôcToolStripMenuItem.Text = "Thêm thuốc";
            this.thêmThuôcToolStripMenuItem.Click += new System.EventHandler(this.thêmThuôcToolStripMenuItem_Click);
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMatKhauToolStripMenuItem,
            this.dangXuatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            this.doiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themNhanVienToolStripMenuItem,
            this.themThuocToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // themNhanVienToolStripMenuItem
            // 
            this.themNhanVienToolStripMenuItem.Name = "themNhanVienToolStripMenuItem";
            this.themNhanVienToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.themNhanVienToolStripMenuItem.Text = "Thêm nhân viên";
            this.themNhanVienToolStripMenuItem.Click += new System.EventHandler(this.themNhanVienToolStripMenuItem_Click);
            // 
            // themThuocToolStripMenuItem
            // 
            this.themThuocToolStripMenuItem.Name = "themThuocToolStripMenuItem";
            this.themThuocToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.themThuocToolStripMenuItem.Text = "Quản lý thuốc";
            this.themThuocToolStripMenuItem.Click += new System.EventHandler(this.themThuocToolStripMenuItem_Click);
            // 
            // FormHeThongAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHeThongAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHeThong";
            this.Load += new System.EventHandler(this.FormHeThong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themThuocToolStripMenuItem;
        private System.Windows.Forms.Button btnBanThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem hêThôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đôiMâtKhâuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thêmNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmThuôcToolStripMenuItem;
    }
}