namespace QLKTX
{
    partial class frmXepPhongChild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSV = new System.Windows.Forms.ComboBox();
            this.cbxPhong = new System.Windows.Forms.ComboBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền cọc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày thuê:";
            // 
            // cbxSV
            // 
            this.cbxSV.DisplayMember = "Ten";
            this.cbxSV.FormattingEnabled = true;
            this.cbxSV.Location = new System.Drawing.Point(84, 51);
            this.cbxSV.Name = "cbxSV";
            this.cbxSV.Size = new System.Drawing.Size(157, 21);
            this.cbxSV.TabIndex = 4;
            this.cbxSV.ValueMember = "idSinhVien";
            // 
            // cbxPhong
            // 
            this.cbxPhong.DisplayMember = "TenPhong";
            this.cbxPhong.FormattingEnabled = true;
            this.cbxPhong.Location = new System.Drawing.Point(329, 51);
            this.cbxPhong.Name = "cbxPhong";
            this.cbxPhong.Size = new System.Drawing.Size(157, 21);
            this.cbxPhong.TabIndex = 5;
            this.cbxPhong.ValueMember = "idPhong";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(84, 111);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(157, 20);
            this.txtTien.TabIndex = 6;
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Checked = false;
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThue.Location = new System.Drawing.Point(329, 111);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(157, 20);
            this.dtpNgayThue.TabIndex = 7;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(65, 197);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(107, 42);
            this.btnDangKy.TabIndex = 8;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(347, 197);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 42);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmXepPhongChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 285);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.dtpNgayThue);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.cbxPhong);
            this.Controls.Add(this.cbxSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmXepPhongChild";
            this.Text = "frmXepPhongChild";
            this.Load += new System.EventHandler(this.frmXepPhongChild_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSV;
        private System.Windows.Forms.ComboBox cbxPhong;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
    }
}