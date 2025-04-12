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
using System.IO;

namespace GUI_Website
{
    public partial class QuanLy_SanPham : Form
    {

        public QuanLy_SanPham()
        {
            InitializeComponent();
        }

        private void QuanLy_SanPham_Load(object sender, EventArgs e)
        {
            LoadDanhSachSanPham();
            cbx_LoaiSP.Items.Add("Laptop");
            cbx_LoaiSP.Items.Add("Chuột");
            cbx_LoaiSP.Items.Add("Bàn phím");

            cbx_TrangThai.Items.Add("Còn hàng");
            cbx_TrangThai.Items.Add("Hết hàng");
 

            cbx_LoaiSP.SelectedIndex = 0; 
            cbx_TrangThai.SelectedIndex = 0;

            cbx_TimKiem.Items.Add("Tên sản phẩm");
            cbx_TimKiem.Items.Add("Loại sản phẩm");
            cbx_TimKiem.SelectedIndex = 0;
        }

        private void LoadDanhSachSanPham()
        {
            QL_SanPhamBLL bll = new QL_SanPhamBLL();
            var danhSach = bll.LayDanhSachSanPham();

            dgv_DanhSachSanPham.AutoGenerateColumns = false;
            dgv_DanhSachSanPham.DataSource = ConvertListToDataTable(danhSach);

            var colLoaiSP = dgv_DanhSachSanPham.Columns["col_LoaiSP"] as DataGridViewComboBoxColumn;
            if (colLoaiSP != null)
            {
                colLoaiSP.Items.Clear();
                colLoaiSP.Items.Add("Laptop");
                colLoaiSP.Items.Add("Bàn phím");
                colLoaiSP.Items.Add("Chuột");
            }


            var colTrangThai = dgv_DanhSachSanPham.Columns["col_TrangThai"] as DataGridViewComboBoxColumn;
            if (colTrangThai != null)
            {
                colTrangThai.Items.Clear();
                colTrangThai.Items.Add("Còn hàng");
                colTrangThai.Items.Add("Hết hàng");
            }
        }


        private DataTable ConvertListToDataTable(List<QL_SanPhamDTO> list)
        {
            var table = new DataTable();



            table.Columns.Add("MaSP");
            table.Columns.Add("TenSP");
            table.Columns.Add("LoaiSP");
            table.Columns.Add("GiaNhap", typeof(int));
            table.Columns.Add("GiaBan", typeof(int));
            table.Columns.Add("SoLuong", typeof(int));
            table.Columns.Add("TRANGTHAISP");
            table.Columns.Add("NhaCungCap");
            table.Columns.Add("HINHANH");

            foreach (var sp in list)
            {
                string loai = sp.LoaiSP;

                if (loai == "Chu?t") loai = "Chuột";

                string trangThai = sp.TRANGTHAISP.Normalize(NormalizationForm.FormC);
                if (trangThai.Contains("?")) trangThai = "Còn hàng";
                table.Rows.Add(sp.MaSP, sp.TenSP, loai, sp.GiaNhap, sp.GiaBan, sp.SoLuong, trangThai, sp.NhaCungCap, sp.HINHANH);
            }

            return table;
        }

        private void dgv_DanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSachSanPham.Rows[e.RowIndex];

                txt_MaSP.Text = row.Cells["col_MaSP"].Value?.ToString();
                txt_TenSP.Text = row.Cells["col_TenSP"].Value?.ToString();
                cbx_LoaiSP.Text = row.Cells["col_LoaiSP"].Value?.ToString();
                txt_GiaNhap.Text = row.Cells["col_GiaNhap"].Value?.ToString();
                txt_GiaBan.Text = row.Cells["col_GiaBan"].Value?.ToString();
                txt_SoLuong.Text = row.Cells["col_SoLuong"].Value?.ToString();
                cbx_TrangThai.Text = row.Cells["col_TrangThai"].Value?.ToString();
                txt_NhaCungCap.Text = row.Cells["col_NCC"].Value?.ToString();

                // Lấy tên file ảnh từ cột hình ảnh
                string imageFileName = row.Cells["col_HinhAnh"].Value?.ToString();
                imageFileName = Path.GetFileName(imageFileName);

                // Cập nhật selectedImageFileName để dùng lại nếu người dùng không chọn ảnh mới
                selectedImageFileName = "images/" + imageFileName;

                // Hiển thị hình ảnh trong PictureBox
                string imagePath = Path.Combine(@"D:\images", imageFileName);
                if (File.Exists(imagePath))
                {
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        pic_Anh.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    pic_Anh.Image = null; // hoặc gán ảnh mặc định nếu muốn
                }
            }

        }
        private string selectedImageFileName = "";

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(ofd.FileName);
                string destPath = Path.Combine(@"D:\images", fileName);

                if (!File.Exists(destPath))
                {
                    File.Copy(ofd.FileName, destPath);
                }

                selectedImageFileName = "images/" + fileName;
                pic_Anh.Image = Image.FromFile(destPath);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaSP.Text) ||
               string.IsNullOrWhiteSpace(txt_TenSP.Text) ||
               string.IsNullOrWhiteSpace(txt_GiaNhap.Text) ||
               string.IsNullOrWhiteSpace(txt_GiaBan.Text) ||
               string.IsNullOrWhiteSpace(txt_SoLuong.Text) ||
               string.IsNullOrWhiteSpace(txt_NhaCungCap.Text) ||
               string.IsNullOrWhiteSpace(cbx_LoaiSP.Text) ||
               string.IsNullOrWhiteSpace(cbx_TrangThai.Text) ||
               string.IsNullOrWhiteSpace(selectedImageFileName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!int.TryParse(txt_MaSP.Text, out int maSP) ||
                !int.TryParse(txt_GiaNhap.Text, out int giaNhap) ||
                !int.TryParse(txt_GiaBan.Text, out int giaBan) ||
                !int.TryParse(txt_SoLuong.Text, out int soLuong) ||
                !int.TryParse(txt_NhaCungCap.Text, out int nhaCungCap))
            {
                MessageBox.Show("Mã sản phẩm, giá và số lượng phải là số!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (giaNhap > giaBan)
            {
                MessageBox.Show("Giá nhập không được lớn hơn giá bán!", "Lỗi logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QL_SanPhamDTO sp = new QL_SanPhamDTO()
            {
                MaSP = int.Parse(txt_MaSP.Text),
                TenSP = txt_TenSP.Text,
                LoaiSP = cbx_LoaiSP.Text,
                GiaNhap = int.Parse(txt_GiaNhap.Text),
                GiaBan = int.Parse(txt_GiaBan.Text),
                SoLuong = int.Parse(txt_SoLuong.Text),
                TRANGTHAISP = cbx_TrangThai.Text,
                NhaCungCap = int.Parse(txt_NhaCungCap.Text),
                HINHANH = selectedImageFileName
            };

            QL_SanPhamBLL bll = new QL_SanPhamBLL();
            if (bll.ThemSanPham(sp))
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadDanhSachSanPham(); 
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btn_ChonAnh_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(ofd.FileName);
                string destPath = Path.Combine(@"D:\images", fileName);

                if (!File.Exists(destPath))
                {
                    File.Copy(ofd.FileName, destPath);
                }

                selectedImageFileName = "images/" + fileName;
                pic_Anh.Image = Image.FromFile(destPath);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaSP.Text) ||
        string.IsNullOrWhiteSpace(txt_TenSP.Text) ||
        string.IsNullOrWhiteSpace(txt_GiaNhap.Text) ||
        string.IsNullOrWhiteSpace(txt_GiaBan.Text) ||
        string.IsNullOrWhiteSpace(txt_SoLuong.Text) ||
        string.IsNullOrWhiteSpace(txt_NhaCungCap.Text) ||
        string.IsNullOrWhiteSpace(cbx_LoaiSP.Text) ||
        string.IsNullOrWhiteSpace(cbx_TrangThai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_MaSP.Text, out int maSP) ||
                !int.TryParse(txt_GiaNhap.Text, out int giaNhap) ||
                !int.TryParse(txt_GiaBan.Text, out int giaBan) ||
                !int.TryParse(txt_SoLuong.Text, out int soLuong) ||
                !int.TryParse(txt_NhaCungCap.Text, out int nhaCungCap))
            {
                MessageBox.Show("Mã sản phẩm, giá và số lượng phải là số!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (giaNhap > giaBan)
            {
                MessageBox.Show("Giá nhập không được lớn hơn giá bán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (string.IsNullOrWhiteSpace(selectedImageFileName) && dgv_DanhSachSanPham.CurrentRow != null)
            {
                selectedImageFileName = dgv_DanhSachSanPham.CurrentRow.Cells["col_HinhAnh"].Value?.ToString();
            }

            QL_SanPhamDTO sp = new QL_SanPhamDTO()
            {
                MaSP = maSP,
                TenSP = txt_TenSP.Text,
                LoaiSP = cbx_LoaiSP.Text,
                GiaNhap = giaNhap,
                GiaBan = giaBan,
                SoLuong = soLuong,
                TRANGTHAISP = cbx_TrangThai.Text,
                NhaCungCap = nhaCungCap,
                HINHANH = selectedImageFileName
            };

            QL_SanPhamBLL bll = new QL_SanPhamBLL();
            if (bll.SuaSanPham(sp))
            {
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                LoadDanhSachSanPham();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

 
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            if (!int.TryParse(txt_MaSP.Text, out int maSP))
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            QL_SanPhamBLL bll = new QL_SanPhamBLL();
            if (bll.XoaSanPham(maSP))
            {
                MessageBox.Show("Xóa sản phẩm thành công!");
                LoadDanhSachSanPham();
                ClearForm(); 
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại!");
            }
        }
        private void ClearForm()
        {
            txt_MaSP.Clear();
            txt_TenSP.Clear();
            cbx_LoaiSP.SelectedIndex = -1;
            txt_GiaNhap.Clear();
            txt_GiaBan.Clear();
            txt_SoLuong.Clear();
            txt_NhaCungCap.Clear();
            cbx_TrangThai.SelectedIndex = -1;
            pic_Anh.Image = null;
            selectedImageFileName = "";
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

        private QL_SanPhamBLL bll = new QL_SanPhamBLL(); 

        private void txt_NhapThongTin_TextChanged(object sender, EventArgs e)
        {
            if (cbx_TimKiem.SelectedItem == null) return;

            string tuKhoa = txt_NhapThongTin.Text.Trim().ToLower();
            string tieuChi = cbx_TimKiem.SelectedItem.ToString();

            QL_SanPhamBLL bll = new QL_SanPhamBLL();
            List<QL_SanPhamDTO> danhSach = bll.LayDanhSachSanPham();

            List<QL_SanPhamDTO> ketQua = new List<QL_SanPhamDTO>();

            if (tieuChi == "Tên sản phẩm")
            {
                ketQua = danhSach
                    .Where(sp => !string.IsNullOrEmpty(sp.TenSP) && sp.TenSP.ToLower().Contains(tuKhoa))
                    .ToList();
            }
            else if (tieuChi == "Loại sản phẩm")
            {
                ketQua = danhSach
                    .Where(sp => !string.IsNullOrEmpty(sp.LoaiSP) && sp.LoaiSP.ToLower().Contains(tuKhoa))
                    .ToList();
            }

            dgv_DanhSachSanPham.DataSource = null;
            dgv_DanhSachSanPham.DataSource = ketQua;

            // Ẩn cột hình ảnh nếu cần
            if (dgv_DanhSachSanPham.Columns.Contains("HINHANH"))
            {
                dgv_DanhSachSanPham.Columns["HINHANH"].Visible = false;
            }
        }
    }
}
