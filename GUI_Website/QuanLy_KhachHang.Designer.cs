namespace GUI_Website
{
    partial class QuanLy_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy_KhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DanhSach_KH = new System.Windows.Forms.DataGridView();
            this.col_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_DoThanThiet = new System.Windows.Forms.ComboBox();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_MatKhauKH = new System.Windows.Forms.TextBox();
            this.txt_SĐT = new System.Windows.Forms.TextBox();
            this.rdo_Nu = new System.Windows.Forms.RadioButton();
            this.rdo_Nam = new System.Windows.Forms.RadioButton();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SuaKH = new System.Windows.Forms.Button();
            this.btn_XoaKH = new System.Windows.Forms.Button();
            this.btn_ThemKH = new System.Windows.Forms.Button();
            this.txt_NhapThongTin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ccbx_TimKiemKH = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach_KH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(475, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ KHÁCH HÀNG";
            // 
            // dgv_DanhSach_KH
            // 
            this.dgv_DanhSach_KH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSach_KH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSach_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach_KH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaKH,
            this.col_TenKH,
            this.col_Gender,
            this.col_SDT,
            this.col_DiaChi,
            this.col_MatKhau,
            this.col_Status,
            this.ROLE});
            this.dgv_DanhSach_KH.Location = new System.Drawing.Point(22, 103);
            this.dgv_DanhSach_KH.Name = "dgv_DanhSach_KH";
            this.dgv_DanhSach_KH.RowHeadersWidth = 51;
            this.dgv_DanhSach_KH.RowTemplate.Height = 24;
            this.dgv_DanhSach_KH.Size = new System.Drawing.Size(936, 564);
            this.dgv_DanhSach_KH.TabIndex = 1;
            this.dgv_DanhSach_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_KH_CellClick);
            // 
            // col_MaKH
            // 
            this.col_MaKH.DataPropertyName = "MAKH";
            this.col_MaKH.HeaderText = "Mã KH";
            this.col_MaKH.MinimumWidth = 6;
            this.col_MaKH.Name = "col_MaKH";
            this.col_MaKH.ReadOnly = true;
            // 
            // col_TenKH
            // 
            this.col_TenKH.DataPropertyName = "TENKH";
            this.col_TenKH.HeaderText = "Tên Khách Hàng";
            this.col_TenKH.MinimumWidth = 6;
            this.col_TenKH.Name = "col_TenKH";
            this.col_TenKH.ReadOnly = true;
            // 
            // col_Gender
            // 
            this.col_Gender.DataPropertyName = "GIOITINH";
            this.col_Gender.HeaderText = "Giới Tính";
            this.col_Gender.MinimumWidth = 6;
            this.col_Gender.Name = "col_Gender";
            this.col_Gender.ReadOnly = true;
            // 
            // col_SDT
            // 
            this.col_SDT.DataPropertyName = "SDT";
            this.col_SDT.HeaderText = "SĐT";
            this.col_SDT.MinimumWidth = 6;
            this.col_SDT.Name = "col_SDT";
            this.col_SDT.ReadOnly = true;
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.DataPropertyName = "DIACHI";
            this.col_DiaChi.HeaderText = "Địa chỉ";
            this.col_DiaChi.MinimumWidth = 6;
            this.col_DiaChi.Name = "col_DiaChi";
            this.col_DiaChi.ReadOnly = true;
            // 
            // col_MatKhau
            // 
            this.col_MatKhau.DataPropertyName = "MATKHAUKH";
            this.col_MatKhau.HeaderText = "Mật Khẩu";
            this.col_MatKhau.MinimumWidth = 6;
            this.col_MatKhau.Name = "col_MatKhau";
            this.col_MatKhau.ReadOnly = true;
            // 
            // col_Status
            // 
            this.col_Status.DataPropertyName = "TRANGTHAI";
            this.col_Status.HeaderText = "Trạng Thái";
            this.col_Status.MinimumWidth = 6;
            this.col_Status.Name = "col_Status";
            // 
            // ROLE
            // 
            this.ROLE.DataPropertyName = "ROLE";
            this.ROLE.HeaderText = "Độ Thân Thiết";
            this.ROLE.MinimumWidth = 6;
            this.ROLE.Name = "ROLE";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.cbx_DoThanThiet);
            this.groupBox1.Controls.Add(this.txt_TrangThai);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.txt_MatKhauKH);
            this.groupBox1.Controls.Add(this.txt_SĐT);
            this.groupBox1.Controls.Add(this.rdo_Nu);
            this.groupBox1.Controls.Add(this.rdo_Nam);
            this.groupBox1.Controls.Add(this.txt_MaKH);
            this.groupBox1.Controls.Add(this.txt_TenKH);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(964, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 564);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng:";
            // 
            // cbx_DoThanThiet
            // 
            this.cbx_DoThanThiet.FormattingEnabled = true;
            this.cbx_DoThanThiet.Location = new System.Drawing.Point(167, 316);
            this.cbx_DoThanThiet.Name = "cbx_DoThanThiet";
            this.cbx_DoThanThiet.Size = new System.Drawing.Size(219, 27);
            this.cbx_DoThanThiet.TabIndex = 16;
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Location = new System.Drawing.Point(167, 264);
            this.txt_TrangThai.Multiline = true;
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(219, 31);
            this.txt_TrangThai.TabIndex = 15;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(89, 394);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(297, 164);
            this.txt_DiaChi.TabIndex = 14;
            // 
            // txt_MatKhauKH
            // 
            this.txt_MatKhauKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_MatKhauKH.Location = new System.Drawing.Point(167, 222);
            this.txt_MatKhauKH.Multiline = true;
            this.txt_MatKhauKH.Name = "txt_MatKhauKH";
            this.txt_MatKhauKH.Size = new System.Drawing.Size(219, 31);
            this.txt_MatKhauKH.TabIndex = 13;
            // 
            // txt_SĐT
            // 
            this.txt_SĐT.Location = new System.Drawing.Point(167, 173);
            this.txt_SĐT.Multiline = true;
            this.txt_SĐT.Name = "txt_SĐT";
            this.txt_SĐT.Size = new System.Drawing.Size(219, 31);
            this.txt_SĐT.TabIndex = 12;
            // 
            // rdo_Nu
            // 
            this.rdo_Nu.AutoSize = true;
            this.rdo_Nu.Location = new System.Drawing.Point(289, 140);
            this.rdo_Nu.Name = "rdo_Nu";
            this.rdo_Nu.Size = new System.Drawing.Size(52, 23);
            this.rdo_Nu.TabIndex = 11;
            this.rdo_Nu.TabStop = true;
            this.rdo_Nu.Text = "Nữ";
            this.rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // rdo_Nam
            // 
            this.rdo_Nam.AutoSize = true;
            this.rdo_Nam.Checked = true;
            this.rdo_Nam.Location = new System.Drawing.Point(167, 140);
            this.rdo_Nam.Name = "rdo_Nam";
            this.rdo_Nam.Size = new System.Drawing.Size(64, 23);
            this.rdo_Nam.TabIndex = 10;
            this.rdo_Nam.TabStop = true;
            this.rdo_Nam.Text = "Nam";
            this.rdo_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(167, 41);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(219, 27);
            this.txt_MaKH.TabIndex = 9;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(167, 88);
            this.txt_TenKH.Multiline = true;
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(219, 31);
            this.txt_TenKH.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Độ Thân Thiết:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Trạng Thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mật Khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới Tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KH:";
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QuayLai.BackgroundImage = global::GUI_Website.Properties.Resources.back;
            this.btn_QuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_QuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_QuayLai.ForeColor = System.Drawing.Color.Red;
            this.btn_QuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuayLai.ImageKey = "logout.png";
            this.btn_QuayLai.ImageList = this.imageList1;
            this.btn_QuayLai.Location = new System.Drawing.Point(1112, 22);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(137, 50);
            this.btn_QuayLai.TabIndex = 3;
            this.btn_QuayLai.Text = "Quay Lại";
            this.btn_QuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "edit.png");
            this.imageList1.Images.SetKeyName(3, "logout.png");
            this.imageList1.Images.SetKeyName(4, "off.png");
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Red;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.ImageIndex = 4;
            this.btn_Thoat.ImageList = this.imageList1;
            this.btn_Thoat.Location = new System.Drawing.Point(1255, 22);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(101, 50);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.btn_SuaKH);
            this.groupBox2.Controls.Add(this.btn_XoaKH);
            this.groupBox2.Controls.Add(this.btn_ThemKH);
            this.groupBox2.Controls.Add(this.txt_NhapThongTin);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ccbx_TimKiemKH);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(22, 673);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1334, 134);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm thông tin:";
            // 
            // btn_SuaKH
            // 
            this.btn_SuaKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaKH.ImageIndex = 3;
            this.btn_SuaKH.ImageList = this.imageList1;
            this.btn_SuaKH.Location = new System.Drawing.Point(1218, 17);
            this.btn_SuaKH.Name = "btn_SuaKH";
            this.btn_SuaKH.Size = new System.Drawing.Size(96, 42);
            this.btn_SuaKH.TabIndex = 22;
            this.btn_SuaKH.Text = "Sửa";
            this.btn_SuaKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SuaKH.UseVisualStyleBackColor = true;
            this.btn_SuaKH.Click += new System.EventHandler(this.btn_SuaKH_Click);
            // 
            // btn_XoaKH
            // 
            this.btn_XoaKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XoaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaKH.ImageIndex = 2;
            this.btn_XoaKH.ImageList = this.imageList1;
            this.btn_XoaKH.Location = new System.Drawing.Point(1109, 17);
            this.btn_XoaKH.Name = "btn_XoaKH";
            this.btn_XoaKH.Size = new System.Drawing.Size(98, 42);
            this.btn_XoaKH.TabIndex = 21;
            this.btn_XoaKH.Text = "Xóa";
            this.btn_XoaKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaKH.UseVisualStyleBackColor = true;
            this.btn_XoaKH.Click += new System.EventHandler(this.btn_XoaKH_Click);
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThemKH.BackgroundImage = global::GUI_Website.Properties.Resources.add;
            this.btn_ThemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ThemKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemKH.ImageKey = "add.png";
            this.btn_ThemKH.ImageList = this.imageList1;
            this.btn_ThemKH.Location = new System.Drawing.Point(981, 17);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(111, 42);
            this.btn_ThemKH.TabIndex = 20;
            this.btn_ThemKH.Text = "Thêm";
            this.btn_ThemKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemKH.UseVisualStyleBackColor = true;
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
            // 
            // txt_NhapThongTin
            // 
            this.txt_NhapThongTin.Location = new System.Drawing.Point(562, 32);
            this.txt_NhapThongTin.Multiline = true;
            this.txt_NhapThongTin.Name = "txt_NhapThongTin";
            this.txt_NhapThongTin.Size = new System.Drawing.Size(168, 31);
            this.txt_NhapThongTin.TabIndex = 17;
            this.txt_NhapThongTin.TextChanged += new System.EventHandler(this.txt_NhapThongTin_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(378, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Nhập Thông tin:";
            // 
            // ccbx_TimKiemKH
            // 
            this.ccbx_TimKiemKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbx_TimKiemKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ccbx_TimKiemKH.FormattingEnabled = true;
            this.ccbx_TimKiemKH.Location = new System.Drawing.Point(190, 32);
            this.ccbx_TimKiemKH.Name = "ccbx_TimKiemKH";
            this.ccbx_TimKiemKH.Size = new System.Drawing.Size(121, 27);
            this.ccbx_TimKiemKH.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tìm kiếm theo:";
            // 
            // QuanLy_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::GUI_Website.Properties.Resources.freepik__adjust__351271;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 810);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_DanhSach_KH);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "QuanLy_KhachHang";
            this.Text = "QuanLy_KhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLy_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach_KH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DanhSach_KH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_DoThanThiet;
        private System.Windows.Forms.TextBox txt_TrangThai;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_MatKhauKH;
        private System.Windows.Forms.TextBox txt_SĐT;
        private System.Windows.Forms.RadioButton rdo_Nu;
        private System.Windows.Forms.RadioButton rdo_Nam;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_SuaKH;
        private System.Windows.Forms.Button btn_XoaKH;
        private System.Windows.Forms.Button btn_ThemKH;
        private System.Windows.Forms.TextBox txt_NhapThongTin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ccbx_TimKiemKH;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Status;
        private System.Windows.Forms.DataGridViewComboBoxColumn ROLE;
    }
}