using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class frmDien : Form
    {
        public frmDien()
        {
            InitializeComponent();
        }

        Dien d = new Dien();

        private void dgvDien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDien.CurrentRow.Index;
            txtID.Text = dgvDien.Rows[i].Cells[0].Value.ToString();
            cbxPhong.Text = dgvDien.Rows[i].Cells[1].Value.ToString();
            txtCu.Text = dgvDien.Rows[i].Cells[2].Value.ToString();
            txtMoi.Text = dgvDien.Rows[i].Cells[3].Value.ToString();
            dtpTuNgay.Text = dgvDien.Rows[i].Cells[4].Value.ToString();
            dtpDenNgay.Text = dgvDien.Rows[i].Cells[5].Value.ToString();
            txtThanhTien.Text = dgvDien.Rows[i].Cells[6].Value.ToString();
            if (dgvDien.Rows[i].Cells[7].Value.Equals("Đã thanh toán"))
            {
                rdb1.Checked = true;
            }
            else
            {
                rdb0.Checked = true;
            }
        }

        private void frmDien_Load(object sender, EventArgs e)
        {
            Dien d = new Dien();
            dgvDien.DataSource = d.getDien();

            cbxPhong.DataSource = d.getPhong();
            cbxPhong.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int trangthai = 1;
            if (rdb1.Checked)
                trangthai = 1;
            else
                trangthai = 0;
            d.Insert(cbxPhong.SelectedValue.ToString(), txtCu.Text, txtMoi.Text, dtpTuNgay.Text, dtpDenNgay.Text, trangthai);
            dgvDien.DataSource = d.getDien();
            cbxPhong.ResetText();
            txtCu.ResetText();
            txtMoi.ResetText();
            txtThanhTien.ResetText();
            rdb0.Checked = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int trangthai = 1;
            if (rdb1.Checked)
                trangthai = 1;
            else
                trangthai = 0;
            d.Update(txtID.Text, cbxPhong.SelectedValue.ToString(), txtCu.Text, txtMoi.Text, dtpTuNgay.Text, dtpDenNgay.Text, trangthai);
            dgvDien.DataSource = d.getDien();
            cbxPhong.ResetText();
            txtCu.ResetText();
            txtMoi.ResetText();
            txtThanhTien.ResetText();
            rdb0.Checked = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            d.Delete(txtID.Text);
            dgvDien.DataSource = d.getDien();
            cbxPhong.ResetText();
            txtCu.ResetText();
            txtMoi.ResetText();
            txtThanhTien.ResetText();
            rdb0.Checked = true;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Tiền điện");

                        for (int i = 0; i < dgvDien.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dgvDien.Columns[i].HeaderText;
                        }

                        for (int row = 0; row < dgvDien.Rows.Count; row++)
                        {
                            for (int col = 0; col < dgvDien.Columns.Count; col++)
                            {
                                if (col == 4)
                                {
                                    DateTime dateValue;
                                    if (dgvDien.Rows[row].Cells[col].Value != null && DateTime.TryParse(dgvDien.Rows[row].Cells[col].Value.ToString(), out dateValue))
                                    {
                                        worksheet.Cells[row + 2, col + 1].Value = dateValue;
                                        worksheet.Cells[row + 2, col + 1].Style.Numberformat.Format = "dd-MM-yyyy";
                                    }
                                }

                                if (col == 5)
                                {
                                    DateTime dateValue;
                                    if (dgvDien.Rows[row].Cells[col].Value != null && DateTime.TryParse(dgvDien.Rows[row].Cells[col].Value.ToString(), out dateValue))
                                    {
                                        worksheet.Cells[row + 2, col + 1].Value = dateValue;
                                        worksheet.Cells[row + 2, col + 1].Style.Numberformat.Format = "dd-MM-yyyy";
                                    }
                                }
                                else
                                {
                                    worksheet.Cells[row + 2, col + 1].Value = dgvDien.Rows[row].Cells[col].Value;
                                }
                            }
                        }

                        FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                        excelPackage.SaveAs(excelFile);
                    }

                    MessageBox.Show("Xuất dữ liệu thành công!");
                }
            }
        }
    }
}
