using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Website
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            QL_NhapHang newform = new QL_NhapHang();
            newform.Show();
            this.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DangNhap loginForm = new DangNhap();
                loginForm.Show();

                this.Close(); 

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLy_NhanVien newform = new QuanLy_NhanVien();
            newform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLy_KhachHang newform = new QuanLy_KhachHang();
            newform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLy_SanPham newform = new QuanLy_SanPham();
            newform.Show();
            this.Hide();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            QL_HoaDon newform = new QL_HoaDon();
            newform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QL_NCC newform = new QL_NCC();
            newform .Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            QL_BaoHanh newform = new QL_BaoHanh(); 
            newform.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QL_KhuyenMai newform = new QL_KhuyenMai();  
            newform.Show();
            this.Hide();
        }
    }
}
