using BLL_Website;
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
    public partial class QL_NCC : Form
    {
        private QL_NhaCungCapBLL _nhaCungCapBLL;
        public QL_NCC()
        {
            InitializeComponent();
            _nhaCungCapBLL = new QL_NhaCungCapBLL();
        }

        private void QL_NCC_Load(object sender, EventArgs e)
        {
            cbx_TimKiem.Items.Add("MaNCC");
            cbx_TimKiem.Items.Add("TrangThai");

            cbx_TimKiem.SelectedIndex = 0; // Chọn mặc định
            dgv_DanhSachNCC.AutoGenerateColumns = false;


            dgv_DanhSachNCC.Columns.Clear();


            dgv_DanhSachNCC.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_MaNCC", // Đặt Name để dùng ở CellClick nếu cần
                DataPropertyName = "MaNCC",
                HeaderText = "Mã NCC"
            });


            dgv_DanhSachNCC.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_TenNCC",
                DataPropertyName = "TenNCC",
                HeaderText = "Tên NCC"
            });


            dgv_DanhSachNCC.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_SDT",
                DataPropertyName = "SDT",
                HeaderText = "SĐT"
            });


            dgv_DanhSachNCC.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_DiaChi",
                DataPropertyName = "DiaChi",
                HeaderText = "Địa chỉ"
            });

            var colTrangThai = new DataGridViewComboBoxColumn()
            {
                Name = "col_TrangThai",
                DataPropertyName = "TRANGTHAINCC",
                HeaderText = "Trạng thái"
            };
            colTrangThai.Items.Add("Hoạt động");
            colTrangThai.Items.Add("Ngừng cung cấp");
            dgv_DanhSachNCC.Columns.Add(colTrangThai);


            List<QL_NhaCungCapDTO> list = _nhaCungCapBLL.LayDanhSachNCC();
            dgv_DanhSachNCC.DataSource = list;


            dgv_DanhSachNCC.DataError += dgv_DanhSachNCC_DataError;

            cbx_TrangThai.Items.Clear();
            cbx_TrangThai.Items.Add("Hoạt động");
            cbx_TrangThai.Items.Add("Ngừng cung cấp");
            cbx_TrangThai.SelectedIndex = 0; // Chọn "Hoạt động" là mặc định
        }


        private void dgv_DanhSachNCC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            MessageBox.Show("Lỗi hiển thị trạng thái: " + e.Exception.Message);
            e.ThrowException = false;
        }


        private void dgv_DanhSachNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSachNCC.Rows[e.RowIndex];


                txt_MaNCC.Text = row.Cells["col_MaNCC"].Value?.ToString();
                txt_TenNCC.Text = row.Cells["col_TenNCC"].Value?.ToString();
                txt_SĐT.Text = row.Cells["col_SDT"].Value?.ToString();
                txt_DiaChi.Text = row.Cells["col_DiaChi"].Value?.ToString();
                cbx_TrangThai.SelectedItem = row.Cells["col_TrangThai"].Value?.ToString();



            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txt_MaNCC.Text) || string.IsNullOrEmpty(txt_TenNCC.Text) ||
                    string.IsNullOrEmpty(txt_SĐT.Text) || string.IsNullOrEmpty(txt_DiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!IsPhoneNumberValid(txt_SĐT.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                QL_NhaCungCapDTO nhaCungCap = new QL_NhaCungCapDTO
                {
                    MaNCC = Convert.ToInt32(txt_MaNCC.Text),
                    TenNCC = txt_TenNCC.Text,
                    SDT = txt_SĐT.Text,
                    DiaChi = txt_DiaChi.Text,
                    TRANGTHAINCC = cbx_TrangThai.SelectedItem.ToString()
                };


                QL_NhaCungCapBLL bll = new QL_NhaCungCapBLL();
                if (bll.IsMaNCCExist(nhaCungCap.MaNCC))
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                bool result = bll.ThemNhaCungCap(nhaCungCap);

                if (result)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNCC();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp không thành công. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {

            return phoneNumber.Length >= 10 && phoneNumber.All(char.IsDigit);
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txt_MaNCC.Text) || string.IsNullOrEmpty(txt_TenNCC.Text) ||
                    string.IsNullOrEmpty(txt_SĐT.Text) || string.IsNullOrEmpty(txt_DiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsPhoneNumberValid(txt_SĐT.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                QL_NhaCungCapDTO nhaCungCap = new QL_NhaCungCapDTO
                {
                    MaNCC = Convert.ToInt32(txt_MaNCC.Text),
                    TenNCC = txt_TenNCC.Text,
                    SDT = txt_SĐT.Text,
                    DiaChi = txt_DiaChi.Text,
                    TRANGTHAINCC = cbx_TrangThai.SelectedItem.ToString()
                };


                QL_NhaCungCapBLL bll = new QL_NhaCungCapBLL();

                bool result = bll.CapNhatNhaCungCap(nhaCungCap);

                if (result)
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNCC();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachNCC()
        {
            QL_NhaCungCapBLL bll = new QL_NhaCungCapBLL();
            var danhSachNCC = bll.LayDanhSachNCC();
            dgv_DanhSachNCC.DataSource = danhSachNCC;
        }


        private void ClearForm()
        {
            txt_MaNCC.Clear();
            txt_TenNCC.Clear();
            txt_SĐT.Clear();
            txt_DiaChi.Clear();
            cbx_TrangThai.SelectedIndex = 0;

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_MaNCC.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultConfirm = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultConfirm == DialogResult.No)
                    return;

                QL_NhaCungCapDTO nhaCungCap = new QL_NhaCungCapDTO
                {
                    MaNCC = Convert.ToInt32(txt_MaNCC.Text)
                };

                QL_NhaCungCapBLL bll = new QL_NhaCungCapBLL();
                bool result = bll.XoaNhaCungCap(nhaCungCap);

                if (result)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNCC();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công hoặc mã không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kieuTim = cbx_TimKiem.SelectedItem?.ToString();
            string giaTri = txt_ThongTin.Text;

            if (!string.IsNullOrEmpty(kieuTim))
            {
                QL_NhaCungCapBLL bll = new QL_NhaCungCapBLL();
                dgv_DanhSachNCC.DataSource = bll.TimKiemNhaCungCap(kieuTim, giaTri);
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn quay lại trang Quản lý?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Close();

                QuanLy formQuanLy = new QuanLy();
                formQuanLy.Show();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

