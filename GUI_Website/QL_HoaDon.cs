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
    public partial class QL_HoaDon : Form
    {
        public QL_HoaDon()
        {
            InitializeComponent();
        }

        private void QL_HoaDon_Load(object sender, EventArgs e)
        {

            col_TrangThai.Items.Clear();
            col_TrangThai.Items.Add("Thanh toán");
            col_TrangThai.Items.Add("Hoàn trả");
            col_TrangThai.Items.Add("Hủy thanh toán");
            col_TrangThai.ValueType = typeof(string);

            cbx_TrangThai.Items.Clear();
            cbx_TrangThai.Items.Add("Thanh toán");
            cbx_TrangThai.Items.Add("Hoàn trả");
            cbx_TrangThai.Items.Add("Hủy thanh toán");


            LoadHoaDon();

            if(cbx_TrangThai.Items.Count == 0)
            {
                cbx_TrangThai.Items.Add("Thanh toán");
                cbx_TrangThai.Items.Add("Chưa thanh toán");
            }

            // Gán giá trị mặc định cho ComboBox
            cbx_TrangThai.SelectedItem = "Thanh toán";
        }

        private void LoadHoaDon()
        {
            List<QL_HoaDonDTO> danhSach = bll.LayDanhSachHoaDon();


            foreach (var hd in danhSach)
            {
                if (hd.TRANGTHAIHD != "Thanh toán" && hd.TRANGTHAIHD != "Hoàn trả" && hd.TRANGTHAIHD != "Hủy thanh toán")
                {
                    hd.TRANGTHAIHD = "Thanh toán"; 
                }
            }

            col_MaHD.DataPropertyName = "MaHD";
            col_MaNV.DataPropertyName = "MaNV";
            col_MaKH.DataPropertyName = "MaKH";
            col_NgayLapHD.DataPropertyName = "NgayLapHD";
            col_TongTien.DataPropertyName = "TongTien";
            col_TrangThai.DataPropertyName = "TRANGTHAIHD";

            cbx_TimKiem.Items.Add("Mã Hóa Đơn");
            cbx_TimKiem.Items.Add("Mã Khách Hàng");
            cbx_TimKiem.Items.Add("Mã Nhân Viên");
            cbx_TimKiem.SelectedIndex = 0;

            dgv_DanhSachHD.DataSource = danhSach;
            dgv_DanhSachHD.AllowUserToAddRows = true;
        }

        private void dgv_DanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_DanhSachHD.Rows.Count)
            {
                DataGridViewRow row = dgv_DanhSachHD.Rows[e.RowIndex];

                txt_MaHD.Text = row.Cells["col_MaHD"].Value?.ToString();
                txt_MaNV.Text = row.Cells["col_MaNV"].Value?.ToString();
                txt_MaKH.Text = row.Cells["col_MaKH"].Value?.ToString(); 
                dtpk_NgayLap.Value = Convert.ToDateTime(row.Cells["col_NgayLapHD"].Value);
                txt_TongTien.Text = row.Cells["col_TongTien"].Value?.ToString();
                cbx_TrangThai.SelectedItem = row.Cells["col_TrangThai"].Value?.ToString();
            }
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaHD.Text) ||
        string.IsNullOrWhiteSpace(txt_MaNV.Text) ||
        string.IsNullOrWhiteSpace(txt_MaKH.Text) ||
        string.IsNullOrWhiteSpace(txt_TongTien.Text) ||
        string.IsNullOrWhiteSpace(cbx_TrangThai.Text) ||
        dtpk_NgayLap.Value == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hóa đơn!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!int.TryParse(txt_MaHD.Text, out int maHD) ||
                !int.TryParse(txt_MaNV.Text, out int maNV) ||
                !int.TryParse(txt_MaKH.Text, out int maKH) ||
                !int.TryParse(txt_TongTien.Text, out int tongTien))
            {
                MessageBox.Show("Mã hóa đơn, Mã nhân viên, Mã khách hàng, và Tổng tiền phải là số!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QL_HoaDonDTO hoaDon = new QL_HoaDonDTO()
            {
                MaHD = maHD,
                MaNV = maNV,
                MaKH = maKH,
                NgayLapHD = dtpk_NgayLap.Value,
                TongTien = tongTien,
                TRANGTHAIHD = cbx_TrangThai.Text
            };


            QL_HoaDonBLL bll = new QL_HoaDonBLL();
            if (bll.ThemHoaDon(hoaDon))
            {
                MessageBox.Show("Thêm hóa đơn thành công!");
                LoadHoaDon(); 
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btn_SuaHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaHD.Text) ||
                  string.IsNullOrWhiteSpace(txt_MaNV.Text) ||
                  string.IsNullOrWhiteSpace(txt_MaKH.Text) ||
                  string.IsNullOrWhiteSpace(txt_TongTien.Text) ||
                  string.IsNullOrWhiteSpace(cbx_TrangThai.Text))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa và điền đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_MaHD.Text, out int maHD) ||
                !int.TryParse(txt_MaNV.Text, out int maNV) ||
                !int.TryParse(txt_MaKH.Text, out int maKH) ||
                !int.TryParse(txt_TongTien.Text, out int tongTien))
            {
                MessageBox.Show("Mã HD, NV, KH, và Tổng tiền phải là số hợp lệ!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QL_HoaDonDTO hd = new QL_HoaDonDTO
            {
                MaHD = maHD,
                MaNV = maNV,
                MaKH = maKH,
                NgayLapHD = dtpk_NgayLap.Value,
                TongTien = tongTien,
                TRANGTHAIHD = cbx_TrangThai.Text
            };

            if (bll.SuaHoaDon(hd))
            {
                MessageBox.Show("Cập nhật hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHoaDon();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XoaHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaHD.Text) || !int.TryParse(txt_MaHD.Text, out int maHD))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (bll.XoaHoaDon(maHD))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadHoaDon();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
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
        private QL_HoaDonBLL bll = new QL_HoaDonBLL();

        private void txt_NhapThongTin_TextChanged(object sender, EventArgs e)
        {

            if (cbx_TimKiem.SelectedItem == null) return;

            string tieuChi = cbx_TimKiem.SelectedItem.ToString();
            string tuKhoa = txt_NhapThongTin.Text;

            dgv_DanhSachHD.DataSource = bll.TimKiemHoaDon(tieuChi, tuKhoa);
        }
    }
}
