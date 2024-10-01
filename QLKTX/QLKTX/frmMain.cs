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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form currentChildForm;

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnXuly_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSinhVien());
            label1.Text = btnQLSV.Text;
        }

        private void btnQLLPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLoaiPhong());
            label1.Text = btnQLLPhong.Text;
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhong());
            label1.Text = btnPhong.Text;
        }

        private void btnXepPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmXepPhong());
            label1.Text = btnXepPhong.Text;
        }

        private void btnDien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDien());
            label1.Text = btnDien.Text;
        }

        private void btnNuoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNuoc());
            label1.Text = btnNuoc.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangChu());
            label1.Text = btnHome.Text;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnHome_Click(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
