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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // Khi form load: tạo các node gốc từ A -> Z
        private void Form5_Load(object sender, EventArgs e)
        {
            tvDanhBa.Nodes.Clear();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                TreeNode nodeChuCai = new TreeNode(c.ToString());
                nodeChuCai.Name = c.ToString();
                tvDanhBa.Nodes.Add(nodeChuCai);
            }
            txtHoTen.Focus();
        }

        // Thêm liên hệ vào node tương ứng với chữ cái đầu của tên
        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            // Kiểm tra dữ liệu nhập
            if (hoTen == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (sdt == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            // Lấy chữ cái đầu của tên (bỏ dấu tiếng Việt, đổi thành chữ hoa)
            char chuCaiDau = LayChuCaiDau(hoTen);
            if (chuCaiDau < 'A' || chuCaiDau > 'Z')
            {
                MessageBox.Show("Tên phải bắt đầu bằng một chữ cái!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // Tìm node gốc tương ứng
            TreeNode nodeCha = tvDanhBa.Nodes[chuCaiDau.ToString()];

            // Tạo node con: hiển thị "Họ tên - SĐT"
            TreeNode nodeMoi = new TreeNode(hoTen);
            nodeMoi.Tag = sdt; // lưu số điện thoại vào Tag
            nodeCha.Nodes.Add(nodeMoi);

            // Mở node cha và chọn node vừa thêm
            nodeCha.Expand();
            tvDanhBa.SelectedNode = nodeMoi;

            // Xóa ô nhập để nhập người tiếp theo
            txtHoTen.Clear();
            txtSDT.Clear();
            txtHoTen.Focus();
        }

        // Khi chọn một liên hệ: hiển thị lại thông tin lên TextBox
        private void tvDanhBa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Chỉ node con (có node cha) mới là liên hệ
            if (e.Node != null && e.Node.Parent != null)
            {
                txtHoTen.Text = e.Node.Text;
                txtSDT.Text = e.Node.Tag != null ? e.Node.Tag.ToString() : "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Lấy chữ cái đầu tiên, chuyển về chữ A-Z không dấu
        private char LayChuCaiDau(string ten)
        {
            char c = char.ToUpper(ten[0]);

            // Xử lý riêng chữ Đ
            if (c == 'Đ') return 'D';

            // Bỏ dấu tiếng Việt bằng cách tách ký tự (Normalization Form D)
            string chuoiChuan = c.ToString().Normalize(NormalizationForm.FormD);
            foreach (char ch in chuoiChuan)
            {
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(ch)
                    != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    return ch;
                }
            }
            return c;
        }
    }
}