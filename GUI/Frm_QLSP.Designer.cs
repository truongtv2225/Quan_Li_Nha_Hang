namespace GUI
{
    partial class Frm_QLSP
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnQLLH = new System.Windows.Forms.Label();
            this.btnQLNSX = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbLoaiSP = new System.Windows.Forms.ComboBox();
            this.cbbNsx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbAnhSP = new System.Windows.Forms.PictureBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.btnXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnQLLH);
            this.groupBox1.Controls.Add(this.btnQLNSX);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 698);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(511, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 24);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(0, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 629);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnQLLH
            // 
            this.btnQLLH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLLH.AutoSize = true;
            this.btnQLLH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQLLH.Location = new System.Drawing.Point(9, 39);
            this.btnQLLH.Name = "btnQLLH";
            this.btnQLLH.Size = new System.Drawing.Size(81, 18);
            this.btnQLLH.TabIndex = 3;
            this.btnQLLH.Text = "Loại hàng";
            this.btnQLLH.Click += new System.EventHandler(this.btnQLLH_Click);
            // 
            // btnQLNSX
            // 
            this.btnQLNSX.AutoSize = true;
            this.btnQLNSX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQLNSX.Location = new System.Drawing.Point(112, 39);
            this.btnQLNSX.Name = "btnQLNSX";
            this.btnQLNSX.Size = new System.Drawing.Size(106, 18);
            this.btnQLNSX.TabIndex = 3;
            this.btnQLNSX.Text = "Nhà sản xuất";
            this.btnQLNSX.Click += new System.EventHandler(this.btnQLNSX_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Controls.Add(this.button3);
            this.btnXoa.Controls.Add(this.btnSua);
            this.btnXoa.Controls.Add(this.label10);
            this.btnXoa.Controls.Add(this.btnThem);
            this.btnXoa.Controls.Add(this.cbbLoaiSP);
            this.btnXoa.Controls.Add(this.cbbNsx);
            this.btnXoa.Controls.Add(this.label7);
            this.btnXoa.Controls.Add(this.label5);
            this.btnXoa.Controls.Add(this.label4);
            this.btnXoa.Controls.Add(this.label3);
            this.btnXoa.Controls.Add(this.label2);
            this.btnXoa.Controls.Add(this.label8);
            this.btnXoa.Controls.Add(this.label1);
            this.btnXoa.Controls.Add(this.ptbAnhSP);
            this.btnXoa.Controls.Add(this.txtSoLuong);
            this.btnXoa.Controls.Add(this.txtGiaBan);
            this.btnXoa.Controls.Add(this.txtGiaNhap);
            this.btnXoa.Controls.Add(this.txtTen);
            this.btnXoa.Controls.Add(this.txtMa);
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(744, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(385, 698);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "Chức năng";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(253, 557);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Location = new System.Drawing.Point(138, 557);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 44);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Loại hàng";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Location = new System.Drawing.Point(23, 557);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 44);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbLoaiSP
            // 
            this.cbbLoaiSP.FormattingEnabled = true;
            this.cbbLoaiSP.Location = new System.Drawing.Point(26, 498);
            this.cbbLoaiSP.Name = "cbbLoaiSP";
            this.cbbLoaiSP.Size = new System.Drawing.Size(154, 26);
            this.cbbLoaiSP.TabIndex = 4;
            // 
            // cbbNsx
            // 
            this.cbbNsx.FormattingEnabled = true;
            this.cbbNsx.Location = new System.Drawing.Point(203, 498);
            this.cbbNsx.Name = "cbbNsx";
            this.cbbNsx.Size = new System.Drawing.Size(154, 26);
            this.cbbNsx.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nhà sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Chọn ảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã";
            // 
            // ptbAnhSP
            // 
            this.ptbAnhSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbAnhSP.Location = new System.Drawing.Point(124, 54);
            this.ptbAnhSP.Name = "ptbAnhSP";
            this.ptbAnhSP.Size = new System.Drawing.Size(138, 131);
            this.ptbAnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAnhSP.TabIndex = 2;
            this.ptbAnhSP.TabStop = false;
            this.ptbAnhSP.Click += new System.EventHandler(this.ptbAnhSP_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(26, 437);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(331, 24);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(26, 375);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(331, 24);
            this.txtGiaBan.TabIndex = 1;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(26, 315);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(331, 24);
            this.txtGiaNhap.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(26, 259);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(331, 24);
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(26, 207);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(331, 24);
            this.txtMa.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ma";
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Anh";
            this.Column2.HeaderText = "Ảnh";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ten";
            this.Column3.HeaderText = "Tên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GiaNhap";
            this.Column4.HeaderText = "Giá nhập";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GiaBan";
            this.Column5.HeaderText = "Giá bán";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoLuong";
            this.Column6.HeaderText = "Số lượng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Nsx";
            this.Column7.HeaderText = "Nhà sản xuất";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "LoaiHang";
            this.Column8.HeaderText = "Loại hàng";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 125;
            // 
            // Frm_QLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 704);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_QLSP";
            this.Text = "Frm_QLSP";
            this.Load += new System.EventHandler(this.Frm_QLSP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.btnXoa.ResumeLayout(false);
            this.btnXoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox btnXoa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbLoaiSP;
        private System.Windows.Forms.ComboBox cbbNsx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label btnQLNSX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbAnhSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label btnQLLH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}