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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        // Load form: thêm dữ liệu vào ComboBox dân tộc
        private void Form6_Load(object sender, EventArgs e)
        {
            string[] danhSachDanToc = { "Kinh", "Tày", "Thái", "Mường", "Khmer", "Hoa",
                                        "Nùng", "H'Mông", "Dao", "Gia Rai", "Ê Đê", "Ba Na",
                                        "Chăm", "Khác" };
            cboDanToc.Items.AddRange(danhSachDanToc);
            cboDanToc.SelectedIndex = 0;
            txtMaSV.Focus();
        }

        // ================= THÊM =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;

            string maSV = txtMaSV.Text.Trim();

            // Không cho trùng mã sinh viên
            if (TimTheoMa(maSV) != null)
            {
                MessageBox.Show("Mã sinh viên \"" + maSV + "\" đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                txtMaSV.SelectAll();
                return;
            }

            ListViewItem item = new ListViewItem(maSV);
            item.SubItems.Add(txtHoTen.Text.Trim());
            item.SubItems.Add(rdoNam.Checked ? "Nam" : "Nữ");
            item.SubItems.Add(LayNgoaiNgu());
            item.SubItems.Add(cboDanToc.Text);
            lvSinhVien.Items.Add(item);

            LamMoi();
        }

        // ================= SỬA =================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!KiemTraDuLieu()) return;

            // Mã sinh viên không được sửa -> giữ nguyên SubItems[0]
            ListViewItem item = lvSinhVien.SelectedItems[0];
            item.SubItems[1].Text = txtHoTen.Text.Trim();
            item.SubItems[2].Text = rdoNam.Checked ? "Nam" : "Nữ";
            item.SubItems[3].Text = LayNgoaiNgu();
            item.SubItems[4].Text = cboDanToc.Text;

            LamMoi();
        }

        // ================= XÓA =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVienDangChon();
        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            XoaSinhVienDangChon();
        }

        private void XoaSinhVienDangChon()
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem item = lvSinhVien.SelectedItems[0];
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên \"" + item.SubItems[1].Text + "\"?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                lvSinhVien.Items.Remove(item);
                LamMoi();
            }
        }

        // Chỉ hiện menu chuột phải khi có dòng được chọn
        private void ctmsLV_Opening(object sender, CancelEventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        // ================= CHỌN DÒNG -> ĐỔ LÊN CONTROL =================
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0) return;

            ListViewItem item = lvSinhVien.SelectedItems[0];
            txtMaSV.Text = item.SubItems[0].Text;
            txtHoTen.Text = item.SubItems[1].Text;
            rdoNam.Checked = item.SubItems[2].Text == "Nam";
            rdoNu.Checked = item.SubItems[2].Text == "Nữ";

            // Tick lại các CheckBox ngoại ngữ theo chuỗi trong ListView
            string ngoaiNgu = item.SubItems[3].Text;
            chkAnh.Checked = ngoaiNgu.Contains("Anh");
            chkPhap.Checked = ngoaiNgu.Contains("Pháp");
            chkHoa.Checked = ngoaiNgu.Contains("Hoa");

            cboDanToc.Text = item.SubItems[4].Text;

            txtMaSV.ReadOnly = true; // Không cho sửa mã sinh viên
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        // ================= THOÁT =================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // việc hỏi xác nhận nằm ở FormClosing
        }

        // Hỏi xác nhận trước khi đóng Form (cả nút Thoát lẫn nút X)
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // ================= HÀM HỖ TRỢ =================
        private bool KiemTraDuLieu()
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return false;
            }
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }
            return true;
        }

        // Ghép các ngoại ngữ được tick thành chuỗi: "Anh, Pháp"
        private string LayNgoaiNgu()
        {
            List<string> ds = new List<string>();
            if (chkAnh.Checked) ds.Add("Anh");
            if (chkPhap.Checked) ds.Add("Pháp");
            if (chkHoa.Checked) ds.Add("Hoa");
            return string.Join(", ", ds);
        }

        // Tìm sinh viên theo mã (trả về null nếu chưa có)
        private ListViewItem TimTheoMa(string maSV)
        {
            foreach (ListViewItem item in lvSinhVien.Items)
            {
                if (string.Equals(item.SubItems[0].Text, maSV,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }
            return null;
        }

        private void LamMoi()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            rdoNam.Checked = true;
            chkAnh.Checked = true;   // mặc định tick Anh như trong hình
            chkPhap.Checked = false;
            chkHoa.Checked = false;
            cboDanToc.SelectedIndex = 0;
            txtMaSV.ReadOnly = false;
            lvSinhVien.SelectedItems.Clear();
            txtMaSV.Focus();
        }
    }
}