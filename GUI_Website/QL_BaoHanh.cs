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
    public partial class QL_BaoHanh : Form
    {
        private QL_BaoHanhBLL baohanhbll = new QL_BaoHanhBLL();
        public QL_BaoHanh()
        {
            InitializeComponent();
        }
        private void LoadBaoHanhData()
        {
            List<QL_BaoHanhDTO> list = baohanhbll.LayDanhSachBaoHanh();  
            dgv_DanhSachBaoHanh.DataSource = list; 
        }

        private void QL_BaoHanh_Load(object sender, EventArgs e)
        {
            dgv_DanhSachBaoHanh.AllowUserToAddRows = false;

            LoadBaoHanhData();
            List<QL_BaoHanhDTO> list = baohanhbll.LayDanhSachBaoHanh();

            dgv_DanhSachBaoHanh.AutoGenerateColumns = false;
            dgv_DanhSachBaoHanh.DataSource = list;

            if (dgv_DanhSachBaoHanh.Columns["col_DieuKien"] is DataGridViewComboBoxColumn comboCol)
            {
                comboCol.Items.Clear();
                comboCol.Items.AddRange("Chính hãng", "Bảo hành VIP", "Lỗi nhà sản xuất");
            }

            cbx_DieuKienBH.Items.Clear();
            cbx_DieuKienBH.Items.AddRange(new string[] { "Chính hãng", "Bảo hành VIP", "Lỗi nhà sản xuất" });
            cbx_DieuKienBH.SelectedItem = "Chính hãng";


            cbx_TimKiem.Items.Add("Mã bảo hành");
            cbx_TimKiem.Items.Add("Mã sản phẩm");
            cbx_TimKiem.Items.Add("Thời gian bảo hành");
            cbx_TimKiem.Items.Add("Điều kiện bảo hành");


            cbx_TimKiem.SelectedIndex = 0;

        }

        private void dgv_DanhSachBaoHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgv_DanhSachBaoHanh.Rows[e.RowIndex];

                txt_MaBH.Text = row.Cells["col_MaBH"].Value?.ToString();
                txt_MaSP.Text = row.Cells["col_MaSP"].Value?.ToString();
                txt_TimeBH.Text = row.Cells["col_ThoiGian"].Value?.ToString();

                string dieuKien = row.Cells["col_DieuKien"].Value?.ToString();
                cbx_DieuKienBH.SelectedItem = dieuKien;


                if (DateTime.TryParse(row.Cells["col_NgayBD"].Value?.ToString(), out DateTime ngaybd))
                    dtpc_NgayBD.Value = ngaybd;

                if (DateTime.TryParse(row.Cells["col_NgayKT"].Value?.ToString(), out DateTime ngaykt))
                    dtpc_NgayKT.Value = ngaykt;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaSP.Text) ||
                string.IsNullOrWhiteSpace(txt_TimeBH.Text) ||
                cbx_DieuKienBH.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            QL_BaoHanhDTO bh = new QL_BaoHanhDTO
            {
                MaSP = int.Parse(txt_MaSP.Text),
                ThoiGian = int.Parse(txt_TimeBH.Text),
                DIEUKIEN = cbx_DieuKienBH.SelectedItem?.ToString(),
                NGAYBATDAU = dtpc_NgayBD.Value,
                NGAYHETHAN = dtpc_NgayKT.Value
            };

            bool result = baohanhbll.ThemBaoHanh(bh);
            if (result)
            {
                MessageBox.Show("Thêm bảo hành thành công!");
                LoadBaoHanhData();
                ClearForm();  
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void ClearForm()
        {
            txt_MaBH.Clear();
            txt_MaSP.Clear();
            txt_TimeBH.Clear();
            cbx_DieuKienBH.SelectedItem = null;  
            dtpc_NgayBD.Value = DateTime.Now;  
            dtpc_NgayKT.Value = DateTime.Now;  
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaBH.Text) ||
                string.IsNullOrWhiteSpace(txt_MaSP.Text) ||
                string.IsNullOrWhiteSpace(txt_TimeBH.Text) ||
                cbx_DieuKienBH.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            QL_BaoHanhDTO bh = new QL_BaoHanhDTO
            {
                MaBH = int.Parse(txt_MaBH.Text), 
                MaSP = int.Parse(txt_MaSP.Text),
                ThoiGian = int.Parse(txt_TimeBH.Text),
                DIEUKIEN = cbx_DieuKienBH.SelectedItem?.ToString(),
                NGAYBATDAU = dtpc_NgayBD.Value,
                NGAYHETHAN = dtpc_NgayKT.Value
            };

            bool result = baohanhbll.CapNhatBaoHanh(bh); 
            if (result)
            {
                MessageBox.Show("Cập nhật bảo hành thành công!");
                LoadBaoHanhData(); 
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void txt_NhapThongTin_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_NhapThongTin.Text.Trim();
            string tieuChi = cbx_TimKiem.SelectedItem?.ToString();


            if (string.IsNullOrEmpty(keyword))
            {
                LoadBaoHanhData();  
                return;
            }

            List<QL_BaoHanhDTO> danhSachGoc = baohanhbll.LayDanhSachBaoHanh();

            // Sử dụng LINQ để lọc danh sách
            var ketQuaTim = danhSachGoc.AsQueryable();

            switch (tieuChi)
            {
                case "Mã bảo hành":
                    ketQuaTim = ketQuaTim.Where(bh => bh.MaBH.ToString().Contains(keyword));
                    break;

                case "Mã sản phẩm":
                    ketQuaTim = ketQuaTim.Where(bh => bh.MaSP.ToString().Contains(keyword));
                    break;

                case "Thời gian bảo hành":
                    ketQuaTim = ketQuaTim.Where(bh => bh.ThoiGian.ToString().Contains(keyword));
                    break;

                case "Điều kiện bảo hành":
                    ketQuaTim = ketQuaTim.Where(bh => bh.DIEUKIEN.Contains(keyword));
                    break;
            }


            dgv_DanhSachBaoHanh.DataSource = ketQuaTim.ToList();
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
