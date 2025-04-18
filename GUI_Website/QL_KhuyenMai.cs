using DTO_Website;
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

namespace GUI_Website
{
    public partial class QL_KhuyenMai : Form
    {
        private QL_KhuyenMaiBLL kmbll = new QL_KhuyenMaiBLL();
        public QL_KhuyenMai()
        {
            InitializeComponent();
        }
        private void LoadKhuyenMaiData()
        {
            List<QL_KhuyenMaiDTO> list = kmbll.LayDanhSachKhuyenMai();
            dgv_DanhSachKhuyenMai.DataSource = list;
        }

        private void QL_KhuyenMai_Load(object sender, EventArgs e)
        {
            LoadKhuyenMaiData();
            List<QL_KhuyenMaiDTO> list = kmbll.LayDanhSachKhuyenMai();

            dgv_DanhSachKhuyenMai.AutoGenerateColumns = false;
            dgv_DanhSachKhuyenMai.DataSource = list;

            if (dgv_DanhSachKhuyenMai.Columns["col_LoaiKM"] is DataGridViewComboBoxColumn comboCol)
            {
                comboCol.Items.Clear();
                comboCol.Items.AddRange("%","VND");
            }
            cbx_LoaiKM.Items.Clear();
            cbx_LoaiKM.Items.AddRange(new string[] { "%", "VND" });
            cbx_LoaiKM.SelectedIndex = 0;

            cbx_TimKiem.Items.Add("Mã khuyến mãi");
            cbx_TimKiem.Items.Add("Tên khuyến mãi");
            cbx_TimKiem.Items.Add("Loại khuyến mãi");

            cbx_TimKiem.SelectedIndex = 0;
            txt_NhapThongTin.TextChanged += txt_NhapThongTin_TextChanged;
        }

        private void dgv_DanhSachKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSachKhuyenMai.Rows[e.RowIndex];

                txt_MaKM.Text = row.Cells["col_MaKM"].Value?.ToString();
                txt_TenKM.Text = row.Cells["col_TenKM"].Value?.ToString();
                txt_GiamGia.Text = row.Cells["col_GiamGia"].Value?.ToString();

                string loaiKM = row.Cells["col_LoaiKM"].Value?.ToString();
                cbx_LoaiKM.SelectedItem = loaiKM;

                if (DateTime.TryParse(row.Cells["col_NgayBD"].Value?.ToString(), out DateTime ngayBD))
                    dtpc_NgayBD.Value = ngayBD;

                if (DateTime.TryParse(row.Cells["col_NgayKT"].Value?.ToString(), out DateTime ngayKT))
                    dtpc_NgayKT.Value = ngayKT;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenKM.Text) ||
        string.IsNullOrWhiteSpace(txt_GiamGia.Text) ||
        cbx_LoaiKM.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khuyến mãi.");
                return;
            }

            if (!float.TryParse(txt_GiamGia.Text, out float giamGia) || giamGia <= 0)
            {
                MessageBox.Show("Giá trị giảm giá không hợp lệ.");
                return;
            }

            if (dtpc_NgayBD.Value >= dtpc_NgayKT.Value)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu.");
                return;
            }


            QL_KhuyenMaiDTO km = new QL_KhuyenMaiDTO
            {
                TenKM = txt_TenKM.Text.Trim(),
                GiamGia = giamGia,
                LOAIKM = cbx_LoaiKM.SelectedItem.ToString(),
                NGAYBATDAU = dtpc_NgayBD.Value,
                NGAYKETTHUC = dtpc_NgayKT.Value
            };

   
            bool result = kmbll.ThemKhuyenMai(km);

            if (result)
            {
                MessageBox.Show("Thêm khuyến mãi thành công!");
                LoadKhuyenMaiData(); 
                ResetForm();         
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
        private void ResetForm()
        {
            txt_TenKM.Clear();
            txt_GiamGia.Clear();
            cbx_LoaiKM.SelectedIndex = 0;
            dtpc_NgayBD.Value = DateTime.Now;
            dtpc_NgayKT.Value = DateTime.Now.AddDays(1);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_MaKM.Text) ||
                string.IsNullOrWhiteSpace(txt_TenKM.Text) ||
                string.IsNullOrWhiteSpace(txt_GiamGia.Text) ||
                cbx_LoaiKM.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khuyến mãi.");
                return;
            }

            if (!float.TryParse(txt_GiamGia.Text, out float giamGia) || giamGia <= 0)
            {
                MessageBox.Show("Giá trị giảm giá không hợp lệ.");
                return;
            }

            if (dtpc_NgayBD.Value >= dtpc_NgayKT.Value)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu.");
                return;
            }

  
            QL_KhuyenMaiDTO km = new QL_KhuyenMaiDTO
            {
                MaKM = int.Parse(txt_MaKM.Text),
                TenKM = txt_TenKM.Text.Trim(),
                GiamGia = giamGia,
                LOAIKM = cbx_LoaiKM.SelectedItem.ToString(),
                NGAYBATDAU = dtpc_NgayBD.Value,
                NGAYKETTHUC = dtpc_NgayKT.Value
            };


            bool result = kmbll.CapNhatKhuyenMai(km);

            if (result)
            {
                MessageBox.Show("Cập nhật khuyến mãi thành công!");
                LoadKhuyenMaiData();
                ResetForm();        
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaKM.Text))
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần xóa.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này?",
                                                         "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                QL_KhuyenMaiDTO km = new QL_KhuyenMaiDTO
                {
                    MaKM = int.Parse(txt_MaKM.Text)
                };

    
                bool result = kmbll.XoaKhuyenMai(km);

                if (result)
                {
                    MessageBox.Show("Xóa khuyến mãi thành công!");
                    LoadKhuyenMaiData(); 
                    ResetForm();         
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Có lỗi xảy ra.");
                }
            }
        }

        private void txt_NhapThongTin_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_NhapThongTin.Text.Trim();
            string tieuChi = cbx_TimKiem.SelectedItem.ToString();


            List<QL_KhuyenMaiDTO> danhSachKhuyenMai = kmbll.LayDanhSachKhuyenMai();

            List<QL_KhuyenMaiDTO> ketQuaTimKiem = new List<QL_KhuyenMaiDTO>();


            switch (tieuChi)
            {
                case "Mã khuyến mãi":
                    ketQuaTimKiem = danhSachKhuyenMai
                        .Where(km => km.MaKM.ToString().Contains(keyword))
                        .ToList();
                    break;

                case "Tên khuyến mãi":
                    ketQuaTimKiem = danhSachKhuyenMai
                        .Where(km => km.TenKM.Contains(keyword))
                        .ToList();
                    break;

                case "Loại khuyến mãi":
                    ketQuaTimKiem = danhSachKhuyenMai
                        .Where(km => km.LOAIKM.Contains(keyword))
                        .ToList();
                    break;
            }


            dgv_DanhSachKhuyenMai.DataSource = ketQuaTimKiem;
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
