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
    public partial class Form5 : Form
    {
        private List<int> numbers = new List<int>();

        public Form5()
        {
            InitializeComponent();
            this.Text = "Form5 - Nhập dãy số và tính tổng";
            this.Width = 800;
            this.Height = 550;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int number))
            {
                numbers.Add(number);
                txtInput.Clear();
                txtInput.Focus();
                UpdateArrayDisplay();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
            {
                MessageBox.Show("Dãy số trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int sum = numbers.Sum();
            txtSum.Text = sum.ToString();
        }

        private void btnSumEven_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
            {
                MessageBox.Show("Dãy số trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int sumEven = numbers.Where(n => n % 2 == 0).Sum();
            txtSumEven.Text = sumEven.ToString();
        }

        private void btnSumOdd_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
            {
                MessageBox.Show("Dãy số trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int sumOdd = numbers.Where(n => n % 2 != 0).Sum();
            txtSumOdd.Text = sumOdd.ToString();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void UpdateArrayDisplay()
        {
            txtArray.Text = string.Join(", ", numbers);
        }

        private void ResetForm()
        {
            numbers.Clear();
            txtInput.Clear();
            txtArray.Clear();
            txtSum.Clear();
            txtSumEven.Clear();
            txtSumOdd.Clear();
            txtInput.Focus();
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblInput = new Label();
            lblArray = new Label();
            lblCalculations = new Label();
            lblSum = new Label();
            lblSumEven = new Label();
            lblSumOdd = new Label();
            txtInput = new TextBox();
            txtArray = new TextBox();
            txtSum = new TextBox();
            txtSumEven = new TextBox();
            txtSumOdd = new TextBox();
            btnInput = new Button();
            btnSum = new Button();
            btnSumEven = new Button();
            btnSumOdd = new Button();
            btnContinue = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(151, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(448, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "NHẬP DÃY SỐ VÀ TÍNH TỔNG";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblInput
            // 
            lblInput.Anchor = AnchorStyles.Left;
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblInput.Location = new Point(50, 80);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(84, 23);
            lblInput.TabIndex = 1;
            lblInput.Text = "Nhập số:";
            // 
            // lblArray
            // 
            lblArray.Anchor = AnchorStyles.Left;
            lblArray.AutoSize = true;
            lblArray.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblArray.Location = new Point(50, 130);
            lblArray.Name = "lblArray";
            lblArray.Size = new Size(156, 23);
            lblArray.TabIndex = 4;
            lblArray.Text = "Dãy số vừa nhập:";
            // 
            // lblCalculations
            // 
            lblCalculations.Anchor = AnchorStyles.Left;
            lblCalculations.AutoSize = true;
            lblCalculations.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblCalculations.Location = new Point(50, 230);
            lblCalculations.Name = "lblCalculations";
            lblCalculations.Size = new Size(246, 23);
            lblCalculations.TabIndex = 6;
            lblCalculations.Text = "Các tổng phần tử trong dãy:";
            // 
            // lblSum
            // 
            lblSum.Anchor = AnchorStyles.Left;
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            lblSum.Location = new Point(50, 265);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(94, 22);
            lblSum.TabIndex = 7;
            lblSum.Text = "Tính tổng:";
            // 
            // lblSumEven
            // 
            lblSumEven.Anchor = AnchorStyles.Left;
            lblSumEven.AutoSize = true;
            lblSumEven.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            lblSumEven.Location = new Point(50, 305);
            lblSumEven.Name = "lblSumEven";
            lblSumEven.Size = new Size(102, 22);
            lblSumEven.TabIndex = 10;
            lblSumEven.Text = "Tổng chẵn:";
            // 
            // lblSumOdd
            // 
            lblSumOdd.Anchor = AnchorStyles.Left;
            lblSumOdd.AutoSize = true;
            lblSumOdd.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            lblSumOdd.Location = new Point(50, 345);
            lblSumOdd.Name = "lblSumOdd";
            lblSumOdd.Size = new Size(77, 22);
            lblSumOdd.TabIndex = 13;
            lblSumOdd.Text = "Tổng lẻ:";
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtInput.Font = new Font("Times New Roman", 12F);
            txtInput.Location = new Point(150, 80);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(360, 30);
            txtInput.TabIndex = 2;
            // 
            // txtArray
            // 
            txtArray.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtArray.Font = new Font("Times New Roman", 11F);
            txtArray.Location = new Point(50, 158);
            txtArray.Multiline = true;
            txtArray.Name = "txtArray";
            txtArray.ReadOnly = true;
            txtArray.Size = new Size(560, 57);
            txtArray.TabIndex = 5;
            txtArray.TextChanged += txtArray_TextChanged;
            // 
            // txtSum
            // 
            txtSum.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSum.Font = new Font("Times New Roman", 11F);
            txtSum.Location = new Point(150, 265);
            txtSum.Name = "txtSum";
            txtSum.ReadOnly = true;
            txtSum.Size = new Size(374, 29);
            txtSum.TabIndex = 8;
            // 
            // txtSumEven
            // 
            txtSumEven.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSumEven.Font = new Font("Times New Roman", 11F);
            txtSumEven.Location = new Point(150, 305);
            txtSumEven.Name = "txtSumEven";
            txtSumEven.ReadOnly = true;
            txtSumEven.Size = new Size(374, 29);
            txtSumEven.TabIndex = 11;
            // 
            // txtSumOdd
            // 
            txtSumOdd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSumOdd.Font = new Font("Times New Roman", 11F);
            txtSumOdd.Location = new Point(150, 345);
            txtSumOdd.Name = "txtSumOdd";
            txtSumOdd.ReadOnly = true;
            txtSumOdd.Size = new Size(374, 29);
            txtSumOdd.TabIndex = 14;
            // 
            // btnInput
            // 
            btnInput.Anchor = AnchorStyles.Right;
            btnInput.AutoSize = true;
            btnInput.Font = new Font("Times New Roman", 11F);
            btnInput.Location = new Point(565, 78);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(80, 31);
            btnInput.TabIndex = 3;
            btnInput.Text = "Nhập";
            btnInput.Click += btnInput_Click;
            // 
            // btnSum
            // 
            btnSum.Anchor = AnchorStyles.Right;
            btnSum.AutoSize = true;
            btnSum.Font = new Font("Times New Roman", 10F);
            btnSum.Location = new Point(565, 265);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(83, 29);
            btnSum.TabIndex = 9;
            btnSum.Text = "Tính tổng";
            btnSum.Click += btnSum_Click;
            // 
            // btnSumEven
            // 
            btnSumEven.Anchor = AnchorStyles.Right;
            btnSumEven.AutoSize = true;
            btnSumEven.Font = new Font("Times New Roman", 10F);
            btnSumEven.Location = new Point(565, 305);
            btnSumEven.Name = "btnSumEven";
            btnSumEven.Size = new Size(88, 29);
            btnSumEven.TabIndex = 12;
            btnSumEven.Text = "Tổng chẵn";
            btnSumEven.Click += btnSumEven_Click;
            // 
            // btnSumOdd
            // 
            btnSumOdd.Anchor = AnchorStyles.Right;
            btnSumOdd.AutoSize = true;
            btnSumOdd.Font = new Font("Times New Roman", 10F);
            btnSumOdd.Location = new Point(565, 345);
            btnSumOdd.Name = "btnSumOdd";
            btnSumOdd.Size = new Size(80, 29);
            btnSumOdd.TabIndex = 15;
            btnSumOdd.Text = "Tổng lẻ";
            btnSumOdd.Click += btnSumOdd_Click;
            // 
            // btnContinue
            // 
            btnContinue.Anchor = AnchorStyles.Bottom;
            btnContinue.AutoSize = true;
            btnContinue.Font = new Font("Times New Roman", 12F);
            btnContinue.Location = new Point(222, 405);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(100, 35);
            btnContinue.TabIndex = 16;
            btnContinue.Text = "Tiếp tục";
            btnContinue.Click += btnContinue_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom;
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Times New Roman", 12F);
            btnExit.Location = new Point(397, 405);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 35);
            btnExit.TabIndex = 17;
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;
            // 
            // Form5
            // 
            AutoSize = true;
            ClientSize = new Size(739, 476);
            Controls.Add(lblTitle);
            Controls.Add(lblInput);
            Controls.Add(txtInput);
            Controls.Add(btnInput);
            Controls.Add(lblArray);
            Controls.Add(txtArray);
            Controls.Add(lblCalculations);
            Controls.Add(lblSum);
            Controls.Add(txtSum);
            Controls.Add(btnSum);
            Controls.Add(lblSumEven);
            Controls.Add(txtSumEven);
            Controls.Add(btnSumEven);
            Controls.Add(lblSumOdd);
            Controls.Add(txtSumOdd);
            Controls.Add(btnSumOdd);
            Controls.Add(btnContinue);
            Controls.Add(btnExit);
            Name = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        // TextBox declarations
        private TextBox txtInput;
        private TextBox txtArray;
        private TextBox txtSum;
        private TextBox txtSumEven;
        private TextBox txtSumOdd;

        // Button declarations
        private Button btnInput;
        private Button btnSum;
        private Button btnSumEven;
        private Button btnSumOdd;
        private Button btnContinue;
        private Label lblTitle;
        private Label lblInput;
        private Label lblArray;
        private Label lblCalculations;
        private Label lblSum;
        private Label lblSumEven;
        private Label lblSumOdd;
        private Button btnExit;

        private void txtArray_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
