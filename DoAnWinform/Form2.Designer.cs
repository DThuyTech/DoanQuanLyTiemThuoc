namespace DoAnWinform
{
    partial class Form2
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
            this.btnDsThuoc = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbxMaThuoc = new System.Windows.Forms.TextBox();
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.tbxLoaiThuoc = new System.Windows.Forms.TextBox();
            this.tbxGiaThanh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxDonViTinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxTenThuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DoAnWinform.Properties.Resources.a;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnDsThuoc);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.tbxMaThuoc);
            this.panel1.Controls.Add(this.tbxSoLuong);
            this.panel1.Controls.Add(this.tbxLoaiThuoc);
            this.panel1.Controls.Add(this.tbxGiaThanh);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbxDonViTinh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbxTenThuoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 198);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDsThuoc
            // 
            this.btnDsThuoc.BackColor = System.Drawing.Color.Black;
            this.btnDsThuoc.ForeColor = System.Drawing.Color.White;
            this.btnDsThuoc.Location = new System.Drawing.Point(307, 150);
            this.btnDsThuoc.Name = "btnDsThuoc";
            this.btnDsThuoc.Size = new System.Drawing.Size(97, 31);
            this.btnDsThuoc.TabIndex = 5;
            this.btnDsThuoc.Text = "Danh sách thuốc";
            this.btnDsThuoc.UseVisualStyleBackColor = false;
            this.btnDsThuoc.Click += new System.EventHandler(this.btnDsThuoc_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(572, 150);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(491, 150);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(410, 150);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbxMaThuoc
            // 
            this.tbxMaThuoc.Location = new System.Drawing.Point(518, 3);
            this.tbxMaThuoc.Name = "tbxMaThuoc";
            this.tbxMaThuoc.ReadOnly = true;
            this.tbxMaThuoc.Size = new System.Drawing.Size(72, 22);
            this.tbxMaThuoc.TabIndex = 3;
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Location = new System.Drawing.Point(82, 110);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.ReadOnly = true;
            this.tbxSoLuong.Size = new System.Drawing.Size(54, 22);
            this.tbxSoLuong.TabIndex = 3;
            // 
            // tbxLoaiThuoc
            // 
            this.tbxLoaiThuoc.Location = new System.Drawing.Point(82, 82);
            this.tbxLoaiThuoc.Name = "tbxLoaiThuoc";
            this.tbxLoaiThuoc.ReadOnly = true;
            this.tbxLoaiThuoc.Size = new System.Drawing.Size(230, 22);
            this.tbxLoaiThuoc.TabIndex = 3;
            // 
            // tbxGiaThanh
            // 
            this.tbxGiaThanh.Location = new System.Drawing.Point(400, 82);
            this.tbxGiaThanh.Name = "tbxGiaThanh";
            this.tbxGiaThanh.ReadOnly = true;
            this.tbxGiaThanh.Size = new System.Drawing.Size(230, 22);
            this.tbxGiaThanh.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(445, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã thuốc";
            // 
            // tbxDonViTinh
            // 
            this.tbxDonViTinh.Location = new System.Drawing.Point(400, 54);
            this.tbxDonViTinh.Name = "tbxDonViTinh";
            this.tbxDonViTinh.ReadOnly = true;
            this.tbxDonViTinh.Size = new System.Drawing.Size(230, 22);
            this.tbxDonViTinh.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(4, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(318, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá thành";
            // 
            // tbxTenThuoc
            // 
            this.tbxTenThuoc.Location = new System.Drawing.Point(82, 54);
            this.tbxTenThuoc.Name = "tbxTenThuoc";
            this.tbxTenThuoc.ReadOnly = true;
            this.tbxTenThuoc.Size = new System.Drawing.Size(230, 22);
            this.tbxTenThuoc.TabIndex = 3;
            this.tbxTenThuoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(318, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(4, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(4, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thuốc";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(371, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thuốc";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 218);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly Thuoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyThuoc_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.TextBox tbxLoaiThuoc;
        private System.Windows.Forms.TextBox tbxDonViTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxTenThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMaThuoc;
        private System.Windows.Forms.TextBox tbxGiaThanh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDsThuoc;
    }
}