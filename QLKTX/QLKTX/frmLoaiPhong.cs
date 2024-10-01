using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        LoaiPhong lp = new LoaiPhong();

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            LoaiPhong lp = new LoaiPhong();
            dgvLoaiPhong.DataSource = lp.getAllLoaiPhong();
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvLoaiPhong.CurrentRow.Index;
            txtID.Text = dgvLoaiPhong.Rows[i].Cells[0].Value.ToString();
            txtTien.Text = dgvLoaiPhong.Rows[i].Cells[1].Value.ToString();
            txtLoai.Text = dgvLoaiPhong.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lp.Insert(txtID.Text, txtTien.Text, txtLoai.Text);
            dgvLoaiPhong.DataSource = lp.getAllLoaiPhong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lp.Update(txtID.Text, txtTien.Text, txtLoai.Text);
            dgvLoaiPhong.DataSource = lp.getAllLoaiPhong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            lp.Delete(id);
            dgvLoaiPhong.DataSource = lp.getAllLoaiPhong();
        }
    }
}
