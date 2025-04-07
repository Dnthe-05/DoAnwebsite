using BLL_Website;
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
using DTO_Website;

namespace GUI_Website
{
    public partial class QuanLy_NhanVien : Form
    {

        private NhanVienBLL _nhanVienBLL;
        public QuanLy_NhanVien()
        {
            InitializeComponent();
            _nhanVienBLL = new NhanVienBLL();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void QuanLy_NhanVien_Load(object sender, EventArgs e)
        {
            dgv_DanhSachNhanVien.DataError += dgv_DanhSachNhanVien_DataError;
            LoadComboBoxData();
            LoadNhanVienData();
            LoadFilterOptions();

        }
        private void LoadNhanVienData()
        {
            dgv_DanhSachNhanVien.AutoGenerateColumns = false;  
            var dt = _nhanVienBLL.GetEmployeeData();
            dgv_DanhSachNhanVien.DataSource = dt;
            _originalData = _nhanVienBLL.GetEmployeeData();
            dgv_DanhSachNhanVien.DataSource = _originalData;

            foreach (DataGridViewRow row in dgv_DanhSachNhanVien.Rows)
            {
                string trangThai = row.Cells["TRANGTHAI"].Value?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(trangThai) && cbx_TrangThai.Items.Contains(trangThai))
                {
                    row.Cells["TRANGTHAI"].Value = trangThai; 
                }

            var role = row.Cells["ROLE"].Value?.ToString();
                if (!string.IsNullOrEmpty(role) && !cbx_ChucVu.Items.Contains(role))
                {
                    row.Cells["ROLE"].Value = cbx_ChucVu.Items[0]; 
                }
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void LoadComboBoxData()
        {
            var trangThaiList = _nhanVienBLL.GetTrangThaiList();
            var roleList = _nhanVienBLL.GetRoleList();

            cbx_TrangThai.DataSource = new BindingSource(trangThaiList, null);
            cbx_ChucVu.DataSource = new BindingSource(roleList, null);

            ((DataGridViewComboBoxColumn)dgv_DanhSachNhanVien.Columns["TRANGTHAI"]).DataSource = trangThaiList;
            ((DataGridViewComboBoxColumn)dgv_DanhSachNhanVien.Columns["ROLE"]).DataSource = roleList;
        }

        private void dgv_DanhSachNhanVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgv_DanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSachNhanVien.Rows[e.RowIndex];

                txt_Manv.Text = row.Cells["MANV"].Value.ToString();
                txt_FullName.Text = row.Cells["HOTENNV"].Value.ToString();
                txt_SDT.Text = row.Cells["SDT"].Value.ToString();
                dtp_NgayVaoLam.Value = Convert.ToDateTime(row.Cells["NGAYVAOLAM"].Value);
                txt_Luong.Text = row.Cells["LUONG"].Value.ToString();
                txt_MatKhau.Text = row.Cells["MATKHAUNV"].Value.ToString();
                txt_TaiKhoan.Text = row.Cells["TENTK"].Value.ToString();

                string trangThai = row.Cells["TRANGTHAI"].Value?.ToString() ?? string.Empty;
                string chucVu = row.Cells["ROLE"].Value?.ToString() ?? string.Empty;

                if (!string.IsNullOrEmpty(trangThai) && cbx_TrangThai.Items.Contains(trangThai))
                {
                    cbx_TrangThai.SelectedItem = trangThai;
                }

                if (!string.IsNullOrEmpty(chucVu) && cbx_ChucVu.Items.Contains(chucVu))
                {
                    cbx_ChucVu.SelectedItem = chucVu;
                }
            }
        }
        private DataTable _originalData;
        private void LoadFilterOptions()
        {
            cbx_TimKiem.Items.Clear(); 

            cbx_TimKiem.Items.Add("Mã nhân viên");
            cbx_TimKiem.Items.Add("Họ tên");
            cbx_TimKiem.Items.Add("Chức vụ");

            cbx_TimKiem.SelectedIndex = 0;

            txt_NhapThongTin.TextChanged += (s, e) => FilterData();
            cbx_TimKiem.SelectedIndexChanged += (s, e) => FilterData();
        }

        private void cbx_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_originalData == null) return;

            string selectedFilter = cbx_TimKiem.SelectedItem?.ToString();
            string keyword = txt_NhapThongTin.Text.Trim().Replace("'", "''"); 

            string columnName = "";

            switch (selectedFilter)
            {
                case "Mã nhân viên":
                    columnName = "MANV";
                    break;
                case "Họ tên":
                    columnName = "HOTENNV";
                    break;
                case "Chức vụ":
                    columnName = "ROLE";
                    break;
            }

            if (!string.IsNullOrEmpty(columnName))
            {
                DataView dv = _originalData.DefaultView;
                dgv_DanhSachNhanVien.DataSource = dv.ToTable();
            }
        }
        private void FilterData()
        {
            if (_originalData == null) return;

            string selectedFilter = cbx_TimKiem.SelectedItem?.ToString();
            string keyword = txt_NhapThongTin.Text.Trim().Replace("'", "''");

            string columnName = "";

            switch (selectedFilter)
            {
                case "Mã nhân viên":
                    columnName = "MANV";
                    break;
                case "Họ tên":
                    columnName = "HOTENNV";
                    break;
                case "Chức vụ":
                    columnName = "ROLE";
                    break;
            }

            if (!string.IsNullOrEmpty(columnName))
            {
                DataView dv = _originalData.DefaultView;

                if (dv.Table.Columns[columnName].DataType == typeof(string))
                {
                    dv.RowFilter = $"{columnName} LIKE '%{keyword}%'";
                }
                else if (dv.Table.Columns[columnName].DataType == typeof(int))
                {

                    if (int.TryParse(keyword, out int numericKeyword))
                    {
                        dv.RowFilter = $"{columnName} = {numericKeyword}";
                    }
                    else
                    {
                        dv.RowFilter = "1 = 0"; 
                    }
                }

                dgv_DanhSachNhanVien.DataSource = dv.ToTable();
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn quay lại trang Quản lý?", 
        "Xác nhận", 
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question );

            if (result == DialogResult.Yes)
            {
              
                this.Close();

                QuanLy formQuanLy = new QuanLy(); 
                formQuanLy.Show(); 
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienDTO nv = new NhanVienDTO
                {
                    MaNV = int.Parse(txt_Manv.Text),
                    HoTen = txt_FullName.Text,
                    GioiTinh = rdb_Nam.Checked ? "Nam" : "Nữ",
                    SDT = txt_SDT.Text,
                    NgayVaoLam = dtp_NgayVaoLam.Value,
                    Luong = int.Parse(txt_Luong.Text),
                    MatKhauNV = txt_MatKhau.Text,
                    TRANGTHAI = cbx_TrangThai.Text,
                    ROLE = cbx_ChucVu.Text,
                    TenTK = txt_TaiKhoan.Text
                };


                NhanVienBLL bll = new NhanVienBLL();
                if (bll.IsNhanVienExists(nv.MaNV, nv.TenTK))
                {
                    MessageBox.Show("Nhân viên này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string thongBao = bll.ThemNhanVien(nv);
                MessageBox.Show(thongBao);

                if (thongBao.Contains("thành công"))
                {
                    DataTable dt = (DataTable)dgv_DanhSachNhanVien.DataSource;


                    DataRow newRow = dt.NewRow();
                    newRow["MANV"] = nv.MaNV;
                    newRow["HOTENNV"] = nv.HoTen;
                    newRow["GIOITINH"] = nv.GioiTinh;
                    newRow["SDT"] = nv.SDT;
                    newRow["NGAYVAOLAM"] = nv.NgayVaoLam;
                    newRow["LUONG"] = nv.Luong;
                    newRow["MATKHAUNV"] = nv.MatKhauNV;
                    newRow["TRANGTHAI"] = nv.TRANGTHAI;
                    newRow["ROLE"] = nv.ROLE;
                    newRow["TENTK"] = nv.TenTK;

                    dt.Rows.Add(newRow);
                    dgv_DanhSachNhanVien.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {

                NhanVienDTO nv = new NhanVienDTO
                {
                    MaNV = int.Parse(txt_Manv.Text),
                    HoTen = txt_FullName.Text,
                    GioiTinh = rdb_Nam.Checked ? "Nam" : "Nữ",
                    SDT = txt_SDT.Text,
                    NgayVaoLam = dtp_NgayVaoLam.Value,
                    Luong = int.Parse(txt_Luong.Text),
                    MatKhauNV = txt_MatKhau.Text,
                    TRANGTHAI = cbx_TrangThai.Text,
                    ROLE = cbx_ChucVu.Text,
                    TenTK = txt_TaiKhoan.Text
                };

                NhanVienBLL bll = new NhanVienBLL();
                string thongBao = bll.SuaNhanVien(nv);
                MessageBox.Show(thongBao);

                if (thongBao.Contains("thành công"))
                {
                    foreach (DataGridViewRow row in dgv_DanhSachNhanVien.Rows)
                    {
                        if (row.Cells["MANV"].Value.ToString() == nv.MaNV.ToString())
                        {
                            row.Cells["HOTENNV"].Value = nv.HoTen;
                            row.Cells["GIOITINH"].Value = nv.GioiTinh;
                            row.Cells["SDT"].Value = nv.SDT;
                            row.Cells["NGAYVAOLAM"].Value = nv.NgayVaoLam;
                            row.Cells["LUONG"].Value = nv.Luong;
                            row.Cells["MATKHAUNV"].Value = nv.MatKhauNV;
                            row.Cells["TRANGTHAI"].Value = nv.TRANGTHAI;
                            row.Cells["ROLE"].Value = nv.ROLE;
                            row.Cells["TENTK"].Value = nv.TenTK;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_Manv.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa nhân viên này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    int maNV = int.Parse(txt_Manv.Text);
                    NhanVienBLL bll = new NhanVienBLL();
                    string thongBao = bll.XoaNhanVien(maNV);
                    MessageBox.Show(thongBao);

                    if (thongBao.Contains("thành công"))
                    {
                     
                        foreach (DataGridViewRow row in dgv_DanhSachNhanVien.Rows)
                        {
                            if (row.Cells["MANV"].Value.ToString() == maNV.ToString())
                            {
                                dgv_DanhSachNhanVien.Rows.Remove(row);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?","Xác nhận thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}
