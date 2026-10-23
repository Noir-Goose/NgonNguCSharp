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
    public partial class Form2 : Form
    {
        // Thông tin sinh viên lưu trong Tag của node mã SV
        private class SinhVien
        {
            public string MaSV;
            public string HoTen;
            public string DiaChi;
        }

        private TreeNode nodeGoc;

        public Form2()
        {
            InitializeComponent();
            KhoiTao();
        }

        // Giữ nguyên handler cũ
        private void button2_Click(object sender, EventArgs e)
        {

        }

        // ===== Khởi tạo dữ liệu ban đầu =====
        private void KhoiTao()
        {
            tvLop.Nodes.Clear();
            nodeGoc = tvLop.Nodes.Add("Danh sách lớp");

            string[] dsLop = { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" };
            foreach (string lop in dsLop)
            {
                nodeGoc.Nodes.Add(lop);
                cboLop.Items.Add(lop);
            }
            nodeGoc.Expand();
            cboLop.SelectedIndex = 0;

            chkThemLop.Checked = false;
            grpThongTinLop.Visible = false;
        }

        // ===== Checkbox Thêm lớp: ẩn/hiện groupbox =====
        private void chkThemLop_CheckedChanged(object sender, EventArgs e)
        {
            grpThongTinLop.Visible = chkThemLop.Checked;
            if (chkThemLop.Checked)
                txtTenLop.Focus();
        }

        // ===== Thêm lớp =====
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string tenLop = txtTenLop.Text.Trim();

            if (tenLop == "")
            {
                MessageBox.Show("Tên lớp không được để trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            if (TimNodeLop(tenLop) != null)
            {
                MessageBox.Show("Lớp " + tenLop + " đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.SelectAll();
                txtTenLop.Focus();
                return;
            }

            nodeGoc.Nodes.Add(tenLop);
            cboLop.Items.Add(tenLop);
            nodeGoc.Expand();

            txtTenLop.Clear();
            txtTenLop.Focus();
        }

        // ===== Cập nhật: thêm sinh viên vào lớp đang chọn =====
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (cboLop.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLop.Focus();
                return;
            }
            if (ma == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return;
            }
            if (hoTen == "")
            {
                MessageBox.Show("Họ tên không được để trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (diaChi == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (TonTaiMaSV(ma))
            {
                MessageBox.Show("Mã sinh viên " + ma + " đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.SelectAll();
                txtMaSV.Focus();
                return;
            }

            TreeNode nodeLop = TimNodeLop(cboLop.SelectedItem.ToString());
            if (nodeLop == null) return;

            TreeNode nodeSV = new TreeNode(ma);
            nodeSV.Tag = new SinhVien { MaSV = ma, HoTen = hoTen, DiaChi = diaChi };
            nodeSV.Nodes.Add("Họ tên: " + hoTen);
            nodeSV.Nodes.Add("Địa chỉ: " + diaChi);

            nodeLop.Nodes.Add(nodeSV);
            nodeLop.Expand();

            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtMaSV.Focus();
        }

        // ===== Xóa sinh viên đang chọn =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            TreeNode node = tvLop.SelectedNode;

            if (node == null || !(node.Tag is SinhVien))
            {
                MessageBox.Show("Vui lòng chọn một sinh viên (node mã SV) trên TreeView để xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên " + node.Text + "?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                node.Remove();
                txtMaSV.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();
            }
        }

        // ===== Click node sinh viên -> hiển thị thông tin =====
        private void tvLop_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SinhVien sv = e.Node.Tag as SinhVien;
            if (sv != null)
            {
                txtMaSV.Text = sv.MaSV;
                txtHoTen.Text = sv.HoTen;
                txtDiaChi.Text = sv.DiaChi;
            }
        }

        // ===== Hàm hỗ trợ =====
        private TreeNode TimNodeLop(string tenLop)
        {
            foreach (TreeNode lop in nodeGoc.Nodes)
                if (string.Equals(lop.Text, tenLop, StringComparison.OrdinalIgnoreCase))
                    return lop;
            return null;
        }

        private bool TonTaiMaSV(string ma)
        {
            foreach (TreeNode lop in nodeGoc.Nodes)
                foreach (TreeNode sv in lop.Nodes)
                    if (string.Equals(sv.Text, ma, StringComparison.OrdinalIgnoreCase))
                        return true;
            return false;
        }
    }
}