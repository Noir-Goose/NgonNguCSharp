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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculate GCD (Greatest Common Divisor) - UCLN
        /// Using Euclidean algorithm
        /// </summary>
        private long CalculateGCD(long a, long b)
        {
            // Convert to absolute values to handle negative numbers
            a = Math.Abs(a);
            b = Math.Abs(b);

            // Euclidean algorithm
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        /// <summary>
        /// Calculate LCM (Least Common Multiple) - BCNN
        /// Formula: LCM(a,b) = (a * b) / GCD(a,b)
        /// </summary>
        private long CalculateLCM(long a, long b)
        {
            long gcd = CalculateGCD(a, b);
            return (Math.Abs(a) * Math.Abs(b)) / gcd;
        }

        /// <summary>
        /// Validate input data
        /// </summary>
        private bool ValidateInput(out long numberA, out long numberB)
        {
            numberA = 0;
            numberB = 0;

            // Check if Number A is empty
            if (string.IsNullOrWhiteSpace(txtNumberA.Text))
            {
                MessageBox.Show("Vui lòng nhập số a!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumberA.Focus();
                return false;
            }

            // Check if Number B is empty
            if (string.IsNullOrWhiteSpace(txtNumberB.Text))
            {
                MessageBox.Show("Vui lòng nhập số b!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumberB.Focus();
                return false;
            }

            // Try to parse Number A
            if (!long.TryParse(txtNumberA.Text, out numberA))
            {
                MessageBox.Show("Số a phải là một số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumberA.Focus();
                txtNumberA.SelectAll();
                return false;
            }

            // Try to parse Number B
            if (!long.TryParse(txtNumberB.Text, out numberB))
            {
                MessageBox.Show("Số b phải là một số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumberB.Focus();
                txtNumberB.SelectAll();
                return false;
            }

            // Check if both numbers are zero
            if (numberA == 0 && numberB == 0)
            {
                MessageBox.Show("Số a và số b không thể cùng bằng 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumberA.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Clear all textboxes and results
        /// </summary>
        private void ClearFields()
        {
            txtNumberA.Clear();
            txtNumberB.Clear();
            lblResultGCD.Text = "-";
            lblResultLCM.Text = "-";
            txtNumberA.Focus();
        }

        // Event: Calculate button click
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateInput(out long numberA, out long numberB))
            {
                try
                {
                    long gcd = CalculateGCD(numberA, numberB);
                    long lcm = CalculateLCM(numberA, numberB);

                    lblResultGCD.Text = gcd.ToString();
                    lblResultLCM.Text = lcm.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tính toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event: Clear button click
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void txtNumberA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumberB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultGCD_Click(object sender, EventArgs e)
        {

        }

        private void lblResultLCM_Click(object sender, EventArgs e)
        {

        }
    }
}
