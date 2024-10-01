using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        SinhVien sv = new SinhVien();

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            dgvSV.DataSource = sv.getAllSV();
        }

        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSV.CurrentRow.Index;
            txtidSV.Text = dgvSV.Rows[i].Cells[0].Value.ToString();
            txtTenSV.Text = dgvSV.Rows[i].Cells[1].Value.ToString();
            cbxGioiTinh.Text = dgvSV.Rows[i].Cells[2].Value.ToString();
            dtpNS.Text = dgvSV.Rows[i].Cells[3].Value.ToString();
            txtCCCD.Text = dgvSV.Rows[i].Cells[4].Value.ToString();
            txtSDT.Text = dgvSV.Rows[i].Cells[5].Value.ToString();
            txtQue.Text = dgvSV.Rows[i].Cells[6].Value.ToString();
            txtTruong.Text = dgvSV.Rows[i].Cells[7].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            sv.Insert(txtidSV.Text, txtTenSV.Text, cbxGioiTinh.Text, dtpNS.Text, txtCCCD.Text, txtSDT.Text, txtQue.Text, txtTruong.Text);
            dgvSV.DataSource = sv.getAllSV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sv.Update(txtidSV.Text, txtTenSV.Text, cbxGioiTinh.Text, dtpNS.Text, txtCCCD.Text, txtSDT.Text, txtQue.Text, txtTruong.Text);
            dgvSV.DataSource = sv.getAllSV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtidSV.Text;
            sv.Delete(id);
            dgvSV.DataSource = sv.getAllSV();
        }
    }
}
