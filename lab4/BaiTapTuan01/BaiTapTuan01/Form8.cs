namespace BaiTapTuan01
{
    public partial class Form8 : Form
    {
        private readonly IntegerArrayManager _arrayManager = new IntegerArrayManager();

        // Nhóm "Xóa" trong Designer không có TextBox nên tạo thêm bằng code
        private TextBox textBoxXoa = new TextBox();

        public Form8()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            FormClosing += Form8_FormClosing;

            textBoxXoa.Location = new Point(137, 40);
            textBoxXoa.Size = new Size(45, 27);
            groupBox3.Controls.Add(textBoxXoa);

            button1.Click += btnLoadArray_Click;   // Nhập mảng
            button2.Click += btnReset_Click;       // Reset
            button3.Click += (s, e) => Close();    // Thoát
            button4.Click += btnExecute_Click;     // Thực hiện
            button5.Click += btnSum_Click;         // Tổng
            button6.Click += btnMaxMin_Click;      // Tìm Max-Min
        }

        private void Form8_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đóng form này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }

        #region Helpers

        private static void Warn(string message) =>
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private bool TryInt(TextBox box, string name, out int value)
        {
            if (int.TryParse(box.Text.Trim(), out value))
                return true;

            Warn($"{name} phải là số nguyên.");
            box.Focus();
            return false;
        }

        private bool TryParseArray(string input, out int[] result)
        {
            result = Array.Empty<int>();
            if (string.IsNullOrWhiteSpace(input))
            {
                Warn("Hãy nhập các số cách nhau bằng dấu phẩy.\nVí dụ: 1, 2, 3, 4, 5");
                return false;
            }

            try
            {
                result = input.Split(',')
                    .Select(s => s.Trim())
                    .Where(s => s.Length > 0)
                    .Select(int.Parse)
                    .ToArray();
                return result.Length > 0;
            }
            catch (Exception ex) when (ex is FormatException || ex is OverflowException)
            {
                Warn("Dữ liệu không hợp lệ. Hãy nhập số nguyên cách nhau bằng dấu phẩy.\nVí dụ: 1, 2, 3, 4, 5");
                return false;
            }
        }

        private void UpdateDisplay()
        {
            textBox2.Text = _arrayManager.Count == 0 ? string.Empty : _arrayManager.ToString();
        }

        private void ClearInputs(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb) tb.Clear();
                else if (c is RadioButton rb) rb.Checked = false;
                else if (c.HasChildren) ClearInputs(c);
            }
        }

        private void ClearSelections()
        {
            radioButton1.Checked = radioButton2.Checked = false;
            radioButton3.Checked = radioButton4.Checked = false;
            radioButton5.Checked = radioButton6.Checked = false;
            radioButton7.Checked = false;
            textBoxXoa.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
        }

        #endregion

        #region Event Handlers

        // Nhập mảng: textBox1 -> _arrayManager -> textBox2
        private void btnLoadArray_Click(object? sender, EventArgs e)
        {
            if (TryParseArray(textBox1.Text, out int[] values))
            {
                _arrayManager.Initialize(values);
                UpdateDisplay();
            }
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            _arrayManager.Clear();
            ClearInputs(this);
        }

        // Thực hiện: chạy mọi nhóm đang được chọn (Sắp xếp, Tìm kiếm, Xóa, Thêm)
        // và nhóm Thay thế nếu đã điền "Số thay thế".
        private void btnExecute_Click(object? sender, EventArgs e)
        {
            try
            {
                bool didSomething = false;

                // Sắp xếp
                if (radioButton1.Checked) { _arrayManager.SortAscending(); didSomething = true; }
                else if (radioButton2.Checked) { _arrayManager.SortDescending(); didSomething = true; }

                // Tìm kiếm
                if (radioButton3.Checked) { if (!SearchByValue()) return; didSomething = true; }
                else if (radioButton4.Checked) { if (!SearchByPosition()) return; didSomething = true; }

                // Xóa
                if (radioButton5.Checked) { if (!DeleteByValue()) return; didSomething = true; }
                else if (radioButton6.Checked) { if (!DeleteByPosition()) return; didSomething = true; }

                // Thêm
                if (radioButton7.Checked) { if (!InsertValue()) return; didSomething = true; }

                // Thay thế
                if (!string.IsNullOrWhiteSpace(textBox13.Text)) { if (!Replace()) return; didSomething = true; }

                if (!didSomething)
                {
                    Warn("Hãy chọn một thao tác (Sắp xếp, Tìm kiếm, Xóa, Thêm) hoặc điền ô Thay thế.");
                    return;
                }

                UpdateDisplay();
                ClearSelections();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Warn("Vị trí không hợp lệ: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Warn(ex.Message);
            }
        }

        private void btnSum_Click(object? sender, EventArgs e)
        {
            if (_arrayManager.Count == 0) { Warn("Mảng đang rỗng."); return; }

            textBox8.Text = _arrayManager.GetSum().ToString();
            textBox9.Text = _arrayManager.GetEvenSum().ToString();
            textBox10.Text = _arrayManager.GetOddSum().ToString();
        }

        private void btnMaxMin_Click(object? sender, EventArgs e)
        {
            if (_arrayManager.Count == 0) { Warn("Mảng đang rỗng."); return; }

            textBox11.Text = _arrayManager.GetMaxValue().ToString();
            textBox12.Text = _arrayManager.GetMinValue().ToString();
        }

        // Các handler này được Designer tham chiếu nên phải giữ lại
        private void label4_Click(object? sender, EventArgs e) { }
        private void label5_Click(object? sender, EventArgs e) { }
        private void label7_Click(object? sender, EventArgs e) { }
        private void textBox11_TextChanged(object? sender, EventArgs e) { }

        #endregion

        #region Operations (mỗi hàm trả về false nếu dữ liệu nhập sai)

        // Tìm giá trị: nhập giá trị ở textBox3 -> hiện các vị trí ở textBox5
        private bool SearchByValue()
        {
            if (!TryInt(textBox3, "Giá trị cần tìm", out int value)) return false;

            List<int> indices = _arrayManager.SearchValue(value);
            textBox5.Text = indices.Count == 0 ? "Không có" : string.Join(", ", indices);
            return true;
        }

        // Tìm vị trí: nhập vị trí ở textBox4 -> hiện giá trị ở textBox5
        private bool SearchByPosition()
        {
            if (!TryInt(textBox4, "Vị trí cần tìm", out int index)) return false;

            textBox5.Text = _arrayManager.GetAt(index).ToString();
            return true;
        }

        private bool DeleteByValue()
        {
            if (!TryInt(textBoxXoa, "Giá trị cần xóa", out int value)) return false;

            List<int> indices = _arrayManager.SearchValue(value);
            if (indices.Count == 0)
            {
                Warn($"Không tìm thấy giá trị {value} trong mảng.");
                return false;
            }

            // Xóa từ cuối về đầu để vị trí không bị lệch
            foreach (int i in indices.OrderByDescending(x => x))
                _arrayManager.RemoveAt(i);

            return true;
        }

        private bool DeleteByPosition()
        {
            if (!TryInt(textBoxXoa, "Vị trí cần xóa", out int index)) return false;

            _arrayManager.RemoveAt(index);
            return true;
        }

        // Thêm: giá trị ở textBox6, vị trí ở textBox7
        private bool InsertValue()
        {
            if (!TryInt(textBox6, "Giá trị cần thêm", out int value)) return false;
            if (!TryInt(textBox7, "Vị trí cần thêm", out int index)) return false;

            _arrayManager.InsertAt(index, value);
            return true;
        }

        // Thay thế: số thay thế ở textBox13.
        // Điền textBox15 -> thay mọi giá trị đó; điền textBox14 -> thay tại vị trí đó.
        private bool Replace()
        {
            if (!TryInt(textBox13, "Số thay thế", out int newValue)) return false;

            if (!string.IsNullOrWhiteSpace(textBox15.Text))
            {
                if (!TryInt(textBox15, "Giá trị cần thay thế", out int oldValue)) return false;

                int count = _arrayManager.ReplaceValue(oldValue, newValue);
                if (count == 0)
                {
                    Warn($"Không tìm thấy giá trị {oldValue} trong mảng.");
                    return false;
                }
                return true;
            }

            if (!string.IsNullOrWhiteSpace(textBox14.Text))
            {
                if (!TryInt(textBox14, "Vị trí cần thay thế", out int index)) return false;

                _arrayManager.ReplaceAtIndex(index, newValue);
                return true;
            }

            Warn("Hãy điền \"Giá trị cần thay thế\" hoặc \"Vị trí cần thay thế\".");
            return false;
        }

        #endregion
    }
}