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
    public partial class frmNuoc : Form
    {
        public frmNuoc()
        {
            InitializeComponent();
        }

        Nuoc n = new Nuoc();

        private void frmNuoc_Load(object sender, EventArgs e)
        {
            Nuoc n = new Nuoc();
            dgvNuoc.DataSource = n.getNuoc();

            cbxPhong.DataSource = n.getPhong();
            cbxPhong.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int trangthai = 1;
            if (rdb1.Checked)
                trangthai = 1;
            else
                trangthai = 0;
            n.Insert(cbxPhong.SelectedValue.ToString(), txtCu.Text, txtMoi.Text, dtpTuNgay.Text, dtpDenNgay.Text, trangthai);
            dgvNuoc.DataSource = n.getNuoc();
            cbxPhong.ResetText();
            txtCu.ResetText();
            txtMoi.ResetText();
            txtThanhTien.ResetText();
            rdb0.Checked = true;
        }

        private void dgvNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNuoc.CurrentRow.Index;
            txtID.Text = dgvNuoc.Rows[i].Cells[0].Value.ToString();
            cbxPhong.Text = dgvNuoc.Rows[i].Cells[1].Value.ToString();
            txtCu.Text = dgvNuoc.Rows[i].Cells[2].Value.ToString();
            txtMoi.Text = dgvNuoc.Rows[i].Cells[3].Value.ToString();
            dtpTuNgay.Text = dgvNuoc.Rows[i].Cells[4].Value.ToString();
            dtpDenNgay.Text = dgvNuoc.Rows[i].Cells[5].Value.ToString();
            txtThanhTien.Text = dgvNuoc.Rows[i].Cells[6].Value.ToString();
            if (dgvNuoc.Rows[i].Cells[7].Value.Equals("Đã thanh toán"))
            {
                rdb1.Checked = true;
            }
            else
            {
                rdb0.Checked = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int trangthai = 1;
            if (rdb1.Checked)
                trangthai = 1;
            else
                trangthai = 0;
            n.Update(txtID.Text, cbxPhong.SelectedValue.ToString(), txtCu.Text, txtMoi.Text, dtpTuNgay.Text, dtpDenNgay.Text, trangthai);
            dgvNuoc.DataSource = n.getNuoc();
            cbxPhong.ResetText();
            txtCu.ResetText();
            txtMoi.ResetText();
            txtThanhTien.ResetText();
            rdb0.Checked = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            n.Delete(txtID.Text);
            dgvNuoc.DataSource = n.getNuoc();
            cbxPhong.ResetText();
            txtCu.ResetText();
            txtMoi.ResetText();
            txtThanhTien.ResetText();
            rdb0.Checked = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
