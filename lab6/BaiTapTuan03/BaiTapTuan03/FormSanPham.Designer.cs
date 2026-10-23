namespace BaiTapTuan03
{
    partial class FormSanPham
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
            txtTenSP = new TextBox();
            lblTenSP = new Label();
            txtDonGia = new TextBox();
            lblDonGia = new Label();
            btnThem = new Button();
            SuspendLayout();
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(239, 129);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(343, 27);
            txtTenSP.TabIndex = 0;
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(129, 136);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(104, 20);
            lblTenSP.TabIndex = 1;
            lblTenSP.Text = "Tên sản phẩm";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(239, 179);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(343, 27);
            txtDonGia.TabIndex = 2;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(129, 186);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(55, 20);
            lblDonGia.TabIndex = 3;
            lblDonGia.Text = "Đơn giá";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(239, 230);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 47);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThem);
            Controls.Add(lblDonGia);
            Controls.Add(txtDonGia);
            Controls.Add(lblTenSP);
            Controls.Add(txtTenSP);
            Name = "FormSanPham";
            Text = "FormSanPham";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenSP;
        private Label lblTenSP;
        private TextBox txtDonGia;
        private Label lblDonGia;
        private Button btnThem;
    }
}