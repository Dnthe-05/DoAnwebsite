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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void btn_TaoDonHang_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void ShowUserControl(UserControl userControl)
        {
            // Xóa nội dung hiện tại trong panelMain
            pnl_ChangeContent.Controls.Clear();
            // Thêm UserControl mới vào panelMain
            userControl.Dock = DockStyle.Fill;
            pnl_ChangeContent.Controls.Add(userControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ucBanHang());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
