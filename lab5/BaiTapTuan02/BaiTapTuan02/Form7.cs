using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan02
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        // Load form: Lưu, Xóa bị vô hiệu hóa, Tổng tiền = 0
        private void Form7_Load(object sender, EventArgs e)
        {
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            txtTongTien.Text = "0";
            txtSoTK.Focus();
        }

        // ================= THÊM / HỦY =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                // Chuyển sang chế độ nhập mới
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                lvTaiKhoan.SelectedItems.Clear();
                XoaTextBox();
                txtSoTK.Focus();
            }
            else
            {
                // Hủy thao tác thêm
                TroVeTrangThaiBanDau();
            }
        }

        // ================= LƯU =================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string soTK = txtSoTK.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (soTK == "")
            {
                MessageBox.Show("Vui lòng nhập số tài khoản!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTK.Focus();
                return;
            }
            if (TimTheoSoTK(soTK))
            {
                MessageBox.Show("Số tài khoản \"" + soTK + "\" đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTK.Focus();
                txtSoTK.SelectAll();
                return;
            }
            if (tenKH == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }
            if (!decimal.TryParse(txtSoTien.Text.Trim(), out decimal soTien) || soTien < 0)
            {
                MessageBox.Show("Số tiền phải là số không âm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTien.Focus();
                txtSoTien.SelectAll();
                return;
            }

            // Thêm vào ListView (STT đánh tự động)
            ListViewItem item = new ListViewItem((lvTaiKhoan.Items.Count + 1).ToString());
            item.SubItems.Add(soTK);
            item.SubItems.Add(tenKH);
            item.SubItems.Add(diaChi);
            item.SubItems.Add(soTien.ToString("N0"));
            item.Tag = soTien; // lưu giá trị số để tính tổng
            lvTaiKhoan.Items.Add(item);

            TinhTongTien();
            TroVeTrangThaiBanDau();
        }

        // ================= XÓA =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0) return;

            ListViewItem item = lvTaiKhoan.SelectedItems[0];
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa tài khoản \"" + item.SubItems[1].Text + "\"?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                lvTaiKhoan.Items.Remove(item);
                DanhLaiSTT();
                TinhTongTien();
                TroVeTrangThaiBanDau();
            }
        }

        // ================= CHỌN DÒNG -> HIỂN THỊ LÊN TEXTBOX =================
        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nút Xóa chỉ Enabled khi có mẫu tin được chọn
            btnXoa.Enabled = lvTaiKhoan.SelectedItems.Count > 0;

            if (lvTaiKhoan.SelectedItems.Count == 0) return;

            // Đang ở chế độ Thêm mà chọn dòng khác thì thoát chế độ Thêm
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;

            ListViewItem item = lvTaiKhoan.SelectedItems[0];
            txtSoTK.Text = item.SubItems[1].Text;
            txtTenKH.Text = item.SubItems[2].Text;
            txtDiaChi.Text = item.SubItems[3].Text;
            txtSoTien.Text = ((decimal)item.Tag).ToString();
        }

        // ================= THOÁT =================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // việc hỏi xác nhận nằm ở FormClosing
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // ================= HÀM HỖ TRỢ =================
        private void XoaTextBox()
        {
            txtSoTK.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();
        }

        private void TroVeTrangThaiBanDau()
        {
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            lvTaiKhoan.SelectedItems.Clear();
            XoaTextBox();
            txtSoTK.Focus();
        }

        // Kiểm tra số tài khoản đã tồn tại chưa
        private bool TimTheoSoTK(string soTK)
        {
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (string.Equals(item.SubItems[1].Text, soTK,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        // Đánh lại STT sau khi xóa
        private void DanhLaiSTT()
        {
            for (int i = 0; i < lvTaiKhoan.Items.Count; i++)
            {
                lvTaiKhoan.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }

        // Tính tổng số tiền của tất cả tài khoản
        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                tong += (decimal)item.Tag;
            }
            txtTongTien.Text = tong.ToString("N0");
        }
    }
}