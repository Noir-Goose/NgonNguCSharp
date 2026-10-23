namespace BaiTapTuan02
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
            label1 = new Label();
            cboLop = new ComboBox();
            grpThongTinSV = new GroupBox();
            btnXoa = new Button();
            btnCapNhat = new Button();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tvLop = new TreeView();
            chkThemLop = new CheckBox();
            grpThongTinLop = new GroupBox();
            btnThemLop = new Button();
            txtTenLop = new TextBox();
            label5 = new Label();
            grpThongTinSV.SuspendLayout();
            grpThongTinLop.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(394, 24);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Chọn lớp";
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(486, 21);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(226, 28);
            cboLop.TabIndex = 2;
            // 
            // grpThongTinSV
            // 
            grpThongTinSV.Controls.Add(btnXoa);
            grpThongTinSV.Controls.Add(btnCapNhat);
            grpThongTinSV.Controls.Add(txtDiaChi);
            grpThongTinSV.Controls.Add(txtHoTen);
            grpThongTinSV.Controls.Add(txtMaSV);
            grpThongTinSV.Controls.Add(label4);
            grpThongTinSV.Controls.Add(label3);
            grpThongTinSV.Controls.Add(label2);
            grpThongTinSV.FlatStyle = FlatStyle.Flat;
            grpThongTinSV.Location = new Point(351, 106);
            grpThongTinSV.Name = "grpThongTinSV";
            grpThongTinSV.Size = new Size(409, 184);
            grpThongTinSV.TabIndex = 3;
            grpThongTinSV.TabStop = false;
            grpThongTinSV.Text = "Thông tin sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 37);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã sinh viên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 80);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 1;
            label3.Text = "Họ tên :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 121);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 2;
            label4.Text = "Địa chỉ :";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(133, 34);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(270, 27);
            txtMaSV.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(133, 73);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(270, 27);
            txtHoTen.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(133, 114);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(270, 27);
            txtDiaChi.TabIndex = 5;
            // 
            // tvLop
            // 
            tvLop.Location = new Point(5, 12);
            tvLop.Name = "tvLop";
            tvLop.Size = new Size(340, 429);
            tvLop.TabIndex = 0;
            tvLop.AfterSelect += tvLop_AfterSelect;
            // 
            // chkThemLop
            // 
            chkThemLop.AutoSize = true;
            chkThemLop.Location = new Point(365, 310);
            chkThemLop.Name = "chkThemLop";
            chkThemLop.Size = new Size(94, 24);
            chkThemLop.TabIndex = 4;
            chkThemLop.Text = "Thêm lớp";
            chkThemLop.UseVisualStyleBackColor = true;
            chkThemLop.CheckedChanged += chkThemLop_CheckedChanged;
            // 
            // grpThongTinLop
            // 
            grpThongTinLop.Controls.Add(btnThemLop);
            grpThongTinLop.Controls.Add(txtTenLop);
            grpThongTinLop.Controls.Add(label5);
            grpThongTinLop.Location = new Point(361, 351);
            grpThongTinLop.Name = "grpThongTinLop";
            grpThongTinLop.Size = new Size(399, 90);
            grpThongTinLop.TabIndex = 5;
            grpThongTinLop.TabStop = false;
            grpThongTinLop.Text = "Thông tin lớp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 52);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 0;
            label5.Text = "Tên lớp :";
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(107, 49);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(180, 27);
            txtTenLop.TabIndex = 1;
            // 
            // btnThemLop
            // 
            btnThemLop.Location = new Point(299, 48);
            btnThemLop.Name = "btnThemLop";
            btnThemLop.Size = new Size(94, 29);
            btnThemLop.TabIndex = 2;
            btnThemLop.Text = "Thêm lớp";
            btnThemLop.UseVisualStyleBackColor = true;
            btnThemLop.Click += btnThemLop_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(82, 147);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 6;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(258, 147);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(772, 453);
            Controls.Add(grpThongTinLop);
            Controls.Add(chkThemLop);
            Controls.Add(tvLop);
            Controls.Add(grpThongTinSV);
            Controls.Add(cboLop);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Quản lý sinh viên";
            grpThongTinSV.ResumeLayout(false);
            grpThongTinSV.PerformLayout();
            grpThongTinLop.ResumeLayout(false);
            grpThongTinLop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cboLop;
        private GroupBox grpThongTinSV;
        private Label label2;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private Label label4;
        private Label label3;
        private TreeView tvLop;
        private CheckBox chkThemLop;
        private GroupBox grpThongTinLop;
        private Label label5;
        private Button btnCapNhat;
        private Button btnThemLop;
        private TextBox txtTenLop;
        private Button btnXoa;
    }
}