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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DanhSach_KH = new System.Windows.Forms.DataGridView();
            this.col_MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_role = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach_KH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(419, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ KHÁCH HÀNG";
            // 
            // dgv_DanhSach_KH
            // 
            this.dgv_DanhSach_KH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSach_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach_KH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaKH,
            this.col_TenKH,
            this.col_Gender,
            this.col_SDT,
            this.col_DiaChi,
            this.col_MatKhau,
            this.col_TrangThai,
            this.col_role});
            this.dgv_DanhSach_KH.Location = new System.Drawing.Point(22, 103);
            this.dgv_DanhSach_KH.Name = "dgv_DanhSach_KH";
            this.dgv_DanhSach_KH.RowHeadersWidth = 51;
            this.dgv_DanhSach_KH.RowTemplate.Height = 24;
            this.dgv_DanhSach_KH.Size = new System.Drawing.Size(936, 453);
            this.dgv_DanhSach_KH.TabIndex = 1;
            // 
            // col_MaKH
            // 
            this.col_MaKH.HeaderText = "Mã KH";
            this.col_MaKH.MinimumWidth = 6;
            this.col_MaKH.Name = "col_MaKH";
            this.col_MaKH.ReadOnly = true;
            // 
            // col_TenKH
            // 
            this.col_TenKH.HeaderText = "Tên Khách Hàng";
            this.col_TenKH.MinimumWidth = 6;
            this.col_TenKH.Name = "col_TenKH";
            this.col_TenKH.ReadOnly = true;
            // 
            // col_Gender
            // 
            this.col_Gender.HeaderText = "Giới Tính";
            this.col_Gender.MinimumWidth = 6;
            this.col_Gender.Name = "col_Gender";
            this.col_Gender.ReadOnly = true;
            // 
            // col_SDT
            // 
            this.col_SDT.HeaderText = "SĐT";
            this.col_SDT.MinimumWidth = 6;
            this.col_SDT.Name = "col_SDT";
            this.col_SDT.ReadOnly = true;
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.HeaderText = "Địa chỉ";
            this.col_DiaChi.MinimumWidth = 6;
            this.col_DiaChi.Name = "col_DiaChi";
            this.col_DiaChi.ReadOnly = true;
            // 
            // col_MatKhau
            // 
            this.col_MatKhau.HeaderText = "Mật Khẩu";
            this.col_MatKhau.MinimumWidth = 6;
            this.col_MatKhau.Name = "col_MatKhau";
            this.col_MatKhau.ReadOnly = true;
            // 
            // col_TrangThai
            // 
            this.col_TrangThai.HeaderText = "Trạng Thái";
            this.col_TrangThai.MinimumWidth = 6;
            this.col_TrangThai.Name = "col_TrangThai";
            this.col_TrangThai.ReadOnly = true;
            // 
            // col_role
            // 
            this.col_role.HeaderText = "Độ Thân Thiết";
            this.col_role.MinimumWidth = 6;
            this.col_role.Name = "col_role";
            this.col_role.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(964, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 453);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KH:";
            // 
            // QuanLy_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_Website.Properties.Resources.freepik__adjust__351271;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1311, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_DanhSach_KH);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "QuanLy_KhachHang";
            this.Text = "QuanLy_KhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach_KH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DanhSach_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TrangThai;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_role;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}