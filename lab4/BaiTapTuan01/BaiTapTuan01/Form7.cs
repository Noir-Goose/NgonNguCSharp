using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan01
{
    public partial class Form7 : Form
    {
        // Các hằng số
        private const double EPSILON = 1e-10;

        public Form7()
        {
            InitializeComponent();
            // Kết nối sự kiện cho các RadioButton
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;

            // Kết nối sự kiện cho TextBox để kiểm tra liên tục
            textBox1.TextChanged += TextBox_TextChanged;
            textBox2.TextChanged += TextBox_TextChanged;
            textBox3.TextChanged += TextBox_TextChanged;

            // Kết nối sự kiện cho Button Giải
            button1.Click += Button1_Click;

            // Kết nối sự kiện cho Button Thoát
            button2.Click += Button2_Click;

            // Kết nối sự kiện cho Form Close
            this.FormClosing += Form7_FormClosing;
        }

        /// <summary>
        /// Xử lý sự kiện khi Form được load lên
        /// Khởi tạo trạng thái ban đầu
        /// </summary>
        private void Form7_Load(object sender, EventArgs e)
        {
            // Khởi tạo trạng thái ban đầu
            radioButton1.Checked = true; // Mặc định chọn giải phương trình bậc nhất
            button1.Enabled = false;     // Button "Giải" mờ đi
            textBox4.ReadOnly = true;    // TextBox Kết quả chỉ đọc
            textBox4.BackColor = Color.LightGray; // Làm cho nó trông như disabled

            // Ẩn TextBox Nhập c lúc đầu (bậc nhất không cần c)
            textBox3.Enabled = false;
            label5.Enabled = false;
            textBox3.BackColor = Color.LightGray;

            // Đặt focus vào TextBox a
            textBox1.Focus();
        }

        /// <summary>
        /// Xử lý sự kiện khi chọn RadioButton (Bậc nhất / Bậc hai)
        /// </summary>
        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            // Xóa dữ liệu cũ
            ClearAllInputs();

            if (radioButton1.Checked)
            {
                // Chế độ: Giải phương trình bậc nhất (ax + b = 0)
                label5.Text = "Ẩn"; // Hoặc có thể ẩn label
                textBox3.Enabled = false;
                label5.Enabled = false;
                textBox3.BackColor = Color.LightGray;
                textBox1.Focus();
            }
            else if (radioButton2.Checked)
            {
                // Chế độ: Giải phương trình bậc hai (ax² + bx + c = 0)
                label5.Text = "Nhập c";
                textBox3.Enabled = true;
                label5.Enabled = true;
                textBox3.BackColor = SystemColors.Window;
                textBox1.Focus();
            }

            // Kiểm tra nút Giải có nên bật không
            CheckSolveButtonState();
        }

        /// <summary>
        /// Xử lý sự kiện khi thay đổi nội dung TextBox
        /// </summary>
        private void TextBox_TextChanged(object? sender, EventArgs e)
        {
            CheckSolveButtonState();
        }

        /// <summary>
        /// Kiểm tra xem nút "Giải" có nên được bật hay không
        /// </summary>
        private void CheckSolveButtonState()
        {
            bool isValid = false;

            if (radioButton1.Checked)
            {
                // Phương trình bậc nhất: cần a và b
                isValid = IsValidNumber(textBox1.Text) && IsValidNumber(textBox2.Text);
            }
            else if (radioButton2.Checked)
            {
                // Phương trình bậc hai: cần a, b, c
                isValid = IsValidNumber(textBox1.Text) && 
                         IsValidNumber(textBox2.Text) && 
                         IsValidNumber(textBox3.Text);
            }

            button1.Enabled = isValid;
            button1.ForeColor = isValid ? Color.Red : Color.LightGray; // Làm cho cảm giác bị disable
        }

        /// <summary>
        /// Kiểm tra xem chuỗi có phải là số hợp lệ không
        /// </summary>
        private bool IsValidNumber(string? text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            return double.TryParse(text, out _);
        }

        /// <summary>
        /// Xử lý sự kiện khi nhấn nút "Giải"
        /// </summary>
        private void Button1_Click(object? sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    // Giải phương trình bậc nhất
                    SolveLinearEquation();
                }
                else if (radioButton2.Checked)
                {
                    // Giải phương trình bậc hai
                    SolveQuadraticEquation();
                }

                // Vô hiệu hóa nút Giải sau khi đã giải
                button1.Enabled = false;
                button1.ForeColor = Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Giải phương trình bậc nhất: ax + b = 0
        /// </summary>
        private void SolveLinearEquation()
        {
            if (!double.TryParse(textBox1.Text, out double a) ||
                !double.TryParse(textBox2.Text, out double b))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result;

            // Kiểm tra a
            if (Math.Abs(a) < EPSILON)
            {
                // Phương trình trở thành: 0x + b = 0 => b = 0
                if (Math.Abs(b) < EPSILON)
                {
                    result = "Phương trình có vô số nghiệm";
                }
                else
                {
                    result = "Phương trình vô nghiệm";
                }
            }
            else
            {
                // Phương trình có một nghiệm: x = -b/a
                double x = -b / a;
                result = $"x = {x:F6}";
            }

            textBox4.Text = result;
        }

        /// <summary>
        /// Giải phương trình bậc hai: ax² + bx + c = 0
        /// </summary>
        private void SolveQuadraticEquation()
        {
            if (!double.TryParse(textBox1.Text, out double a) ||
                !double.TryParse(textBox2.Text, out double b) ||
                !double.TryParse(textBox3.Text, out double c))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result;

            // Kiểm tra a
            if (Math.Abs(a) < EPSILON)
            {
                // Không phải phương trình bậc hai, chuyển thành bậc nhất: bx + c = 0
                if (Math.Abs(b) < EPSILON)
                {
                    if (Math.Abs(c) < EPSILON)
                    {
                        result = "Phương trình có vô số nghiệm";
                    }
                    else
                    {
                        result = "Phương trình vô nghiệm";
                    }
                }
                else
                {
                    double x = -c / b;
                    result = $"Đây là phương trình bậc nhất!\nx = {x:F6}";
                }
            }
            else
            {
                // Phương trình bậc hai: Tính Delta
                double delta = b * b - 4 * a * c;

                if (delta < -EPSILON)
                {
                    result = "Phương trình vô nghiệm (Δ < 0)";
                }
                else if (Math.Abs(delta) < EPSILON)
                {
                    // Delta = 0: một nghiệm kép
                    double x = -b / (2 * a);
                    result = $"Phương trình có nghiệm kép:\nx = {x:F6}";
                }
                else
                {
                    // Delta > 0: hai nghiệm phân biệt
                    double sqrtDelta = Math.Sqrt(delta);
                    double x1 = (-b + sqrtDelta) / (2 * a);
                    double x2 = (-b - sqrtDelta) / (2 * a);
                    result = $"Phương trình có 2 nghiệm:\nx₁ = {x1:F6}\nx₂ = {x2:F6}";
                }
            }

            textBox4.Text = result;
        }

        /// <summary>
        /// Xóa tất cả dữ liệu nhập và kết quả
        /// </summary>
        private void ClearAllInputs()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            button1.Enabled = false;
            button1.ForeColor = Color.LightGray;
        }

        /// <summary>
        /// Xử lý sự kiện khi nhấn nút "Thoát"
        /// </summary>
        private void Button2_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Xử lý sự kiện khi chuỗi sắp đóng Form
        /// Yêu cầu xác nhận từ người dùng
        /// </summary>
        private void Form7_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát?\nTất cả dữ liệu sẽ bị mất!",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Không cần xử lý gì đặc biệt ở đây
        }
    }
}
