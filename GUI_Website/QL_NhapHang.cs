using BLL_Website;
using DTO_Website;
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
    public partial class QL_NhapHang : Form
    {
        QL_NhapHangBLL nhapHangBLL = new QL_NhapHangBLL();
        public QL_NhapHang()
        {
            InitializeComponent();
        }

        private void QL_NhapHang_Load(object sender, EventArgs e)
        {

            List<QL_NhapHangDTO> danhSachNhapHang = nhapHangBLL.LayDanhSachNhapHang();
            dgv_DanhSachNhapHang.DataSource = danhSachNhapHang;

            dgv_DanhSachNhapHang.AutoGenerateColumns = false;


        }

        private void dgv_DanhSachNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {

                DataGridViewRow row = dgv_DanhSachNhapHang.Rows[e.RowIndex];

            
                txt_MaHang.Text = row.Cells["col_MaHang"].Value.ToString();  
                txt_MaNCC.Text = row.Cells["col_MaNCC"].Value.ToString();  
                txt_MaSP.Text = row.Cells["col_MaSP"].Value.ToString(); 
                txt_SoLuong.Text = row.Cells["col_SoLuong"].Value.ToString();  

              
                DateTime ngayNhap = DateTime.Parse(row.Cells["col_NgayNhap"].Value.ToString());
                dtpc_NgayNhap.Value = ngayNhap; 

                txt_GiaNhap.Text = row.Cells["col_GiaNhap"].Value.ToString(); 
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(txt_MaHang.Text) || string.IsNullOrEmpty(txt_MaNCC.Text) ||
                    string.IsNullOrEmpty(txt_MaSP.Text) || string.IsNullOrEmpty(txt_SoLuong.Text) ||
                    string.IsNullOrEmpty(txt_GiaNhap.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                QL_NhapHangDTO nhapHang = new QL_NhapHangDTO
                {
                    MaNH = int.Parse(txt_MaHang.Text),  
                    MaNCC = int.Parse(txt_MaNCC.Text), 
                    MaSP = int.Parse(txt_MaSP.Text),   
                    SOLUONGNHAP = int.Parse(txt_SoLuong.Text),
                    NgayNhap = dtpc_NgayNhap.Value,     
                    GiaNhap = int.Parse(txt_GiaNhap.Text)
                };


                bool result = nhapHangBLL.ThemNhapHang(nhapHang);

                if (result)
                {
                    MessageBox.Show("Thêm nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    List<QL_NhapHangDTO> danhSachNhapHang = nhapHangBLL.LayDanhSachNhapHang();
                    dgv_DanhSachNhapHang.DataSource = danhSachNhapHang;


                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm nhập hàng không thành công. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearForm()
        {

            txt_MaHang.Clear();
            txt_MaNCC.Clear();
            txt_MaSP.Clear();
            txt_SoLuong.Clear();
            txt_GiaNhap.Clear();
            dtpc_NgayNhap.Value = DateTime.Now; 
        }

        private void dgv_DanhSachNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại trang Quản lý?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Close();

                QuanLy formQuanLy = new QuanLy();
                formQuanLy.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

}
