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
    public partial class ThemThuoc : Form
    {
        public ThemThuoc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DbModel model = new DbModel();
            Thuoc thuoc = new Thuoc();
            if(tbxDonViTinh.Text == "" || tbxGiaThanh.Text == "" || tbxLoaiThuoc.Text == "" || tbxSoLuong.Text == "" || tbxTenThuoc.Text == "")
            {
                MessageBox.Show("Vui Long Nhap day du thong tin");
            }
            else
            {
                thuoc.TenThuoc = tbxTenThuoc.Text;
                thuoc.LoaiThuoc = tbxLoaiThuoc.Text;
                thuoc.DonGia = int.Parse(tbxGiaThanh.Text);
                thuoc.TrangThai = true;
                thuoc.DonViTinh = tbxDonViTinh.Text;
                thuoc.SoLuong = int.Parse(tbxSoLuong.Text);
                model.Thuocs.Add(thuoc);
                model.SaveChanges();
                MessageBox.Show("Them Thanh Cong");
                
            }
        }

        private void ThemThuoc_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
