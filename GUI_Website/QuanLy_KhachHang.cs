using BLL_Website;
using DTO_Website;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI_Website
{
    public partial class QuanLy_KhachHang : Form
    {
        public QuanLy_KhachHang()
        {
            InitializeComponent();
        }

        private void QuanLy_KhachHang_Load(object sender, EventArgs e)
        {
            KhachHangBLL bll = new KhachHangBLL();
            var danhSachKhachHang = bll.LayDanhSachKhachHang();
            LoadDanhSachKhachHang();

            DataTable table = ConvertListToDataTable(danhSachKhachHang);

  
            if (table.Columns.Contains("ROLE"))
                table.Columns.Remove("ROLE");


            DataColumn roleCol = new DataColumn("ROLE", typeof(string));
            table.Columns.Add(roleCol);


            for (int i = 0; i < table.Rows.Count; i++)
            {
                string roleValue = danhSachKhachHang[i].ROLE?.Trim().ToLower();
                if (roleValue == "thân thiết") roleValue = "Thân thiết";
                else roleValue = "Bình thường"; 

                table.Rows[i]["ROLE"] = roleValue;
            }

            dgv_DanhSach_KH.AutoGenerateColumns = false;
            dgv_DanhSach_KH.DataSource = table;

  
            foreach (DataGridViewColumn col in dgv_DanhSach_KH.Columns)
            {
                if (col.Name == "ROLE")
                {
                    dgv_DanhSach_KH.Columns.Remove(col);
                    break;
                }
            }


            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.Name = "col_Role";
            combo.HeaderText = "Độ Thân Thiết";
            combo.DataPropertyName = "ROLE"; 
            combo.Items.Add("Thân thiết");
            combo.Items.Add("Bình thường");

            dgv_DanhSach_KH.Columns.Add(combo);


            dgv_DanhSach_KH.DataError += (s, args) => { args.ThrowException = false; };

            cbx_DoThanThiet.Items.Clear();
            cbx_DoThanThiet.Items.Add("Thân thiết");
            cbx_DoThanThiet.Items.Add("Bình thường");


            // ComboBox chọn tiêu chí tìm
            ccbx_TimKiemKH.Items.Add("Mã KH");
            ccbx_TimKiemKH.Items.Add("Tên KH");
            ccbx_TimKiemKH.SelectedIndex = 0; // chọn mặc định

            // Gắn sự kiện TextChanged cho TextBox
            txt_NhapThongTin.TextChanged += txt_NhapThongTin_TextChanged;


        }

        private DataTable ConvertListToDataTable(List<QuanLy_KhachHangDTO> list)
        {
            var table = new DataTable();

            table.Columns.Add("MaKH");
            table.Columns.Add("TenKH");
            table.Columns.Add("GioiTinh");
            table.Columns.Add("Sdt");
            table.Columns.Add("DiaChi");
            table.Columns.Add("MatKhaukh");
            table.Columns.Add("TRANGTHAI");
            table.Columns.Add("ROLE");

            foreach (var item in list)
            {
                table.Rows.Add(item.MaKH, item.TenKH, item.GioiTinh, item.Sdt, item.DiaChi, item.MatKhaukh,item.TRANGTHAI ,item.ROLE);
            }

            return table;
        }

        private void dgv_DanhSach_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSach_KH.Rows[e.RowIndex];


                txt_MaKH.Text = row.Cells["col_MaKH"].Value?.ToString();
                txt_TenKH.Text = row.Cells["col_TenKH"].Value?.ToString();
                string gioiTinh = row.Cells["col_Gender"].Value?.ToString();
                if (gioiTinh == "Nam")
                    rdo_Nam.Checked = true;
                else if (gioiTinh == "Nữ")
                    rdo_Nu.Checked = true;

                txt_SĐT.Text = row.Cells["col_SDT"].Value?.ToString();
                txt_DiaChi.Text = row.Cells["col_DiaChi"].Value?.ToString();
                txt_MatKhauKH.Text = row.Cells["col_MatKhau"].Value?.ToString();

                txt_TrangThai.Text = row.Cells["col_Status"].Value?.ToString();
                cbx_DoThanThiet.Text = row.Cells["col_Role"].FormattedValue?.ToString();

            }
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_MaKH.Text) ||
                string.IsNullOrWhiteSpace(txt_TenKH.Text) ||
                string.IsNullOrWhiteSpace(txt_SĐT.Text) ||
                string.IsNullOrWhiteSpace(txt_DiaChi.Text) ||
                string.IsNullOrWhiteSpace(txt_MatKhauKH.Text) ||
                string.IsNullOrWhiteSpace(txt_TrangThai.Text) ||
                string.IsNullOrWhiteSpace(cbx_DoThanThiet.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!int.TryParse(txt_MaKH.Text, out int maKH))
            {
                MessageBox.Show("Mã khách hàng phải là số.");
                return;
            }

            KhachHangBLL bll = new KhachHangBLL();
            var danhSach = bll.LayDanhSachKhachHang();
            bool maKH_Trung = danhSach.Any(k => k.MaKH == maKH);

            if (maKH_Trung)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!!!. Vui lòng nhập mã khác.");
                return;
            }


            QuanLy_KhachHangDTO kh = new QuanLy_KhachHangDTO
            {
                MaKH = maKH,
                TenKH = txt_TenKH.Text,
                GioiTinh = rdo_Nam.Checked ? "Nam" : "Nữ",
                Sdt = txt_SĐT.Text,
                DiaChi = txt_DiaChi.Text,
                MatKhaukh = txt_MatKhauKH.Text,
                TRANGTHAI = txt_TrangThai.Text,
                ROLE = cbx_DoThanThiet.Text
            };


            if (bll.ThemKhachHang(kh))
            {
                MessageBox.Show("Thêm khách hàng thành công");
                LoadDanhSachKhachHang();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        private void LoadDanhSachKhachHang()
        {
            KhachHangBLL bll = new KhachHangBLL();
            var danhSachKhachHang = bll.LayDanhSachKhachHang();
            dgv_DanhSach_KH.DataSource = ConvertListToDataTable(danhSachKhachHang);
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaKH.Text) ||
        string.IsNullOrWhiteSpace(txt_TenKH.Text) ||
        string.IsNullOrWhiteSpace(txt_SĐT.Text) ||
        string.IsNullOrWhiteSpace(txt_DiaChi.Text) ||
        string.IsNullOrWhiteSpace(txt_MatKhauKH.Text) ||
        string.IsNullOrWhiteSpace(txt_TrangThai.Text) ||
        string.IsNullOrWhiteSpace(cbx_DoThanThiet.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }


            if (!int.TryParse(txt_MaKH.Text, out int maKH))
            {
                MessageBox.Show("Mã khách hàng phải là số.");
                return;
            }

            KhachHangBLL bll = new KhachHangBLL();
            var danhSach = bll.LayDanhSachKhachHang();


            bool maKH_Trung = danhSach.Any(k => k.MaKH == maKH && k.TenKH != txt_TenKH.Text); 

            if (maKH_Trung)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!!!. Vui lòng nhập mã khác.");
                return;
            }


            QuanLy_KhachHangDTO kh = new QuanLy_KhachHangDTO
            {
                MaKH = maKH,
                TenKH = txt_TenKH.Text,
                GioiTinh = rdo_Nam.Checked ? "Nam" : "Nữ",
                Sdt = txt_SĐT.Text,
                DiaChi = txt_DiaChi.Text,
                MatKhaukh = txt_MatKhauKH.Text,
                TRANGTHAI = txt_TrangThai.Text,
                ROLE = cbx_DoThanThiet.Text
            };


            if (bll.SuaKhachHang(kh))
            {
                MessageBox.Show("Cập nhật khách hàng thành công");
                LoadDanhSachKhachHang();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.");
                return;
            }

            int maKH;
            if (!int.TryParse(txt_MaKH.Text, out maKH))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ.");
                return;
            }

            // Hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa khách hàng này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                KhachHangBLL bll = new KhachHangBLL();
                if (bll.XoaKhachHang(maKH))
                {
                    MessageBox.Show("Xóa khách hàng thành công.");
                    LoadDanhSachKhachHang();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Có thể khách hàng đang được liên kết với dữ liệu khác.");
                }
            }
        }

        private void txt_NhapThongTin_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txt_NhapThongTin.Text.Trim().ToLower();
            string tieuChi = ccbx_TimKiemKH.SelectedItem.ToString();

            KhachHangBLL bll = new KhachHangBLL();
            var danhSach = bll.LayDanhSachKhachHang(); // lấy full

            List<QuanLy_KhachHangDTO> ketQua = new List<QuanLy_KhachHangDTO>();

            if (tieuChi == "Mã KH")
            {
                ketQua = danhSach.Where(kh => kh.MaKH.ToString().Contains(tuKhoa)).ToList();
            }
            else if (tieuChi == "Tên KH")
            {
                ketQua = danhSach.Where(kh => kh.TenKH.ToLower().Contains(tuKhoa)).ToList();
            }

            dgv_DanhSach_KH.DataSource = ConvertListToDataTable(ketQua);
        }
    }
}
