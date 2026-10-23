namespace BaiTapTuan02
{
    partial class Form7
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblSoTK = new Label();
            txtSoTK = new TextBox();
            lblTenKH = new Label();
            txtTenKH = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblSoTien = new Label();
            txtSoTien = new TextBox();
            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lvTaiKhoan = new ListView();
            colSTT = new ColumnHeader();
            colSoTK = new ColumnHeader();
            colTenKH = new ColumnHeader();
            colDiaChi = new ColumnHeader();
            colSoTien = new ColumnHeader();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            lblTieuDe.Location = new System.Drawing.Point(0, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new System.Drawing.Size(680, 50);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSoTK
            // 
            lblSoTK.Location = new System.Drawing.Point(20, 76);
            lblSoTK.Name = "lblSoTK";
            lblSoTK.Size = new System.Drawing.Size(210, 25);
            lblSoTK.Text = "Số tài khoản";
            lblSoTK.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSoTK
            // 
            txtSoTK.Location = new System.Drawing.Point(240, 75);
            txtSoTK.Name = "txtSoTK";
            txtSoTK.Size = new System.Drawing.Size(400, 27);
            txtSoTK.TabIndex = 1;
            // 
            // lblTenKH
            // 
            lblTenKH.Location = new System.Drawing.Point(20, 116);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new System.Drawing.Size(210, 25);
            lblTenKH.Text = "Tên khách hàng";
            lblTenKH.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new System.Drawing.Point(240, 115);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new System.Drawing.Size(400, 27);
            txtTenKH.TabIndex = 2;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new System.Drawing.Point(20, 156);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new System.Drawing.Size(210, 25);
            lblDiaChi.Text = "Địa chỉ khách hàng";
            lblDiaChi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new System.Drawing.Point(240, 155);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new System.Drawing.Size(400, 27);
            txtDiaChi.TabIndex = 3;
            // 
            // lblSoTien
            // 
            lblSoTien.Location = new System.Drawing.Point(20, 196);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new System.Drawing.Size(210, 25);
            lblSoTien.Text = "Số tiền trong tài khoản";
            lblSoTien.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new System.Drawing.Point(240, 195);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new System.Drawing.Size(400, 27);
            txtSoTien.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(240, 240);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(95, 34);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Location = new System.Drawing.Point(342, 240);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(95, 34);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Location = new System.Drawing.Point(444, 240);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(95, 34);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new System.Drawing.Point(546, 240);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(95, 34);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lvTaiKhoan
            // 
            lvTaiKhoan.Columns.AddRange(new ColumnHeader[] { colSTT, colSoTK, colTenKH, colDiaChi, colSoTien });
            lvTaiKhoan.FullRowSelect = true;
            lvTaiKhoan.GridLines = true;
            lvTaiKhoan.Location = new System.Drawing.Point(20, 290);
            lvTaiKhoan.MultiSelect = false;
            lvTaiKhoan.Name = "lvTaiKhoan";
            lvTaiKhoan.Size = new System.Drawing.Size(640, 160);
            lvTaiKhoan.TabIndex = 9;
            lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            lvTaiKhoan.View = View.Details;
            lvTaiKhoan.SelectedIndexChanged += lvTaiKhoan_SelectedIndexChanged;
            // 
            // Columns
            // 
            colSTT.Text = "STT";
            colSTT.Width = 60;
            colSoTK.Text = "Số tài khoản";
            colSoTK.Width = 130;
            colTenKH.Text = "Tên khách hàng";
            colTenKH.Width = 170;
            colDiaChi.Text = "Địa chỉ";
            colDiaChi.Width = 150;
            colSoTien.Text = "Số tiền";
            colSoTien.Width = 120;
            // 
            // lblTongTien
            // 
            lblTongTien.Location = new System.Drawing.Point(340, 468);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new System.Drawing.Size(130, 25);
            lblTongTien.Text = "Tổng tiền";
            lblTongTien.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new System.Drawing.Point(480, 467);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new System.Drawing.Size(180, 27);
            txtTongTien.TabIndex = 10;
            txtTongTien.TabStop = false;
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // Form7
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(680, 510);
            Controls.Add(lblTieuDe);
            Controls.Add(lblSoTK);
            Controls.Add(txtSoTK);
            Controls.Add(lblTenKH);
            Controls.Add(txtTenKH);
            Controls.Add(lblDiaChi);
            Controls.Add(txtDiaChi);
            Controls.Add(lblSoTien);
            Controls.Add(txtSoTien);
            Controls.Add(btnThem);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(lvTaiKhoan);
            Controls.Add(lblTongTien);
            Controls.Add(txtTongTien);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBaiTap2";
            FormClosing += Form7_FormClosing;
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblSoTK;
        private TextBox txtSoTK;
        private Label lblTenKH;
        private TextBox txtTenKH;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Label lblSoTien;
        private TextBox txtSoTien;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThoat;
        private ListView lvTaiKhoan;
        private ColumnHeader colSTT;
        private ColumnHeader colSoTK;
        private ColumnHeader colTenKH;
        private ColumnHeader colDiaChi;
        private ColumnHeader colSoTien;
        private Label lblTongTien;
        private TextBox txtTongTien;
    }
}