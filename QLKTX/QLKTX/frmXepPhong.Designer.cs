namespace QLKTX
{
    partial class frmXepPhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.btnXepPhong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvXepPhong = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSV = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXepPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSV);
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên";
            // 
            // dgvSV
            // 
            this.dgvSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSV.Location = new System.Drawing.Point(3, 16);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.Size = new System.Drawing.Size(910, 278);
            this.dgvSV.TabIndex = 0;
            // 
            // btnXepPhong
            // 
            this.btnXepPhong.Location = new System.Drawing.Point(15, 12);
            this.btnXepPhong.Name = "btnXepPhong";
            this.btnXepPhong.Size = new System.Drawing.Size(105, 48);
            this.btnXepPhong.TabIndex = 2;
            this.btnXepPhong.Text = "Xếp phòng";
            this.btnXepPhong.UseVisualStyleBackColor = true;
            this.btnXepPhong.Click += new System.EventHandler(this.btnXepPhong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvXepPhong);
            this.groupBox2.Location = new System.Drawing.Point(443, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 176);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xếp phòng";
            // 
            // dgvXepPhong
            // 
            this.dgvXepPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXepPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXepPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXepPhong.Location = new System.Drawing.Point(3, 16);
            this.dgvXepPhong.Name = "dgvXepPhong";
            this.dgvXepPhong.Size = new System.Drawing.Size(476, 157);
            this.dgvXepPhong.TabIndex = 0;
            this.dgvXepPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXepPhong_CellClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(15, 66);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(105, 48);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(15, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 48);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(243, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(127, 20);
            this.txtID.TabIndex = 5;
            this.txtID.Visible = false;
            // 
            // txtSV
            // 
            this.txtSV.Location = new System.Drawing.Point(243, 81);
            this.txtSV.Name = "txtSV";
            this.txtSV.ReadOnly = true;
            this.txtSV.Size = new System.Drawing.Size(127, 20);
            this.txtSV.TabIndex = 7;
            this.txtSV.Visible = false;
            // 
            // frmXepPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 503);
            this.Controls.Add(this.txtSV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXepPhong);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmXepPhong";
            this.Text = "QUẢN LÝ XẾP PHÒNG";
            this.Load += new System.EventHandler(this.frmXepPhong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXepPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.Button btnXepPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvXepPhong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSV;
    }
}