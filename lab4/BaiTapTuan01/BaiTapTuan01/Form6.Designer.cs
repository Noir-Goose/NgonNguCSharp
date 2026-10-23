namespace BaiTapTuan01
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblInput = new Label();
            lblOutput = new Label();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnExecute = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(244, 37);
            label1.Name = "label1";
            label1.Size = new Size(324, 35);
            label1.TabIndex = 0;
            label1.Text = "ĐỌC SỐ THÀNH CHỮ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Times New Roman", 13.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInput.Location = new Point(100, 120);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(193, 25);
            lblInput.TabIndex = 4;
            lblInput.Text = "Nhập số (từ 1-999):";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Times New Roman", 13.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(100, 200);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(95, 25);
            lblOutput.TabIndex = 5;
            lblOutput.Text = "Kết quả:";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Times New Roman", 12F);
            txtInput.Location = new Point(380, 120);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(250, 30);
            txtInput.TabIndex = 6;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Times New Roman", 12F);
            txtOutput.Location = new Point(380, 200);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(250, 60);
            txtOutput.TabIndex = 7;
            // 
            // btnExecute
            // 
            btnExecute.BackColor = SystemColors.Control;
            btnExecute.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExecute.ForeColor = SystemColors.ActiveCaptionText;
            btnExecute.Location = new Point(150, 310);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(120, 50);
            btnExecute.TabIndex = 8;
            btnExecute.Text = "Thực hiện";
            btnExecute.UseVisualStyleBackColor = false;
            btnExecute.Click += BtnExecute_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Control;
            btnClear.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(310, 310);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 50);
            btnClear.TabIndex = 9;
            btnClear.Text = "Xóa";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Control;
            btnExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(470, 310);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 50);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 442);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnExecute);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(lblOutput);
            Controls.Add(lblInput);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Đọc Số Thành Chữ";
            FormClosing += Form6_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblInput;
        private Label lblOutput;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnExecute;
        private Button btnClear;
        private Button btnExit;
    }
}