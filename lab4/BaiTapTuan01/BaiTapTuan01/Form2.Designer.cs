namespace BaiTapTuan01
{
    partial class Form2

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
            components = new System.ComponentModel.Container();
            lblA = new Label();
            lblB = new Label();
            lblResult = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtResult = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(57, 40);
            lblA.Name = "lblA";
            lblA.Size = new Size(41, 20);
            lblA.TabIndex = 0;
            lblA.Text = "Số a:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(57, 107);
            lblB.Name = "lblB";
            lblB.Size = new Size(42, 20);
            lblB.TabIndex = 2;
            lblB.Text = "Số b:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(57, 173);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(63, 20);
            lblResult.TabIndex = 4;
            lblResult.Text = "Kết quả:";
            // 
            // txtA
            // 
            txtA.Location = new Point(137, 36);
            txtA.Margin = new Padding(3, 4, 3, 4);
            txtA.Name = "txtA";
            txtA.Size = new Size(228, 27);
            txtA.TabIndex = 1;
            txtA.KeyPress += TxtNumber_KeyPress;
            txtA.Validating += TxtA_Validating;
            // 
            // txtB
            // 
            txtB.Location = new Point(137, 103);
            txtB.Margin = new Padding(3, 4, 3, 4);
            txtB.Name = "txtB";
            txtB.Size = new Size(228, 27);
            txtB.TabIndex = 3;
            txtB.KeyPress += TxtNumber_KeyPress;
            txtB.Validating += TxtB_Validating;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(137, 169);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(228, 27);
            txtResult.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(57, 240);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(57, 53);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(126, 240);
            btnSubtract.Margin = new Padding(3, 4, 3, 4);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(57, 53);
            btnSubtract.TabIndex = 7;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += BtnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(194, 240);
            btnMultiply.Margin = new Padding(3, 4, 3, 4);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(57, 53);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += BtnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(263, 240);
            btnDivide.Margin = new Padding(3, 4, 3, 4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(57, 53);
            btnDivide.TabIndex = 9;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += BtnDivide_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(331, 240);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 53);
            btnClear.TabIndex = 10;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // BaiTap01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 400);
            Controls.Add(btnClear);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtResult);
            Controls.Add(lblResult);
            Controls.Add(txtB);
            Controls.Add(lblB);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BaiTap01";
            Text = "Máy tính";
            FormClosing += Form2_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}