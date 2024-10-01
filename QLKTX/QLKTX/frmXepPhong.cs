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
    public partial class frmXepPhong : Form
    {
        public frmXepPhong()
        {
            InitializeComponent();
        }

        XepPhong xp = new XepPhong();

        private void frmXepPhong_Load(object sender, EventArgs e)
        {
            XepPhong xp = new XepPhong();
            dgvSV.DataSource = xp.getAllSV();
            dgvXepPhong.DataSource = xp.getXepPhong();
        }


        private void btnXepPhong_Click(object sender, EventArgs e)
        {
            frmXepPhongChild frm = new frmXepPhongChild();
            frm.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvSV.DataSource = xp.getAllSV();

            dgvXepPhong.DataSource = xp.getXepPhong();
        }

        private void dgvXepPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvXepPhong.CurrentRow.Index;
            txtID.Text = dgvXepPhong.Rows[i].Cells[0].Value.ToString();
            txtSV.Text = dgvXepPhong.Rows[i].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idThue = txtID.Text;
            string idSV = txtSV.Text;
            xp.Delete(idThue, idSV);
            dgvSV.DataSource = xp.getAllSV();
            dgvXepPhong.DataSource =xp.getXepPhong();
        }
    }
}
