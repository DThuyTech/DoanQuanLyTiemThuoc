using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class FormHeThongAdmin : Form
    {
        DbModel model;
        public FormHeThongAdmin()
        {
            InitializeComponent();
        }

        private void FormHeThong_Load(object sender, EventArgs e)
        {
            
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.ShowDialog();
        }

        private void themNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNhanVien themNhanVien = new ThemNhanVien();
            themNhanVien.ShowDialog();
        }

        private void themThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 quanlythuoc = new Form2();
            quanlythuoc.ShowDialog();
        }

        private void btnBanThuoc_Click(object sender, EventArgs e)
        {
            BanThuoc form = new BanThuoc();
            form.ShowDialog();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hêThôngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNhanVien themNhanVien = new ThemNhanVien();
            themNhanVien.ShowDialog();
        }

        private void thêmThuôcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 quanlythuoc = new Form2();
            quanlythuoc.ShowDialog();
        }

        private void đôiMâtKhâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.ShowDialog();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
                
        }
    }
}
