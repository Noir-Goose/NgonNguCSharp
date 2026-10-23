namespace BaiTapTuan02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cboSo = new ComboBox();
            btnCapNhat = new Button();
            txtNhapSo = new TextBox();
            btnThoat = new Button();
            lstUocSo = new ListBox();
            groupBox2 = new GroupBox();
            vScrollBar1 = new VScrollBar();
            btnTong = new Button();
            btnSoChan = new Button();
            btnNguyenTo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSo);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(txtNhapSo);
            groupBox1.Location = new Point(30, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 124);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập số";
            // 
            // cboSo
            // 
            cboSo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSo.FormattingEnabled = true;
            cboSo.Location = new Point(21, 79);
            cboSo.Name = "cboSo";
            cboSo.Size = new Size(193, 28);
            cboSo.TabIndex = 2;
            cboSo.SelectedIndexChanged += cboSo_SelectedIndexChanged;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(137, 35);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(77, 29);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "&Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtNhapSo
            // 
            txtNhapSo.Location = new Point(21, 37);
            txtNhapSo.Name = "txtNhapSo";
            txtNhapSo.Size = new Size(118, 27);
            txtNhapSo.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(150, 310);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Th&oát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lstUocSo
            // 
            lstUocSo.FormattingEnabled = true;
            lstUocSo.Location = new Point(27, 26);
            lstUocSo.Name = "lstUocSo";
            lstUocSo.Size = new Size(189, 84);
            lstUocSo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(vScrollBar1);
            groupBox2.Controls.Add(lstUocSo);
            groupBox2.Location = new Point(256, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(222, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các ước số";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(190, 26);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 81);
            vScrollBar1.TabIndex = 1;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(241, 206);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(237, 29);
            btnTong.TabIndex = 2;
            btnTong.Text = "&Tổng các ước số";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnSoChan
            // 
            btnSoChan.Location = new Point(241, 241);
            btnSoChan.Name = "btnSoChan";
            btnSoChan.Size = new Size(237, 29);
            btnSoChan.TabIndex = 3;
            btnSoChan.Text = "&Số lượng các ước số chẵn";
            btnSoChan.UseVisualStyleBackColor = true;
            btnSoChan.Click += btnSoChan_Click;
            // 
            // btnNguyenTo
            // 
            btnNguyenTo.Location = new Point(241, 276);
            btnNguyenTo.Name = "btnNguyenTo";
            btnNguyenTo.Size = new Size(237, 29);
            btnNguyenTo.TabIndex = 4;
            btnNguyenTo.Text = "Số lượng các ước số &nguyên tố";
            btnNguyenTo.UseVisualStyleBackColor = true;
            btnNguyenTo.Click += btnNguyenTo_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 357);
            Controls.Add(btnNguyenTo);
            Controls.Add(btnSoChan);
            Controls.Add(btnTong);
            Controls.Add(btnThoat);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Combobox";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCapNhat;
        private TextBox txtNhapSo;
        private ComboBox cboSo;
        private Button btnThoat;
        private ListBox lstUocSo;
        private GroupBox groupBox2;
        private VScrollBar vScrollBar1;
        private Button btnTong;
        private Button btnSoChan;
        private Button btnNguyenTo;
    }
}