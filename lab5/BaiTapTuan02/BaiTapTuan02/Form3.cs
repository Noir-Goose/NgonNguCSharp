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
    public partial class Form3 : Form
    {
        // Danh sách từ lưu sẵn trong List: { từ tiếng Anh, nghĩa tiếng Việt }
        private readonly List<string[]> duLieu = new List<string[]>
        {
            new[] { "student", "sinh viên, học sinh" },
            new[] { "teacher", "giáo viên, thầy giáo" },
            new[] { "worker",  "công nhân" },
            new[] { "hat",     "cái mũ" },
            new[] { "head",    "cái đầu" },
            new[] { "mouse",   "con chuột" },
            new[] { "cat",     "con mèo" },
            new[] { "dog",     "con chó" },
            new[] { "snake",   "con rắn" },
            new[] { "lamb",    "con cừu non" },
            new[] { "loan",    "khoản vay" },
            new[] { "frog",    "con ếch" },
            new[] { "sheep",   "con cừu" }
        };

        // Danh sách từ hiển thị trong ListBox (giữ đúng thứ tự)
        private readonly List<string> dsAnh = new List<string>();
        private readonly List<string> dsViet = new List<string>();

        // Tra nghĩa
        private readonly Dictionary<string, string> anhViet =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private readonly Dictionary<string, List<string>> vietAnh =
            new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

        private bool dangCapNhat = false;   // tránh gọi lặp sự kiện
        private int doDaiCuAnh = 0;         // độ dài text trước đó (để biết đang gõ hay đang xóa)
        private int doDaiCuViet = 0;

        public Form3()
        {
            InitializeComponent();
            KhoiTao();
        }

        // ===== Khởi tạo dữ liệu =====
        private void KhoiTao()
        {
            foreach (string[] t in duLieu)
            {
                string anh = t[0];
                string viet = t[1];

                dsAnh.Add(anh);
                anhViet[anh] = viet;

                // Mỗi nghĩa tiếng Việt (cách nhau dấu phẩy) là một từ tra Việt - Anh
                foreach (string v in viet.Split(','))
                {
                    string tuViet = v.Trim();
                    if (tuViet == "") continue;

                    if (!vietAnh.ContainsKey(tuViet))
                    {
                        vietAnh[tuViet] = new List<string>();
                        dsViet.Add(tuViet);
                    }
                    vietAnh[tuViet].Add(anh);
                }
            }

            lstAnh.Items.AddRange(dsAnh.ToArray());
            lstViet.Items.AddRange(dsViet.ToArray());

            ActiveControl = txtAnh;
        }

        // ===== Tab Anh - Việt =====
        private void txtAnh_TextChanged(object sender, EventArgs e)
        {
            XuLyGoChu(txtAnh, lstAnh, dsAnh, ref doDaiCuAnh);
        }

        private void txtAnh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TraAnhViet();
            }
        }

        private void lstAnh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChonTuTrongList(txtAnh, lstAnh, ref doDaiCuAnh);
        }

        private void lstAnh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idx = lstAnh.IndexFromPoint(e.Location);
            if (idx == ListBox.NoMatches) return;

            lstAnh.SelectedIndex = idx;
            TraAnhViet();
        }

        private void TraAnhViet()
        {
            string tu = txtAnh.Text.Trim();
            if (tu == "")
            {
                MessageBox.Show("Vui lòng nhập từ cần tra!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnh.Focus();
                return;
            }

            string nghia;
            if (anhViet.TryGetValue(tu, out nghia))
                txtNghiaViet.Text = nghia;
            else
                txtNghiaViet.Text = "Không tìm thấy từ \"" + tu + "\" trong từ điển.";
        }

        // ===== Tab Việt - Anh =====
        private void txtViet_TextChanged(object sender, EventArgs e)
        {
            XuLyGoChu(txtViet, lstViet, dsViet, ref doDaiCuViet);
        }

        private void txtViet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TraVietAnh();
            }
        }

        private void lstViet_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChonTuTrongList(txtViet, lstViet, ref doDaiCuViet);
        }

        private void lstViet_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idx = lstViet.IndexFromPoint(e.Location);
            if (idx == ListBox.NoMatches) return;

            lstViet.SelectedIndex = idx;
            TraVietAnh();
        }

        private void TraVietAnh()
        {
            string tu = txtViet.Text.Trim();
            if (tu == "")
            {
                MessageBox.Show("Vui lòng nhập từ cần tra!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtViet.Focus();
                return;
            }

            List<string> nghia;
            if (vietAnh.TryGetValue(tu, out nghia))
                txtNghiaAnh.Text = string.Join(", ", nghia);
            else
                txtNghiaAnh.Text = "Không tìm thấy từ \"" + tu + "\" trong từ điển.";
        }

        // ===== Đổi tab: đặt con trỏ vào ô nhập tương ứng =====
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabAnhViet)
                txtAnh.Focus();
            else
                txtViet.Focus();
        }

        // ===== Thoát =====
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===== Dùng chung cho 2 tab =====

        // Gõ chữ: dò đến từ khớp nhất, tự điền phần còn lại (bôi đen) giống hình
        private void XuLyGoChu(TextBox txt, ListBox lst, List<string> ds, ref int doDaiCu)
        {
            if (dangCapNhat) return;

            string s = txt.Text;
            bool dangGo = s.Length > doDaiCu;   // đang gõ thêm (không phải xóa)

            if (s.Length == 0)
            {
                lst.ClearSelected();
                lst.TopIndex = 0;
                doDaiCu = 0;
                return;
            }

            int idx = TimGanNhat(ds, s);
            if (idx < 0)
            {
                lst.ClearSelected();
                doDaiCu = s.Length;
                return;
            }

            dangCapNhat = true;

            lst.SelectedIndex = idx;
            lst.TopIndex = idx;

            // Khớp trọn phần đã gõ -> điền phần còn lại và bôi đen
            if (dangGo && ds[idx].Length > s.Length && DoDaiTienTo(ds[idx], s) == s.Length)
            {
                txt.Text = s + ds[idx].Substring(s.Length);
                txt.SelectionStart = s.Length;
                txt.SelectionLength = txt.Text.Length - s.Length;
            }

            dangCapNhat = false;
            doDaiCu = s.Length;
        }

        // Chọn một từ trong ListBox: đưa từ đó lên ô nhập
        private void ChonTuTrongList(TextBox txt, ListBox lst, ref int doDaiCu)
        {
            if (dangCapNhat || lst.SelectedIndex < 0) return;

            dangCapNhat = true;
            txt.Text = lst.SelectedItem.ToString();
            doDaiCu = txt.Text.Length;
            dangCapNhat = false;
        }

        // Tìm từ có phần đầu trùng nhiều ký tự nhất với chuỗi đã gõ
        private int TimGanNhat(List<string> ds, string s)
        {
            int best = -1;
            int bestLen = 0;
            for (int i = 0; i < ds.Count; i++)
            {
                int len = DoDaiTienTo(ds[i], s);
                if (len > bestLen)
                {
                    bestLen = len;
                    best = i;
                }
            }
            return best;
        }

        private int DoDaiTienTo(string a, string b)
        {
            int n = Math.Min(a.Length, b.Length);
            int i = 0;
            while (i < n && char.ToLowerInvariant(a[i]) == char.ToLowerInvariant(b[i]))
                i++;
            return i;
        }
    }
}