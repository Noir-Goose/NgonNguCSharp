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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        // Arrays for number to word conversion
        private static readonly string[] ones = 
        { 
            "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" 
        };

        private static readonly string[] teens = 
        { 
            "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười năm",
            "mười sáu", "mười bảy", "mười tám", "mười chín"
        };

        private static readonly string[] tens = 
        { 
            "", "", "hai mươi", "ba mươi", "bốn mươi", "năm mươi",
            "sáu mươi", "bảy mươi", "tám mươi", "chín mươi"
        };

        /// <summary>
        /// Convert a two-digit number to words
        /// </summary>
        private string ConvertTwoDigits(int number)
        {
            if (number == 0)
                return "";
            else if (number < 10)
                return ones[number];
            else if (number < 20)
                return teens[number - 10];
            else
            {
                int tensPart = number / 10;
                int onesPart = number % 10;

                if (onesPart == 0)
                    return tens[tensPart];
                else if (onesPart == 5 && tensPart > 1)
                    return tens[tensPart] + " lăm";
                else
                    return tens[tensPart] + " " + ones[onesPart];
            }
        }

        /// <summary>
        /// Convert any number from 1 to 999 to Vietnamese words
        /// </summary>
        private string ConvertNumberToWords(int number)
        {
            if (number <= 0 || number > 999)
                return "";

            if (number < 10)
                return ones[number];

            if (number < 100)
                return ConvertTwoDigits(number);

            // For hundreds (100-999)
            int hundreds = number / 100;
            int remainder = number % 100;

            string result = ones[hundreds] + " trăm";

            if (remainder == 0)
                return result;
            else if (remainder < 10)
            {
                // For numbers like 101, 102, etc.
                return result + " lẻ " + ones[remainder];
            }
            else
            {
                // For numbers like 110, 111, etc.
                return result + " " + ConvertTwoDigits(remainder);
            }
        }

        /// <summary>
        /// Validate and process input
        /// </summary>
        private void ProcessInput()
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Vui lòng nhập một số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Focus();
                return;
            }

            if (!int.TryParse(txtInput.Text, out int number))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.SelectAll();
                txtInput.Focus();
                return;
            }

            if (number < 1 || number > 999)
            {
                MessageBox.Show("Vui lòng nhập một số từ 1 đến 999!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.SelectAll();
                txtInput.Focus();
                return;
            }

            // Convert and display result
            string result = ConvertNumberToWords(number);

            // Capitalize first letter
            if (!string.IsNullOrEmpty(result))
            {
                result = char.ToUpper(result[0]) + result.Substring(1);
            }

            txtOutput.Text = result;
        }

        /// <summary>
        /// Clear all fields and reset form
        /// </summary>
        private void ResetForm()
        {
            txtInput.Clear();
            txtOutput.Clear();
            txtInput.Focus();
        }

        // Event: Execute button click
        private void BtnExecute_Click(object sender, EventArgs e)
        {
            ProcessInput();
        }

        // Event: Clear button click
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Event: Exit button click
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?",
                                                  "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Event: Form closing
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng form?",
                                                      "Xác nhận đóng",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
