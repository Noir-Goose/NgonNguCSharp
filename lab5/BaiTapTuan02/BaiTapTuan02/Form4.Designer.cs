namespace BaiTapTuan02
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
            lblTieuDe = new Label();
            grpListbox = new GroupBox();
            txtNhap = new TextBox();
            btnNhap = new Button();
            lstSo = new ListBox();
            grpXuLy = new GroupBox();
            btnTong = new Button();
            btnXoaDauCuoi = new Button();
            btnXoaChon = new Button();
            btnTang2 = new Button();
            btnBinhPhuong = new Button();
            btnChonChan = new Button();
            btnChonLe = new Button();
            btnKetThuc = new Button();
            grpListbox.SuspendLayout();
            grpXuLy.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.BorderStyle = BorderStyle.FixedSingle;
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkOrange;
            lblTieuDe.Location = new Point(30, 10);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(505, 52);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "LISTBOX";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpListbox
            // 
            grpListbox.Controls.Add(txtNhap);
            grpListbox.Controls.Add(btnNhap);
            grpListbox.Controls.Add(lstSo);
            grpListbox.Location = new Point(30, 72);
            grpListbox.Name = "grpListbox";
            grpListbox.Size = new Size(205, 325);
            grpListbox.TabIndex = 1;
            grpListbox.TabStop = false;
            grpListbox.Text = "Listbox";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(15, 30);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(175, 27);
            txtNhap.TabIndex = 0;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(15, 65);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(175, 35);
            btnNhap.TabIndex = 1;
            btnNhap.Text = "&Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // lstSo
            // 
            lstSo.FormattingEnabled = true;
            lstSo.IntegralHeight = false;
            lstSo.Location = new Point(15, 110);
            lstSo.Name = "lstSo";
            lstSo.SelectionMode = SelectionMode.MultiExtended;
            lstSo.Size = new Size(175, 200);
            lstSo.TabIndex = 2;
            // 
            // grpXuLy
            // 
            grpXuLy.Controls.Add(btnTong);
            grpXuLy.Controls.Add(btnXoaDauCuoi);
            grpXuLy.Controls.Add(btnXoaChon);
            grpXuLy.Controls.Add(btnTang2);
            grpXuLy.Controls.Add(btnBinhPhuong);
            grpXuLy.Controls.Add(btnChonChan);
            grpXuLy.Controls.Add(btnChonLe);
            grpXuLy.Location = new Point(250, 72);
            grpXuLy.Name = "grpXuLy";
            grpXuLy.Size = new Size(285, 325);
            grpXuLy.TabIndex = 2;
            grpXuLy.TabStop = false;
            grpXuLy.Text = "Xử lý Listbox";
            // 
            // btnTong
            // 
            btnTong.Location = new Point(15, 28);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(255, 35);
            btnTong.TabIndex = 0;
            btnTong.Text = "Tổng các phần tử trong List";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnXoaDauCuoi
            // 
            btnXoaDauCuoi.Location = new Point(15, 70);
            btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            btnXoaDauCuoi.Size = new Size(255, 35);
            btnXoaDauCuoi.TabIndex = 1;
            btnXoaDauCuoi.Text = "Xóa Phần tử đầu và cuối";
            btnXoaDauCuoi.UseVisualStyleBackColor = true;
            btnXoaDauCuoi.Click += btnXoaDauCuoi_Click;
            // 
            // btnXoaChon
            // 
            btnXoaChon.Location = new Point(15, 112);
            btnXoaChon.Name = "btnXoaChon";
            btnXoaChon.Size = new Size(255, 35);
            btnXoaChon.TabIndex = 2;
            btnXoaChon.Text = "Xóa Phần tử đang chọn";
            btnXoaChon.UseVisualStyleBackColor = true;
            btnXoaChon.Click += btnXoaChon_Click;
            // 
            // btnTang2
            // 
            btnTang2.Location = new Point(15, 154);
            btnTang2.Name = "btnTang2";
            btnTang2.Size = new Size(255, 35);
            btnTang2.TabIndex = 3;
            btnTang2.Text = "Tăng mỗi phần tử lên 2";
            btnTang2.UseVisualStyleBackColor = true;
            btnTang2.Click += btnTang2_Click;
            // 
            // btnBinhPhuong
            // 
            btnBinhPhuong.Location = new Point(15, 196);
            btnBinhPhuong.Name = "btnBinhPhuong";
            btnBinhPhuong.Size = new Size(255, 35);
            btnBinhPhuong.TabIndex = 4;
            btnBinhPhuong.Text = "Thay bằng bình phương";
            btnBinhPhuong.UseVisualStyleBackColor = true;
            btnBinhPhuong.Click += btnBinhPhuong_Click;
            // 
            // btnChonChan
            // 
            btnChonChan.Location = new Point(15, 238);
            btnChonChan.Name = "btnChonChan";
            btnChonChan.Size = new Size(255, 35);
            btnChonChan.TabIndex = 5;
            btnChonChan.Text = "Chọn số chẵn";
            btnChonChan.UseVisualStyleBackColor = true;
            btnChonChan.Click += btnChonChan_Click;
            // 
            // btnChonLe
            // 
            btnChonLe.Location = new Point(15, 280);
            btnChonLe.Name = "btnChonLe";
            btnChonLe.Size = new Size(255, 35);
            btnChonLe.TabIndex = 6;
            btnChonLe.Text = "Chọn số lẻ";
            btnChonLe.UseVisualStyleBackColor = true;
            btnChonLe.Click += btnChonLe_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(30, 408);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(505, 38);
            btnKetThuc.TabIndex = 3;
            btnKetThuc.Text = "&KẾT THÚC";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // Form4
            // 
            AcceptButton = btnNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 462);
            Controls.Add(btnKetThuc);
            Controls.Add(grpXuLy);
            Controls.Add(grpListbox);
            Controls.Add(lblTieuDe);
            Name = "Form4";
            Text = "frmListbox";
            grpListbox.ResumeLayout(false);
            grpListbox.PerformLayout();
            grpXuLy.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTieuDe;
        private GroupBox grpListbox;
        private TextBox txtNhap;
        private Button btnNhap;
        private ListBox lstSo;
        private GroupBox grpXuLy;
        private Button btnTong;
        private Button btnXoaDauCuoi;
        private Button btnXoaChon;
        private Button btnTang2;
        private Button btnBinhPhuong;
        private Button btnChonChan;
        private Button btnChonLe;
        private Button btnKetThuc;
    }
}