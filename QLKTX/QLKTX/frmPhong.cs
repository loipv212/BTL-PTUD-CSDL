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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        Phong p = new Phong();

        private void frmPhong_Load(object sender, EventArgs e)
        {
            Phong p = new Phong();
            dgvPhong.DataSource = p.getAllPhong();

            cbxLoai.DataSource = p.getLoaiPhong();
            cbxLoai.SelectedIndex = -1;
            
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvPhong.CurrentRow.Index;
            txtID.Text = dgvPhong.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dgvPhong.Rows[i].Cells[1].Value.ToString();
            txtSlot.Text = dgvPhong.Rows[i].Cells[2].Value.ToString();
            cbxTrangThai.Text = dgvPhong.Rows[i].Cells[3].Value.ToString();
            cbxLoai.Text = dgvPhong.Rows[i].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int trangthai = 1;
            int gioitinh = 1;
            if (cbxTrangThai.Text == "Hoạt động")
                trangthai = 1;
            else
                trangthai = 0;

            if (cbxLoai.Text == "Nam")
                gioitinh = 1;
            else
                gioitinh = 2;
            p.Insert(txtID.Text, txtTen.Text, txtSlot.Text, trangthai, gioitinh);
            dgvPhong.DataSource = p.getAllPhong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int trangthai = 1;
            int gioitinh = 1;
            if (cbxTrangThai.Text == "Hoạt động")
                trangthai = 1;
            else
                trangthai = 0;

            if (cbxLoai.Text == "Nam")
                gioitinh = 1;
            else
                gioitinh = 2;

            p.Update(txtID.Text, txtTen.Text, txtSlot.Text, trangthai, gioitinh);
            dgvPhong.DataSource = p.getAllPhong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            p.Delete(id);
            dgvPhong.DataSource = p.getAllPhong();
            txtID.ResetText();
            txtSlot.ResetText();
            txtTen.ResetText();
            cbxLoai.ResetText();
            cbxLoai.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPhong.DataSource = p.getThuePhong(txtID.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvPhong.DataSource = p.getAllPhong();
        }
    }
}
