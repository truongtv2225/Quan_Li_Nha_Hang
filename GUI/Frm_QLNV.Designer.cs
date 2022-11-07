namespace GUI
{
    partial class Frm_QLNV
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
            this.btnChucVu = new System.Windows.Forms.Button();
            this.btnDsVhh = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnDs = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVoHieu = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ptbAnh = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbCV = new System.Windows.Forms.ComboBox();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.btnChucVu);
            this.groupBox1.Controls.Add(this.btnDsVhh);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btnDs);
            this.groupBox1.Controls.Add(this.dgvNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(1, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1130, 495);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // btnChucVu
            // 
            this.btnChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChucVu.Location = new System.Drawing.Point(966, 414);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(144, 41);
            this.btnChucVu.TabIndex = 3;
            this.btnChucVu.Text = "Chức vụ";
            this.btnChucVu.UseVisualStyleBackColor = false;
            this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // btnDsVhh
            // 
            this.btnDsVhh.AutoSize = true;
            this.btnDsVhh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDsVhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDsVhh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDsVhh.Location = new System.Drawing.Point(200, 25);
            this.btnDsVhh.Name = "btnDsVhh";
            this.btnDsVhh.Size = new System.Drawing.Size(121, 18);
            this.btnDsVhh.TabIndex = 2;
            this.btnDsVhh.Text = "Đã vô hiệu hóa";
            this.btnDsVhh.Click += new System.EventHandler(this.btnDsVhh_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(931, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(193, 24);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnDs
            // 
            this.btnDs.AutoSize = true;
            this.btnDs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDs.Location = new System.Drawing.Point(7, 25);
            this.btnDs.Name = "btnDs";
            this.btnDs.Size = new System.Drawing.Size(164, 18);
            this.btnDs.TabIndex = 2;
            this.btnDs.Text = "Danh sách nhân viên";
            this.btnDs.Click += new System.EventHandler(this.btnDs_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6,
            this.cbbChucVu});
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(6, 46);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1118, 443);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Ma";
            this.Column8.HeaderText = "Mã";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Anh";
            this.Column1.HeaderText = "Ảnh";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 85;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgaySinh";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DiaChi";
            this.Column7.HeaderText = "Địa chỉ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenDangNhap";
            this.Column5.HeaderText = "Tên đăng nhập";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MatKhau";
            this.Column6.HeaderText = "Mật khẩu";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.DataPropertyName = "TenChucVu";
            this.cbbChucVu.HeaderText = "Chức vụ";
            this.cbbChucVu.MinimumWidth = 6;
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.ReadOnly = true;
            this.cbbChucVu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbbChucVu.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.btnVoHieu);
            this.groupBox2.Controls.Add(this.btnKhoiPhuc);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ptbAnh);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbbCV);
            this.groupBox2.Controls.Add(this.txtNgaySinh);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMa);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.txtMatKhau);
            this.groupBox2.Controls.Add(this.txtTenDangNhap);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(1, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1130, 211);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnVoHieu
            // 
            this.btnVoHieu.BackColor = System.Drawing.Color.Red;
            this.btnVoHieu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnVoHieu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoHieu.Location = new System.Drawing.Point(884, 59);
            this.btnVoHieu.Name = "btnVoHieu";
            this.btnVoHieu.Size = new System.Drawing.Size(145, 50);
            this.btnVoHieu.TabIndex = 7;
            this.btnVoHieu.Text = "Vô hiệu";
            this.btnVoHieu.UseVisualStyleBackColor = false;
            this.btnVoHieu.Click += new System.EventHandler(this.btnVoHieu_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.Gray;
            this.btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(884, 59);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(145, 50);
            this.btnKhoiPhuc.TabIndex = 7;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(965, 119);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(145, 50);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(804, 119);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(145, 50);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(620, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Chọn ảnh";
            // 
            // ptbAnh
            // 
            this.ptbAnh.Location = new System.Drawing.Point(617, 48);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.Size = new System.Drawing.Size(143, 156);
            this.ptbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAnh.TabIndex = 6;
            this.ptbAnh.TabStop = false;
            this.ptbAnh.Click += new System.EventHandler(this.ptbAnh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Chức vụ";
            // 
            // cbbCV
            // 
            this.cbbCV.FormattingEnabled = true;
            this.cbbCV.Location = new System.Drawing.Point(168, 170);
            this.cbbCV.Name = "cbbCV";
            this.cbbCV.Size = new System.Drawing.Size(143, 26);
            this.cbbCV.TabIndex = 4;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaySinh.Location = new System.Drawing.Point(16, 172);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(140, 24);
            this.txtNgaySinh.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(16, 108);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(593, 30);
            this.txtDiaChi.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Năm sinh";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMa.Location = new System.Drawing.Point(16, 48);
            this.txtMa.Multiline = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(143, 30);
            this.txtMa.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giới tính";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnNu);
            this.panel1.Controls.Add(this.rbtnNam);
            this.panel1.Location = new System.Drawing.Point(315, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 30);
            this.panel1.TabIndex = 1;
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(73, 5);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(50, 22);
            this.rbtnNu.TabIndex = 0;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(3, 5);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(64, 22);
            this.rbtnNam.TabIndex = 0;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(318, 170);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(143, 26);
            this.txtMatKhau.TabIndex = 0;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(466, 48);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(143, 30);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Location = new System.Drawing.Point(166, 48);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(143, 30);
            this.txtTen.TabIndex = 0;
            // 
            // Frm_QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1132, 704);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_QLNV";
            this.Text = "Frm_QLNV";
            this.Load += new System.EventHandler(this.Frm_QLNV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.PictureBox ptbAnh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbCV;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label btnDsVhh;
        private System.Windows.Forms.Label btnDs;
        private System.Windows.Forms.Button btnVoHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbbChucVu;
        private System.Windows.Forms.Button btnChucVu;
    }
}