    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using BLL_Website;

    namespace GUI_Website
    {
        public partial class DangNhap : Form
        {
            private TaiKhoanBLL userService = new TaiKhoanBLL();
            static class Program
            {
                [STAThread]
                static void Main()
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new NhanVien()); 
                }
            }
            public DangNhap()
            {
                InitializeComponent();
            }

            private void DangNhap_Load(object sender, EventArgs e)
            {
                txt_MatKhau.PasswordChar = '*';

            }

            private void btn_Thoat_Click(object sender, EventArgs e)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit(); 
                }
            }

            private void btn_DangNhap_Click(object sender, EventArgs e)
            {
                string username = txt_TaiKhoan.Text;
                string password = txt_MatKhau.Text;

                string chucVu = userService.Login(username, password);

                if (chucVu == "Admin" || chucVu == "Quản Lý")
                {
                    MessageBox.Show("Đăng nhập thành công với quyền Admin!");
                    QuanLy adminForm = new QuanLy();
                    adminForm.Show();
                    this.Hide();
                }
                else if (chucVu == "Nhân viên" || chucVu == "Thu Ngân")
                {
                    MessageBox.Show("Đăng nhập thành công với quyền Nhân viên!");
                    NhanVien nvForm = new NhanVien();
                    nvForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }

            }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
                if (chk_ShowPassWord.Checked)
                {
                    txt_MatKhau.PasswordChar = '\0'; 
                }
                else
                {
                    txt_MatKhau.PasswordChar = '*'; 
                }
            }
        }
    }
