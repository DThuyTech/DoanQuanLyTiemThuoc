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
    public partial class ThemNhanVien : Form
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DbModel dbModel = new DbModel();
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.TaiKhoan1 = tbxTaiKhoan.Text;
            taiKhoan.MatKhau = tbxMatKhau.Text;
            taiKhoan.TrangThai = true;
            taiKhoan.HoTen = tbxHoTen.Text;
            if(checkBox1.Checked == true)
            {
                taiKhoan.isAdmin = true;
            }
            else
            {
                taiKhoan.isAdmin = false;
            }
            dbModel.TaiKhoans.Add(taiKhoan);
            dbModel.SaveChanges();
            MessageBox.Show("Them Thanh Cong");
            this.Close();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
