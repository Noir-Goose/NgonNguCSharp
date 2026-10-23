using System;
using System.Windows.Forms;

namespace BaiTapTuan01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            // Show button - display name and age
            string name = textBox1.Text.Trim();
            string yobText = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(yobText, out int yob))
            {
                MessageBox.Show("Year of birth is invalid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int age = DateTime.Now.Year - yob;
            if (age < 0)
            {
                MessageBox.Show("Year of birth is in the future.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string msg = $"Tên: {name}\nTuổi: {age}";
            MessageBox.Show(msg, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            // Clear button
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button3_Click(object? sender, EventArgs e)
        {
            // Exit button
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void BaiTap01_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
