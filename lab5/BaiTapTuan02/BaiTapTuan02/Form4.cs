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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Giữ nguyên handler cũ
        private void button2_Click(object sender, EventArgs e)
        {

        }

        // ===== Nhập: thêm số tự nhiên vào listbox =====
        private void btnNhap_Click(object sender, EventArgs e)
        {
            string s = txtNhap.Text.Trim();

            if (s == "")
            {
                MessageBox.Show("Vui lòng nhập số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhap.Focus();
                return;
            }

            long so;
            if (!long.TryParse(s, out so) || so < 0)
            {
                MessageBox.Show("Dữ liệu nhập phải là số tự nhiên!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhap.SelectAll();
                txtNhap.Focus();
                return;
            }

            lstSo.Items.Add(so);
            txtNhap.Clear();
            txtNhap.Focus();
        }

        // ===== Tổng các phần tử =====
        private void btnTong_Click(object sender, EventArgs e)
        {
            if (!CoDuLieu()) return;

            try
            {
                long tong = 0;
                for (int i = 0; i < lstSo.Items.Count; i++)
                    tong = checked(tong + LayGiaTri(i));

                MessageBox.Show("Tổng các phần tử trong ListBox: " + tong, "Kết quả",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Tổng vượt quá giới hạn của kiểu dữ liệu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== Xóa phần tử đầu và cuối =====
        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (!CoDuLieu()) return;

            if (lstSo.Items.Count == 1)
            {
                lstSo.Items.RemoveAt(0);
                return;
            }

            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
            lstSo.Items.RemoveAt(0);
        }

        // ===== Xóa các phần tử đang chọn =====
        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (lstSo.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phần tử cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xóa từ cuối lên đầu để chỉ số không bị lệch
            List<int> dsChon = new List<int>();
            foreach (int idx in lstSo.SelectedIndices)
                dsChon.Add(idx);

            for (int i = dsChon.Count - 1; i >= 0; i--)
                lstSo.Items.RemoveAt(dsChon[i]);
        }

        // ===== Tăng mỗi phần tử lên 2 =====
        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (!CoDuLieu()) return;

            try
            {
                CapNhatTatCa(x => checked(x + 2));
            }
            catch (OverflowException)
            {
                MessageBox.Show("Giá trị vượt quá giới hạn của kiểu dữ liệu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== Thay mỗi phần tử bằng bình phương =====
        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            if (!CoDuLieu()) return;

            try
            {
                CapNhatTatCa(x => checked(x * x));
            }
            catch (OverflowException)
            {
                MessageBox.Show("Bình phương vượt quá giới hạn của kiểu dữ liệu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== Chọn các số chẵn =====
        private void btnChonChan_Click(object sender, EventArgs e)
        {
            if (!CoDuLieu()) return;

            lstSo.ClearSelected();
            for (int i = 0; i < lstSo.Items.Count; i++)
                if (LayGiaTri(i) % 2 == 0)
                    lstSo.SetSelected(i, true);
        }

        // ===== Chọn các số lẻ =====
        private void btnChonLe_Click(object sender, EventArgs e)
        {
            if (!CoDuLieu()) return;

            lstSo.ClearSelected();
            for (int i = 0; i < lstSo.Items.Count; i++)
                if (LayGiaTri(i) % 2 != 0)
                    lstSo.SetSelected(i, true);
        }

        // ===== Kết thúc =====
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===== Hàm hỗ trợ =====
        private bool CoDuLieu()
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang rỗng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private long LayGiaTri(int i)
        {
            return Convert.ToInt64(lstSo.Items[i]);
        }

        // Tính giá trị mới cho toàn bộ phần tử trước, nếu không lỗi mới ghi lại vào listbox
        private void CapNhatTatCa(Func<long, long> f)
        {
            int n = lstSo.Items.Count;
            long[] moi = new long[n];
            for (int i = 0; i < n; i++)
                moi[i] = f(LayGiaTri(i));

            // Lưu lại các phần tử đang chọn để chọn lại sau khi cập nhật
            List<int> dsChon = new List<int>();
            foreach (int idx in lstSo.SelectedIndices)
                dsChon.Add(idx);

            lstSo.BeginUpdate();
            for (int i = 0; i < n; i++)
                lstSo.Items[i] = moi[i];
            foreach (int idx in dsChon)
                lstSo.SetSelected(idx, true);
            lstSo.EndUpdate();
        }
    }
}