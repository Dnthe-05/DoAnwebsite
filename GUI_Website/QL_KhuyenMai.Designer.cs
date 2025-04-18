namespace GUI_Website
{
    partial class QL_KhuyenMai
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_KhuyenMai));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DanhSachKhuyenMai = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpc_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpc_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.cbx_LoaiKM = new System.Windows.Forms.ComboBox();
            this.txt_GiamGia = new System.Windows.Forms.TextBox();
            this.txt_TenKM = new System.Windows.Forms.TextBox();
            this.txt_MaKM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_NhapThongTin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_TimKiem = new System.Windows.Forms.ComboBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.col_MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LoaiKM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhuyenMai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(430, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ KHUYẾN MÃI";
            // 
            // dgv_DanhSachKhuyenMai
            // 
            this.dgv_DanhSachKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaKM,
            this.col_TenKM,
            this.col_GiamGia,
            this.col_LoaiKM,
            this.col_NgayBD,
            this.col_NgayKT});
            this.dgv_DanhSachKhuyenMai.Location = new System.Drawing.Point(23, 92);
            this.dgv_DanhSachKhuyenMai.Name = "dgv_DanhSachKhuyenMai";
            this.dgv_DanhSachKhuyenMai.RowHeadersWidth = 51;
            this.dgv_DanhSachKhuyenMai.RowTemplate.Height = 24;
            this.dgv_DanhSachKhuyenMai.Size = new System.Drawing.Size(840, 405);
            this.dgv_DanhSachKhuyenMai.TabIndex = 1;
            this.dgv_DanhSachKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachKhuyenMai_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtpc_NgayKT);
            this.groupBox1.Controls.Add(this.dtpc_NgayBD);
            this.groupBox1.Controls.Add(this.cbx_LoaiKM);
            this.groupBox1.Controls.Add(this.txt_GiamGia);
            this.groupBox1.Controls.Add(this.txt_TenKM);
            this.groupBox1.Controls.Add(this.txt_MaKM);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(870, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 405);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dtpc_NgayKT
            // 
            this.dtpc_NgayKT.Location = new System.Drawing.Point(151, 312);
            this.dtpc_NgayKT.Name = "dtpc_NgayKT";
            this.dtpc_NgayKT.Size = new System.Drawing.Size(174, 27);
            this.dtpc_NgayKT.TabIndex = 11;
            // 
            // dtpc_NgayBD
            // 
            this.dtpc_NgayBD.Location = new System.Drawing.Point(151, 258);
            this.dtpc_NgayBD.Name = "dtpc_NgayBD";
            this.dtpc_NgayBD.Size = new System.Drawing.Size(174, 27);
            this.dtpc_NgayBD.TabIndex = 10;
            // 
            // cbx_LoaiKM
            // 
            this.cbx_LoaiKM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_LoaiKM.FormattingEnabled = true;
            this.cbx_LoaiKM.Location = new System.Drawing.Point(151, 207);
            this.cbx_LoaiKM.Name = "cbx_LoaiKM";
            this.cbx_LoaiKM.Size = new System.Drawing.Size(174, 27);
            this.cbx_LoaiKM.TabIndex = 9;
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.Location = new System.Drawing.Point(151, 150);
            this.txt_GiamGia.Multiline = true;
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.Size = new System.Drawing.Size(174, 25);
            this.txt_GiamGia.TabIndex = 8;
            // 
            // txt_TenKM
            // 
            this.txt_TenKM.Location = new System.Drawing.Point(151, 92);
            this.txt_TenKM.Multiline = true;
            this.txt_TenKM.Name = "txt_TenKM";
            this.txt_TenKM.Size = new System.Drawing.Size(174, 25);
            this.txt_TenKM.TabIndex = 7;
            // 
            // txt_MaKM
            // 
            this.txt_MaKM.Location = new System.Drawing.Point(151, 39);
            this.txt_MaKM.Multiline = true;
            this.txt_MaKM.Name = "txt_MaKM";
            this.txt_MaKM.Size = new System.Drawing.Size(174, 25);
            this.txt_MaKM.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày KT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày BĐ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại KM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giảm giá:\r\n(\'%\' hoặc \'VND\')\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên KM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KM:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_NhapThongTin);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbx_TimKiem);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 503);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1189, 136);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // txt_NhapThongTin
            // 
            this.txt_NhapThongTin.Location = new System.Drawing.Point(516, 45);
            this.txt_NhapThongTin.Name = "txt_NhapThongTin";
            this.txt_NhapThongTin.Size = new System.Drawing.Size(179, 27);
            this.txt_NhapThongTin.TabIndex = 6;
            this.txt_NhapThongTin.TextChanged += new System.EventHandler(this.txt_NhapThongTin_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nhập thông tin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tìm kiếm theo: ";
            // 
            // cbx_TimKiem
            // 
            this.cbx_TimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_TimKiem.FormattingEnabled = true;
            this.cbx_TimKiem.Location = new System.Drawing.Point(167, 45);
            this.cbx_TimKiem.Name = "cbx_TimKiem";
            this.cbx_TimKiem.Size = new System.Drawing.Size(179, 27);
            this.cbx_TimKiem.TabIndex = 3;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.ImageIndex = 2;
            this.btn_Xoa.ImageList = this.imageList1;
            this.btn_Xoa.Location = new System.Drawing.Point(1065, 48);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(107, 45);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "back.png");
            this.imageList1.Images.SetKeyName(2, "delete.png");
            this.imageList1.Images.SetKeyName(3, "edit.png");
            this.imageList1.Images.SetKeyName(4, "off.png");
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Red;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.ImageIndex = 3;
            this.btn_Sua.ImageList = this.imageList1;
            this.btn_Sua.Location = new System.Drawing.Point(921, 48);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(107, 45);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.ForeColor = System.Drawing.Color.Red;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.ImageIndex = 0;
            this.btn_Them.ImageList = this.imageList1;
            this.btn_Them.Location = new System.Drawing.Point(779, 48);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(107, 45);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_QuayLai.ForeColor = System.Drawing.Color.Red;
            this.btn_QuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuayLai.ImageIndex = 1;
            this.btn_QuayLai.ImageList = this.imageList1;
            this.btn_QuayLai.Location = new System.Drawing.Point(957, 31);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(107, 45);
            this.btn_QuayLai.TabIndex = 3;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Red;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.ImageIndex = 4;
            this.btn_Thoat.ImageList = this.imageList1;
            this.btn_Thoat.Location = new System.Drawing.Point(1088, 30);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(107, 45);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // col_MaKM
            // 
            this.col_MaKM.DataPropertyName = "MAKM";
            this.col_MaKM.HeaderText = "Mã KM";
            this.col_MaKM.MinimumWidth = 6;
            this.col_MaKM.Name = "col_MaKM";
            this.col_MaKM.ReadOnly = true;
            // 
            // col_TenKM
            // 
            this.col_TenKM.DataPropertyName = "TENKM";
            this.col_TenKM.HeaderText = "Tên KM";
            this.col_TenKM.MinimumWidth = 6;
            this.col_TenKM.Name = "col_TenKM";
            this.col_TenKM.ReadOnly = true;
            // 
            // col_GiamGia
            // 
            this.col_GiamGia.DataPropertyName = "GIAMGIA";
            this.col_GiamGia.HeaderText = "Giảm giá   (\'%\' hoặc \'VND\')";
            this.col_GiamGia.MinimumWidth = 6;
            this.col_GiamGia.Name = "col_GiamGia";
            this.col_GiamGia.ReadOnly = true;
            // 
            // col_LoaiKM
            // 
            this.col_LoaiKM.DataPropertyName = "LOAIKM";
            this.col_LoaiKM.HeaderText = "Loại KM";
            this.col_LoaiKM.MinimumWidth = 6;
            this.col_LoaiKM.Name = "col_LoaiKM";
            this.col_LoaiKM.ReadOnly = true;
            this.col_LoaiKM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_LoaiKM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_NgayBD
            // 
            this.col_NgayBD.DataPropertyName = "NGAYBATDAU";
            this.col_NgayBD.HeaderText = "Ngày bắt đầu";
            this.col_NgayBD.MinimumWidth = 6;
            this.col_NgayBD.Name = "col_NgayBD";
            this.col_NgayBD.ReadOnly = true;
            // 
            // col_NgayKT
            // 
            this.col_NgayKT.DataPropertyName = "NGAYKETTHUC";
            this.col_NgayKT.HeaderText = "Ngày kết thúc";
            this.col_NgayKT.MinimumWidth = 6;
            this.col_NgayKT.Name = "col_NgayKT";
            this.col_NgayKT.ReadOnly = true;
            // 
            // QL_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_Website.Properties.Resources.freepik__adjust__351276;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 725);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_DanhSachKhuyenMai);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "QL_KhuyenMai";
            this.Text = "QL_KhuyenMai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QL_KhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhuyenMai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DanhSachKhuyenMai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpc_NgayKT;
        private System.Windows.Forms.DateTimePicker dtpc_NgayBD;
        private System.Windows.Forms.ComboBox cbx_LoaiKM;
        private System.Windows.Forms.TextBox txt_GiamGia;
        private System.Windows.Forms.TextBox txt_TenKM;
        private System.Windows.Forms.TextBox txt_MaKM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_TimKiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_NhapThongTin;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GiamGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_LoaiKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayKT;
    }
}