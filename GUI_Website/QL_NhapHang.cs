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
            dgv_DanhSachNhapHang.DataSource = danhSachNhapHang;

            cbx_TimKiem.Items.Add("Mã Hàng");
            cbx_TimKiem.Items.Add("Mã NCC");
            cbx_TimKiem.Items.Add("Mã SP");
            cbx_TimKiem.Items.Add("Số lượng");

            cbx_TimKiem.SelectedIndex = 0;
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
                    bool capNhatKho = nhapHangBLL.CapNhatSoLuongTonKho(nhapHang.MaSP, nhapHang.SOLUONGNHAP);

                    if (capNhatKho)
                    {
                        MessageBox.Show("Thêm nhập hàng và cập nhật kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhập hàng thành công nhưng cập nhật kho thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

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
        private void LoadDanhSachNhapHang()
        {
            List<QL_NhapHangDTO> danhSachNhapHang = nhapHangBLL.LayDanhSachNhapHang();
            dgv_DanhSachNhapHang.DataSource = danhSachNhapHang;
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            QL_NhapHangDTO nhapHang = new QL_NhapHangDTO
            {
                MaNH = int.Parse(txt_MaHang.Text),
                MaNCC = int.Parse(txt_MaNCC.Text),
                MaSP = int.Parse(txt_MaSP.Text),
                SOLUONGNHAP = int.Parse(txt_SoLuong.Text),
                NgayNhap = dtpc_NgayNhap.Value,
                GiaNhap = int.Parse(txt_GiaNhap.Text)
            };

            bool result = nhapHangBLL.CapNhatNhapHang(nhapHang);

            if (result)
            {
                MessageBox.Show("Cập nhật phiếu nhập thành công!", "Thông báo");
                LoadDanhSachNhapHang(); 
                ClearForm();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!. Không được sửa mã tránh gây lỗi nhập hàng", "Lỗi");
                ClearForm();
            }
        }

        private void txt_NhapThongTin_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_NhapThongTin.Text.Trim();
            string tieuChi = cbx_TimKiem.SelectedItem.ToString();

            List<QL_NhapHangDTO> danhSachGoc = nhapHangBLL.LayDanhSachNhapHang();

            List<QL_NhapHangDTO> ketQuaTim = new List<QL_NhapHangDTO>();

            switch (tieuChi)
            {
                case "Mã Hàng":
                    ketQuaTim = danhSachGoc
                        .Where(nh => nh.MaNH.ToString().Contains(keyword))
                        .ToList();
                    break;

                case "Mã NCC":
                    ketQuaTim = danhSachGoc
                        .Where(nh => nh.MaNCC.ToString().Contains(keyword))
                        .ToList();
                    break;

                case "Mã SP":
                    ketQuaTim = danhSachGoc
                        .Where(nh => nh.MaSP.ToString().Contains(keyword))
                        .ToList();
                    break;

                case "Số lượng":
                    ketQuaTim = danhSachGoc
                        .Where(nh => nh.SOLUONGNHAP.ToString().Contains(keyword))
                        .ToList();
                    break;
            }

            dgv_DanhSachNhapHang.DataSource = ketQuaTim;
        }
    }
}
