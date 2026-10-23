namespace BaiTapTuan01
{
    partial class Form4
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
            lblNumberA = new Label();
            lblNumberB = new Label();
            lblGCD = new Label();
            lblLCM = new Label();
            txtNumberA = new TextBox();
            txtNumberB = new TextBox();
            lblResultGCD = new Label();
            lblResultLCM = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(273, 22);
            label1.Name = "label1";
            label1.Size = new Size(272, 20);
            label1.TabIndex = 0;
            label1.Text = "ƯỚC CHUNG - BỘI SỐ CHUNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumberA
            // 
            lblNumberA.AutoSize = true;
            lblNumberA.BackColor = Color.Transparent;
            lblNumberA.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lblNumberA.Location = new Point(100, 100);
            lblNumberA.Name = "lblNumberA";
            lblNumberA.Size = new Size(48, 20);
            lblNumberA.TabIndex = 1;
            lblNumberA.Text = "Số a:";
            // 
            // lblNumberB
            // 
            lblNumberB.AutoSize = true;
            lblNumberB.BackColor = Color.Transparent;
            lblNumberB.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lblNumberB.Location = new Point(100, 160);
            lblNumberB.Name = "lblNumberB";
            lblNumberB.Size = new Size(49, 20);
            lblNumberB.TabIndex = 2;
            lblNumberB.Text = "Số b:";
            // 
            // lblGCD
            // 
            lblGCD.AutoSize = true;
            lblGCD.BackColor = Color.Transparent;
            lblGCD.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lblGCD.Location = new Point(100, 240);
            lblGCD.Name = "lblGCD";
            lblGCD.Size = new Size(101, 20);
            lblGCD.TabIndex = 3;
            lblGCD.Text = "UCLN(a,b):";
            // 
            // lblLCM
            // 
            lblLCM.AutoSize = true;
            lblLCM.BackColor = Color.Transparent;
            lblLCM.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            lblLCM.Location = new Point(100, 300);
            lblLCM.Name = "lblLCM";
            lblLCM.Size = new Size(101, 20);
            lblLCM.TabIndex = 4;
            lblLCM.Text = "BCNN(a,b):";
            // 
            // txtNumberA
            // 
            txtNumberA.Font = new Font("Segoe UI", 10F);
            txtNumberA.Location = new Point(321, 90);
            txtNumberA.Name = "txtNumberA";
            txtNumberA.Size = new Size(200, 30);
            txtNumberA.TabIndex = 5;
            txtNumberA.TextChanged += this.txtNumberA_TextChanged;
            // 
            // txtNumberB
            // 
            txtNumberB.Font = new Font("Segoe UI", 10F);
            txtNumberB.Location = new Point(321, 153);
            txtNumberB.Name = "txtNumberB";
            txtNumberB.Size = new Size(200, 30);
            txtNumberB.TabIndex = 6;
            txtNumberB.TextChanged += this.txtNumberB_TextChanged;
            // 
            // lblResultGCD
            // 
            lblResultGCD.AutoSize = true;
            lblResultGCD.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResultGCD.ForeColor = Color.Blue;
            lblResultGCD.Location = new Point(404, 240);
            lblResultGCD.Name = "lblResultGCD";
            lblResultGCD.Size = new Size(17, 23);
            lblResultGCD.TabIndex = 7;
            lblResultGCD.Text = "-";
            lblResultGCD.Click += lblResultGCD_Click;
            // 
            // lblResultLCM
            // 
            lblResultLCM.AutoSize = true;
            lblResultLCM.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResultLCM.ForeColor = Color.Blue;
            lblResultLCM.Location = new Point(404, 300);
            lblResultLCM.Name = "lblResultLCM";
            lblResultLCM.Size = new Size(17, 23);
            lblResultLCM.TabIndex = 8;
            lblResultLCM.Text = "-";
            lblResultLCM.Click += this.lblResultLCM_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Transparent;
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalculate.ForeColor = Color.Black;
            btnCalculate.Location = new Point(284, 353);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 40);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Tính toán";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += BtnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(441, 353);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 40);
            btnClear.TabIndex = 10;
            btnClear.Text = "Xóa";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblResultLCM);
            Controls.Add(lblResultGCD);
            Controls.Add(txtNumberB);
            Controls.Add(txtNumberA);
            Controls.Add(lblLCM);
            Controls.Add(lblGCD);
            Controls.Add(lblNumberB);
            Controls.Add(lblNumberA);
            Controls.Add(label1);
            Name = "Form4";
            Text = "UCLN - BCNN";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNumberA;
        private Label lblNumberB;
        private Label lblGCD;
        private Label lblLCM;
        private TextBox txtNumberA;
        private TextBox txtNumberB;
        private Label lblResultGCD;
        private Label lblResultLCM;
        private Button btnCalculate;
        private Button btnClear;
    }
}