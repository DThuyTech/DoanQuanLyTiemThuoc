using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class Form2 : Form
    {
        DbModel model;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = new DbModel();
            if (model.Thuocs.Any(x => x.TenThuoc == comboBox1.Text))
            {
                Thuoc thuoc = new Thuoc();
                thuoc = model.Thuocs.Where(x=> x.TenThuoc == comboBox1.Text).FirstOrDefault();
                tbxGiaThanh.Text = thuoc.DonGia.ToString();
                tbxLoaiThuoc.Text = thuoc.LoaiThuoc.ToString();
                tbxMaThuoc.Text = thuoc.idThuoc.ToString();
                tbxSoLuong.Text = thuoc.SoLuong.ToString();
                tbxTenThuoc.Text = thuoc.TenThuoc.ToString();
                tbxDonViTinh.Text = thuoc.DonViTinh;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
                using (DbModel c = new DbModel())
            {
                comboBox1.DataSource = c.Thuocs.Where(x=>x.TrangThai==true).ToList();
                comboBox1.ValueMember = "idThuoc";
                comboBox1.DisplayMember = "TenThuoc";
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemThuoc themthuoc = new ThemThuoc();
            themthuoc.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            model = new DbModel();
            if (model.Thuocs.Any(x => x.TenThuoc == comboBox1.Text))
            {
                var c = model.Thuocs.SingleOrDefault(x => x.TenThuoc == comboBox1.Text);
                c.TrangThai = false;
                model.SaveChanges();
                MessageBox.Show("Xoa Thanh Cong");
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbxTenThuoc.ReadOnly == true)
            {
                tbxTenThuoc.ReadOnly = false;
                tbxSoLuong.ReadOnly = false;
                tbxMaThuoc.ReadOnly = false;
                tbxLoaiThuoc.ReadOnly = false;
                tbxGiaThanh.ReadOnly = false;
                tbxDonViTinh.ReadOnly = false;
            }
            else
            {
                if (tbxTenThuoc.ReadOnly == false)
                {
                    var thuoc = model.Thuocs.SingleOrDefault(x => x.TenThuoc == comboBox1.Text);
                    thuoc.TenThuoc = tbxTenThuoc.Text;
                    thuoc.LoaiThuoc = tbxLoaiThuoc.Text;
                    thuoc.DonGia = int.Parse(tbxGiaThanh.Text);
                    thuoc.TrangThai = true;
                    thuoc.DonViTinh = tbxDonViTinh.Text;
                    thuoc.SoLuong = int.Parse(tbxSoLuong.Text);
                    model.SaveChanges();
                    tbxTenThuoc.ReadOnly = true;
                    tbxSoLuong.ReadOnly = true;
                    tbxMaThuoc.ReadOnly = true;
                    tbxLoaiThuoc.ReadOnly = true;
                    tbxGiaThanh.ReadOnly = true;
                    tbxDonViTinh.ReadOnly = true;
                    MessageBox.Show("Sua Thanh Cong!");
                }
            }
        }

        private void QuanLyThuoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnDsThuoc_Click(object sender, EventArgs e)
        {
            DanhSachThuoc dsThuoc = new DanhSachThuoc();
            dsThuoc.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
