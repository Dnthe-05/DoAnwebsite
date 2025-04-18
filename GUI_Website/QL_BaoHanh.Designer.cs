namespace GUI_Website
{
    partial class QL_BaoHanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_BaoHanh));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DanhSachBaoHanh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_DieuKienBH = new System.Windows.Forms.ComboBox();
            this.dtpc_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpc_NgayBD = new System.Windows.Forms.DateTimePicker();
            this.txt_TimeBH = new System.Windows.Forms.TextBox();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.txt_MaBH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_NhapThongTin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_TimKiem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.col_MaBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DieuKien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachBaoHanh)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(417, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ BẢO HÀNH";
            // 
            // dgv_DanhSachBaoHanh
            // 
            this.dgv_DanhSachBaoHanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachBaoHanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachBaoHanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaBH,
            this.col_MaSP,
            this.col_ThoiGian,
            this.col_DieuKien,
            this.col_NgayBD,
            this.col_NgayKT});
            this.dgv_DanhSachBaoHanh.Location = new System.Drawing.Point(10, 112);
            this.dgv_DanhSachBaoHanh.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_DanhSachBaoHanh.Name = "dgv_DanhSachBaoHanh";
            this.dgv_DanhSachBaoHanh.RowHeadersWidth = 51;
            this.dgv_DanhSachBaoHanh.RowTemplate.Height = 24;
            this.dgv_DanhSachBaoHanh.Size = new System.Drawing.Size(805, 478);
            this.dgv_DanhSachBaoHanh.TabIndex = 1;
            this.dgv_DanhSachBaoHanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachBaoHanh_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbx_DieuKienBH);
            this.groupBox1.Controls.Add(this.dtpc_NgayKT);
            this.groupBox1.Controls.Add(this.dtpc_NgayBD);
            this.groupBox1.Controls.Add(this.txt_TimeBH);
            this.groupBox1.Controls.Add(this.txt_MaSP);
            this.groupBox1.Controls.Add(this.txt_MaBH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(817, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(340, 478);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbx_DieuKienBH
            // 
            this.cbx_DieuKienBH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_DieuKienBH.FormattingEnabled = true;
            this.cbx_DieuKienBH.Location = new System.Drawing.Point(142, 203);
            this.cbx_DieuKienBH.Name = "cbx_DieuKienBH";
            this.cbx_DieuKienBH.Size = new System.Drawing.Size(177, 27);
            this.cbx_DieuKienBH.TabIndex = 12;
            // 
            // dtpc_NgayKT
            // 
            this.dtpc_NgayKT.Location = new System.Drawing.Point(141, 309);
            this.dtpc_NgayKT.Name = "dtpc_NgayKT";
            this.dtpc_NgayKT.Size = new System.Drawing.Size(178, 27);
            this.dtpc_NgayKT.TabIndex = 11;
            // 
            // dtpc_NgayBD
            // 
            this.dtpc_NgayBD.Location = new System.Drawing.Point(142, 257);
            this.dtpc_NgayBD.Name = "dtpc_NgayBD";
            this.dtpc_NgayBD.Size = new System.Drawing.Size(177, 27);
            this.dtpc_NgayBD.TabIndex = 10;
            // 
            // txt_TimeBH
            // 
            this.txt_TimeBH.Location = new System.Drawing.Point(141, 148);
            this.txt_TimeBH.Name = "txt_TimeBH";
            this.txt_TimeBH.Size = new System.Drawing.Size(178, 27);
            this.txt_TimeBH.TabIndex = 8;
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(142, 93);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(177, 27);
            this.txt_MaSP.TabIndex = 7;
            // 
            // txt_MaBH
            // 
            this.txt_MaBH.Location = new System.Drawing.Point(141, 42);
            this.txt_MaBH.Name = "txt_MaBH";
            this.txt_MaBH.Size = new System.Drawing.Size(178, 27);
            this.txt_MaBH.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày KT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày BĐ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điều kiện BH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời gian BH:\r\n(tháng)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã SP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã BH:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_NhapThongTin);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbx_TimKiem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(10, 592);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(1147, 108);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // txt_NhapThongTin
            // 
            this.txt_NhapThongTin.Location = new System.Drawing.Point(585, 22);
            this.txt_NhapThongTin.Name = "txt_NhapThongTin";
            this.txt_NhapThongTin.Size = new System.Drawing.Size(163, 27);
            this.txt_NhapThongTin.TabIndex = 6;
            this.txt_NhapThongTin.TextChanged += new System.EventHandler(this.txt_NhapThongTin_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nhập thông tin:";
            // 
            // cbx_TimKiem
            // 
            this.cbx_TimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_TimKiem.FormattingEnabled = true;
            this.cbx_TimKiem.Location = new System.Drawing.Point(242, 22);
            this.cbx_TimKiem.Name = "cbx_TimKiem";
            this.cbx_TimKiem.Size = new System.Drawing.Size(161, 27);
            this.cbx_TimKiem.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tìm kiếm theo:";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Red;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.ImageIndex = 2;
            this.btn_Sua.ImageList = this.imageList1;
            this.btn_Sua.Location = new System.Drawing.Point(1032, 12);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 44);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "edit.png");
            this.imageList1.Images.SetKeyName(3, "log-out.png");
            this.imageList1.Images.SetKeyName(4, "off.png");
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.ForeColor = System.Drawing.Color.Red;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.ImageIndex = 0;
            this.btn_Them.ImageList = this.imageList1;
            this.btn_Them.Location = new System.Drawing.Point(918, 12);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 44);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_QuayLai.ForeColor = System.Drawing.Color.Red;
            this.btn_QuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuayLai.ImageIndex = 3;
            this.btn_QuayLai.ImageList = this.imageList1;
            this.btn_QuayLai.Location = new System.Drawing.Point(911, 22);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(94, 44);
            this.btn_QuayLai.TabIndex = 3;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Red;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.ImageIndex = 4;
            this.btn_Thoat.ImageList = this.imageList1;
            this.btn_Thoat.Location = new System.Drawing.Point(1027, 20);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(94, 44);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // col_MaBH
            // 
            this.col_MaBH.DataPropertyName = "MABH";
            this.col_MaBH.HeaderText = "Mã BH";
            this.col_MaBH.MinimumWidth = 6;
            this.col_MaBH.Name = "col_MaBH";
            this.col_MaBH.ReadOnly = true;
            // 
            // col_MaSP
            // 
            this.col_MaSP.DataPropertyName = "MASP";
            this.col_MaSP.HeaderText = "Mã SP";
            this.col_MaSP.MinimumWidth = 6;
            this.col_MaSP.Name = "col_MaSP";
            this.col_MaSP.ReadOnly = true;
            // 
            // col_ThoiGian
            // 
            this.col_ThoiGian.DataPropertyName = "THOIGIAN";
            this.col_ThoiGian.HeaderText = "Thời Gian BH (tháng)";
            this.col_ThoiGian.MinimumWidth = 6;
            this.col_ThoiGian.Name = "col_ThoiGian";
            this.col_ThoiGian.ReadOnly = true;
            // 
            // col_DieuKien
            // 
            this.col_DieuKien.DataPropertyName = "DIEUKIEN";
            this.col_DieuKien.HeaderText = "Điều Kiện BH";
            this.col_DieuKien.MinimumWidth = 6;
            this.col_DieuKien.Name = "col_DieuKien";
            this.col_DieuKien.ReadOnly = true;
            // 
            // col_NgayBD
            // 
            this.col_NgayBD.DataPropertyName = "NGAYBATDAU";
            this.col_NgayBD.HeaderText = "Ngày bắt đầu";
            this.col_NgayBD.MinimumWidth = 6;
            this.col_NgayBD.Name = "col_NgayBD";
            // 
            // col_NgayKT
            // 
            this.col_NgayKT.DataPropertyName = "NGAYHETHAN";
            this.col_NgayKT.HeaderText = "Ngày hết hạn";
            this.col_NgayKT.MinimumWidth = 6;
            this.col_NgayKT.Name = "col_NgayKT";
            // 
            // QL_BaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_Website.Properties.Resources.freepik__adjust__351275;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 746);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_DanhSachBaoHanh);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QL_BaoHanh";
            this.Text = "QL_BaoHanh";
            this.Load += new System.EventHandler(this.QL_BaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachBaoHanh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DanhSachBaoHanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DateTimePicker dtpc_NgayBD;
        private System.Windows.Forms.TextBox txt_TimeBH;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_MaBH;
        private System.Windows.Forms.TextBox txt_NhapThongTin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_TimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpc_NgayKT;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbx_DieuKienBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThoiGian;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_DieuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayKT;
    }
}