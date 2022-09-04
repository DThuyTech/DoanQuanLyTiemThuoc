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
    public partial class DanhSachThuoc : Form
    {
        public DanhSachThuoc()
        {
            InitializeComponent();
        }

        private void DanhSachThuoc_Load(object sender, EventArgs e)
        {
            using (DbModel c = new DbModel())
            {
                dataGridView1.DataSource = c.Thuocs.Where(x => x.TrangThai == true).ToList();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }
    }
}
