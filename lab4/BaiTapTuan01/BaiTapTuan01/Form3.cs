using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Validate email format using regex
        /// </summary>
        private bool IsValidEmail(string email)
        {
            try
            {
                // Email validation pattern
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Validate required fields
        /// </summary>
        private bool ValidateRequiredFields()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và Tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập Địa chỉ email!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập Xác nhận mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Display registration information
        /// </summary>
        private void DisplayRegistrationInfo()
        {
            string info = $"Thông tin đăng ký:\n\n" +
                          $"Họ và Tên: {txtFullName.Text}\n" +
                          $"Tên đăng nhập: {txtUsername.Text}\n" +
                          $"Địa chỉ email: {txtEmail.Text}\n" +
                          $"Mật khẩu: {txtPassword.Text}\n" +
                          $"Xác nhận mật khẩu: {txtConfirmPassword.Text}";

            MessageBox.Show(info, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Clear all textboxes
        /// </summary>
        private void ClearFields()
        {
            txtFullName.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtFullName.Focus();
        }

        // Event: Email textbox Leave (check email format after leaving)
        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Định dạng email không hợp lệ!\nVui lòng nhập email hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
        }

        // Event: Register button click
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateRequiredFields())
            {
                DisplayRegistrationInfo();
                ClearFields();
            }
        }

        // Event: Clear button click
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Event: Enter key in Confirm Password textbox
        private void TxtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                BtnRegister_Click(sender, e);
            }
        }

        // Event: Form closing - ask for confirmation
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
