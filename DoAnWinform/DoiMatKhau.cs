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
    public partial class DoiMatKhau : Form
    {
        DbModel model;
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            model = new DbModel();
            if (model.TaiKhoans.Any(x => x.TaiKhoan1 == tbxTaiKhoan.Text 
            && x.MatKhau == tbxMatKhau.Text && x.TrangThai == true) && tbxMatKhauMoi.Text == tbxMatKhauMoi2.Text)
            {
                var matkhau = model.TaiKhoans.SingleOrDefault(x => x.TaiKhoan1 == tbxTaiKhoan.Text);
                matkhau.MatKhau = tbxMatKhauMoi.Text;
                model.SaveChanges();
                MessageBox.Show("Doi Mat Khau Thanh Cong");
                this.Close();
            }
            else
                if(tbxMatKhauMoi.Text != tbxMatKhauMoi2.Text)
            {
                MessageBox.Show("Mat Khau Moi khong giong nhau!");
            }
            else 
                if(model.TaiKhoans.Any(x => x.TaiKhoan1 == tbxTaiKhoan.Text
            && x.MatKhau != tbxMatKhau.Text && x.TrangThai == true))
            {
                MessageBox.Show("Sai Mat Khau Cu!");
            }
            else
                if (model.TaiKhoans.Any(x => x.TaiKhoan1 != tbxTaiKhoan.Text))
            {
                MessageBox.Show("Tai Khoan Khong Ton Tai");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
