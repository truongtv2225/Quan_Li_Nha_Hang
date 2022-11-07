namespace GUI
{
    partial class Frm_BanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowban = new System.Windows.Forms.FlowLayoutPanel();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.flowsanpham = new System.Windows.Forms.FlowLayoutPanel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowban);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bàn";
            // 
            // flowban
            // 
            this.flowban.Location = new System.Drawing.Point(6, 21);
            this.flowban.Name = "flowban";
            this.flowban.Size = new System.Drawing.Size(689, 252);
            this.flowban.TabIndex = 0;
            // 
            // groupbox
            // 
            this.groupbox.Location = new System.Drawing.Point(2, 286);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(701, 418);
            this.groupbox.TabIndex = 0;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Sản phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnThanhToan);
            this.groupBox3.Controls.Add(this.dgvChiTietHD);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtThanhTien);
            this.groupBox3.Controls.Add(this.txtTenBan);
            this.groupBox3.Controls.Add(this.txtMaHD);
            this.groupBox3.Location = new System.Drawing.Point(709, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 703);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hóa đơn";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Lime;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThanhToan.Location = new System.Drawing.Point(130, 649);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(164, 48);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dgvChiTietHD
            // 
            this.dgvChiTietHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.btnXoa});
            this.dgvChiTietHD.Location = new System.Drawing.Point(6, 103);
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.RowHeadersWidth = 51;
            this.dgvChiTietHD.RowTemplate.Height = 24;
            this.dgvChiTietHD.Size = new System.Drawing.Size(409, 444);
            this.dgvChiTietHD.TabIndex = 2;
            this.dgvChiTietHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHD_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bàn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thành tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(253, 575);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(150, 22);
            this.txtThanhTien.TabIndex = 0;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Enabled = false;
            this.txtTenBan.Location = new System.Drawing.Point(143, 64);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(127, 22);
            this.txtTenBan.TabIndex = 0;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(10, 64);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(127, 22);
            this.txtMaHD.TabIndex = 0;
            // 
            // flowsanpham
            // 
            this.flowsanpham.Location = new System.Drawing.Point(8, 307);
            this.flowsanpham.Name = "flowsanpham";
            this.flowsanpham.Size = new System.Drawing.Size(689, 391);
            this.flowsanpham.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenHang";
            this.Column1.HeaderText = "Tên hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GiaBan";
            this.Column2.HeaderText = "Giá";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TongThanhTien";
            this.Column4.HeaderText = "Tồng tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // btnXoa
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.HeaderText = "";
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseColumnTextForButtonValue = true;
            this.btnXoa.Width = 75;
            // 
            // Frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 704);
            this.Controls.Add(this.flowsanpham);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_BanHang";
            this.Load += new System.EventHandler(this.Frm_BanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowban;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowsanpham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}