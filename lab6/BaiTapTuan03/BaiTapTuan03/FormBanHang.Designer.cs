namespace BaiTapTuan03
{
    partial class FormBanHang
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
            this.btnTaoHD = new Button();
            btnThanhToan = new Button();
            groupBox1 = new GroupBox();
            btnThemCT = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMaHD = new TextBox();
            txtSoLuong = new TextBox();
            cboMaSP = new ComboBox();
            btnHuy = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Location = new Point(508, 29);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new Size(157, 29);
            this.btnTaoHD.TabIndex = 0;
            this.btnTaoHD.Text = "Tạo hóa đơn ";
            this.btnTaoHD.UseVisualStyleBackColor = true;
            this.btnTaoHD.Click += btnTaoHD_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(508, 409);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(157, 29);
            btnThanhToan.TabIndex = 1;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(cboMaSP);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtMaHD);
            groupBox1.Controls.Add(btnThemCT);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(72, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(593, 328);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết hóa đơn ";
            // 
            // btnThemCT
            // 
            btnThemCT.Location = new Point(210, 252);
            btnThemCT.Name = "btnThemCT";
            btnThemCT.Size = new Size(94, 45);
            btnThemCT.TabIndex = 3;
            btnThemCT.Text = "Thêm";
            btnThemCT.UseVisualStyleBackColor = true;
            btnThemCT.Click += btnThemCT_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 180);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 130);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 76);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(210, 73);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(287, 27);
            txtMaHD.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(210, 173);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(287, 27);
            txtSoLuong.TabIndex = 5;
            // 
            // cboMaSP
            // 
            cboMaSP.FormattingEnabled = true;
            cboMaSP.Location = new Point(210, 127);
            cboMaSP.Name = "cboMaSP";
            cboMaSP.Size = new Size(287, 28);
            cboMaSP.TabIndex = 6;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(367, 252);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 45);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnThanhToan);
            Controls.Add(this.btnTaoHD);
            Name = "FormBanHang";
            Text = "FormBanHang";
            Load += FormBanHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTaoHD;
        private Button btnThanhToan;
        private GroupBox groupBox1;
        private Button btnThemCT;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMaHD;
        private Button btnHuy;
        private ComboBox cboMaSP;
        private TextBox txtSoLuong;
    }
}