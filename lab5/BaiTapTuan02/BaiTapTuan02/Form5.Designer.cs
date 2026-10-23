namespace BaiTapTuan02
{
    partial class Form5
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
            tvDanhBa = new TreeView();
            grpThongTin = new GroupBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            btnThem = new Button();
            btnThoat = new Button();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // tvDanhBa
            // 
            tvDanhBa.Location = new Point(12, 12);
            tvDanhBa.Name = "tvDanhBa";
            tvDanhBa.Size = new Size(250, 416);
            tvDanhBa.TabIndex = 0;
            tvDanhBa.AfterSelect += tvDanhBa_AfterSelect;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblSDT);
            grpThongTin.Controls.Add(txtSDT);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Location = new Point(278, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(310, 200);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin liên hệ";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(15, 40);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(61, 20);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên :";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(120, 37);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(175, 27);
            txtHoTen.TabIndex = 0;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(15, 85);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(99, 20);
            lblSDT.TabIndex = 1;
            lblSDT.Text = "Số điện thoại :";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(120, 82);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(175, 27);
            txtSDT.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(120, 135);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 36);
            btnThem.TabIndex = 2;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(478, 392);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 36);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Th&oát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form5
            // 
            AcceptButton = btnThem;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 440);
            Controls.Add(btnThoat);
            Controls.Add(grpThongTin);
            Controls.Add(tvDanhBa);
            Name = "Form5";
            Text = "Danh bạ điện thoại";
            Load += Form5_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TreeView tvDanhBa;
        private GroupBox grpThongTin;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblSDT;
        private TextBox txtSDT;
        private Button btnThem;
        private Button btnThoat;
    }
}