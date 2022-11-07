namespace GUI
{
    partial class Frm_QLLH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.dgvLoai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSanPham);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.txtMa);
            this.panel1.Controls.Add(this.dgvLoai);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 617);
            this.panel1.TabIndex = 1;
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.Red;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSanPham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSanPham.Location = new System.Drawing.Point(233, 535);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(134, 48);
            this.btnSanPham.TabIndex = 3;
            this.btnSanPham.Text = "Đóng";
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(87, 535);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 48);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(236, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(236, 440);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(212, 22);
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(12, 440);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(212, 22);
            this.txtMa.TabIndex = 1;
            // 
            // dgvLoai
            // 
            this.dgvLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvLoai.Location = new System.Drawing.Point(3, 3);
            this.dgvLoai.Name = "dgvLoai";
            this.dgvLoai.RowHeadersWidth = 51;
            this.dgvLoai.RowTemplate.Height = 24;
            this.dgvLoai.Size = new System.Drawing.Size(451, 391);
            this.dgvLoai.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ma";
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ten";
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Frm_QLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(484, 645);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QLLH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_QLLH";
            this.Load += new System.EventHandler(this.Frm_QLLH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.DataGridView dgvLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}