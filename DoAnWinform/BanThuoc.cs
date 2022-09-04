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
    public partial class BanThuoc : Form
    {
        DbModel model;
        public BanThuoc()
        {
            InitializeComponent();
        }

        private void comboBox_TenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = new DbModel();
            if (model.Thuocs.Any(x => x.TenThuoc == comboBox1.Text))
            {
                Thuoc thuoc = new Thuoc();
                thuoc = model.Thuocs.Where(x => x.TenThuoc == comboBox1.Text).FirstOrDefault();
                tbxGiaThanh.Text = thuoc.DonGia.ToString();
                tbxLoaiThuoc.Text = thuoc.LoaiThuoc.ToString();
            }

        }

        private void BanThuoc_Load(object sender, EventArgs e)
        {
            using (DbModel c = new DbModel())
            {
                comboBox1.DataSource = c.Thuocs.Where(x => x.TrangThai == true).ToList();
                comboBox1.ValueMember = "idThuoc";
                comboBox1.DisplayMember = "TenThuoc";
            }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            model = new DbModel();
            Thuoc thuoc = new Thuoc();
            int tonggia = int.Parse(tbxGiaThanh.Text)*int.Parse(tbxSoLuong.Text);
            dataGridView1.Rows.Add(comboBox1.Text, tbxLoaiThuoc.Text, tbxSoLuong.Text, tbxGiaThanh.Text, tonggia);

        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 &&
            this.dataGridView1.SelectedRows[0].Index !=
            this.dataGridView1.Rows.Count - 1)
            {
                this.dataGridView1.Rows.RemoveAt(
                    this.dataGridView1.SelectedRows[0].Index);
            }
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxTongHoaDon_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            lbTongHoaDon.Text = "0";
            dataGridView1.AllowUserToAddRows = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                lbTongHoaDon.Text = Convert.ToString(double.Parse(lbTongHoaDon.Text) + double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()));
            }
        }

        private void tbxTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
