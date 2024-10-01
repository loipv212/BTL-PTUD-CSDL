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
    public partial class frmXepPhongChild : Form
    {
        public frmXepPhongChild()
        {
            InitializeComponent();
        }

        XepPhongChild xpc = new XepPhongChild();


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            xpc.Insert(cbxSV.SelectedValue.ToString(), cbxPhong.SelectedValue.ToString(), txtTien.Text, dtpNgayThue.Text);
            xpc.setTrue(cbxSV.SelectedValue.ToString());
            MessageBox.Show("Xếp phòng cho sinh viên " + cbxSV.Text + " vào " + cbxPhong.Text + " thành công.");
            txtTien.ResetText();
            cbxPhong.ResetText();
            cbxSV.ResetText();
            cbxSV.DataSource = xpc.getAllSV();
            cbxSV.SelectedIndex = -1;

            cbxPhong.DataSource = xpc.getAllPhong();
            cbxPhong.SelectedIndex = -1;
        }

        private void frmXepPhongChild_Load(object sender, EventArgs e)
        {
            cbxSV.DataSource = xpc.getAllSV();
            cbxSV.SelectedIndex = -1;
            
            cbxPhong.DataSource = xpc.getAllPhong();
            cbxPhong.SelectedIndex = -1;
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
