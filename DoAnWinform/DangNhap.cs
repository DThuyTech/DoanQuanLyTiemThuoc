using OpenXmlPowerTools;
using SolrNet.Utils;
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
    public partial class DangNhap : Form
    { 
        DbModel model;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            model = new DbModel();
            if (model.TaiKhoans.Any(x => x.TaiKhoan1 == tbxTaiKhoan.Text && x.MatKhau == tbxMatKhau.Text && x.TrangThai == true && x.isAdmin == true))
            {
                
                FormHeThongAdmin form = new FormHeThongAdmin();
                
                form.ShowDialog();
                this.Close();

            }
            else 
                if (model.TaiKhoans.Any(x => x.TaiKhoan1 == tbxTaiKhoan.Text && x.MatKhau == tbxMatKhau.Text && x.TrangThai == true && x.isAdmin == false))
                {
                BanThuoc banthuoc = new BanThuoc();
                banthuoc.ShowDialog();
                this.Close();

                }
                else
                    if (model.TaiKhoans.Any(x => x.TaiKhoan1 == tbxTaiKhoan.Text && x.MatKhau == tbxMatKhau.Text && x.TrangThai == false))
                    {
                      MessageBox.Show("tai khoan da bi xoa");
                    }
                    else
                        if (model.TaiKhoans.Any(x => x.TaiKhoan1 == tbxTaiKhoan.Text && x.MatKhau != tbxMatKhau.Text && x.TrangThai == true))
                        {
                         MessageBox.Show("Sai mat khau");
                        }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
