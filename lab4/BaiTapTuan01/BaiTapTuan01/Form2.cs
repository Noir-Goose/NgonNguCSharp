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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Level 2: Prevent non-numeric input
        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, decimal point, negative sign
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt?.Text.Contains(".") == true)
            {
                e.Handled = true;
            }

            // Only allow negative sign at the beginning
            if (e.KeyChar == '-' && txt?.Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        // Level 1: Validation for txtA
        private void TxtA_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(txtA.Text, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtA, "Vui lòng nhập một số hợp lệ cho a!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtA, "");
            }
        }

        // Level 1: Validation for txtB
        private void TxtB_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(txtB.Text, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtB, "Vui lòng nhập một số hợp lệ cho b!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtB, "");
            }
        }

        // Check if both inputs are valid
        private bool ValidateInputs()
        {
            bool aValid = double.TryParse(txtA.Text, out _);
            bool bValid = double.TryParse(txtB.Text, out _);

            if (!aValid)
            {
                errorProvider1.SetError(txtA, "Vui lòng nhập một số hợp lệ cho a!");
                MessageBox.Show("Dữ liệu nhập cho a không phù hợp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                errorProvider1.SetError(txtA, "");
            }

            if (!bValid)
            {
                errorProvider1.SetError(txtB, "Vui lòng nhập một số hợp lệ cho b!");
                MessageBox.Show("Dữ liệu nhập cho b không phù hợp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                errorProvider1.SetError(txtB, "");
            }

            return true;
        }

        // Addition
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double result = a + b;
                txtResult.Text = result.ToString();
            }
        }

        // Subtraction
        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double result = a - b;
                txtResult.Text = result.ToString();
            }
        }

        // Multiplication
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double result = a * b;
                txtResult.Text = result.ToString();
            }
        }

        // Division
        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);

                if (b == 0)
                {
                    errorProvider1.SetError(txtB, "Số b không thể bằng 0!");
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = a / b;
                txtResult.Text = result.ToString();
            }
        }

        // Clear all fields
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtResult.Clear();
            errorProvider1.SetError(txtA, "");
            errorProvider1.SetError(txtB, "");
            txtA.Focus();
        }

        // Confirm before closing
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đóng ứng dụng?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
