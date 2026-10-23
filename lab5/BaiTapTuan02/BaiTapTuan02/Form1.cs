using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaiTapTuan02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gán sự kiện (nếu chưa gán trong Designer thì giữ các dòng này)
            btnCapNhat.Click += btnCapNhat_Click;
            cboSo.SelectedIndexChanged += cboSo_SelectedIndexChanged;
            btnTong.Click += btnTong_Click;
            btnSoChan.Click += btnSoChan_Click;
            btnNguyenTo.Click += btnNguyenTo_Click;
            btnThoat.Click += btnThoat_Click;

            // Chỉ cho chọn trong danh sách, không gõ trực tiếp vào combobox
            cboSo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AcceptButton = btnCapNhat; // Enter = Cập nhật
        }

        // Giữ nguyên code hiện tại
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        // ===== Cập nhật =====
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string s = txtNhapSo.Text.Trim();

            if (s == "")
            {
                MessageBox.Show("Vui lòng nhập số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.Focus();
                return;
            }

            int so;
            if (!int.TryParse(s, out so) || so <= 0)
            {
                MessageBox.Show("Dữ liệu nhập phải là số nguyên dương!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapSo.SelectAll();
                txtNhapSo.Focus();
                return;
            }

            // Kiểm tra đã tồn tại trong combobox chưa
            foreach (object item in cboSo.Items)
            {
                if (Convert.ToInt32(item) == so)
                {
                    MessageBox.Show("Số " + so + " đã tồn tại trong danh sách!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNhapSo.SelectAll();
                    txtNhapSo.Focus();
                    return;
                }
            }

            cboSo.Items.Add(so);
            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        // ===== Chọn số trong combobox -> hiển thị ước số =====
        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUocSo.Items.Clear();
            if (cboSo.SelectedItem == null) return;

            int n = Convert.ToInt32(cboSo.SelectedItem);
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    lstUocSo.Items.Add(i);
            }
        }

        // ===== Tổng các ước số =====
        private void btnTong_Click(object sender, EventArgs e)
        {
            if (!CoDuLieu()) return;

            long tong = 0;
            foreach (object item in lstUocSo.Items)
                tong += Convert.ToInt32(item);

            MessageBox.Show("Tổng các ước số: " + tong, "Kết quả",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ===== Số lượng ước số chẵn =====
        private void btnSoChan_Click(object sender, EventArgs e)
        {
            if (!CoDuLieu()) return;

            int dem = 0;
            foreach (object item in lstUocSo.Items)
                if (Convert.ToInt32(item) % 2 == 0)
                    dem++;

            MessageBox.Show("Số lượng ước số chẵn: " + dem, "Kết quả",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ===== Số lượng ước số nguyên tố =====
        private void btnNguyenTo_Click(object sender, EventArgs e)
        {
            if (!CoDuLieu()) return;

            int dem = 0;
            foreach (object item in lstUocSo.Items)
                if (LaNguyenTo(Convert.ToInt32(item)))
                    dem++;

            MessageBox.Show("Số lượng ước số nguyên tố: " + dem, "Kết quả",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ===== Thoát =====
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        // ===== Hàm hỗ trợ =====
        private bool CoDuLieu()
        {
            if (lstUocSo.Items.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một số trong combobox!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool LaNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }
    }
}