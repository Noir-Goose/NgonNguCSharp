namespace BaiTapTuan01
{
    partial class Form7
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
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(108, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 83);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(29, 38);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(186, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Giải phương trình bậc 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(29, 8);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(207, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Giải phương trình bậc nhất";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(102, 23);
            label1.Name = "label1";
            label1.Size = new Size(256, 25);
            label1.TabIndex = 1;
            label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 75);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 2;
            label2.Text = "Bạn vui lòng chọn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 205);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Nhập a";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 237);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 4;
            label4.Text = "Nhập b";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 263);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 270);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 7;
            label5.Text = "Nhập c";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 355);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 9;
            label6.Text = "Kết quả";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(286, 202);
            button1.Name = "button1";
            button1.Size = new Size(114, 52);
            button1.TabIndex = 10;
            button1.Text = "Giải ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(286, 270);
            button2.Name = "button2";
            button2.Size = new Size(114, 52);
            button2.TabIndex = 11;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(164, 355);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(277, 27);
            textBox4.TabIndex = 12;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 450);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form7";
            Text = "Giải phương trình bậc 1-2";
            Load += Form7_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private TextBox textBox4;
    }
}