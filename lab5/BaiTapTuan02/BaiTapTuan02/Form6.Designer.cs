namespace BaiTapTuan02
{
    partial class Form6
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
            components = new System.ComponentModel.Container();
            grpThongTin = new GroupBox();
            lblMaSV = new Label();
            txtMaSV = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblGioiTinh = new Label();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            lblNgoaiNgu = new Label();
            chkAnh = new CheckBox();
            chkPhap = new CheckBox();
            chkHoa = new CheckBox();
            lblDanToc = new Label();
            cboDanToc = new ComboBox();
            lvSinhVien = new ListView();
            colMaSV = new ColumnHeader();
            colHoTen = new ColumnHeader();
            colGioiTinh = new ColumnHeader();
            colNgoaiNgu = new ColumnHeader();
            colDanToc = new ColumnHeader();
            ctmsLV = new ContextMenuStrip(components);
            tsmiXoa = new ToolStripMenuItem();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();
            grpThongTin.SuspendLayout();
            ctmsLV.SuspendLayout();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblMaSV);
            grpThongTin.Controls.Add(txtMaSV);
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblGioiTinh);
            grpThongTin.Controls.Add(rdoNam);
            grpThongTin.Controls.Add(rdoNu);
            grpThongTin.Controls.Add(lblNgoaiNgu);
            grpThongTin.Controls.Add(chkAnh);
            grpThongTin.Controls.Add(chkPhap);
            grpThongTin.Controls.Add(chkHoa);
            grpThongTin.Controls.Add(lblDanToc);
            grpThongTin.Controls.Add(cboDanToc);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(660, 160);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin sinh viên";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(20, 35);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Text = "Mã sinh viên :";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(130, 32);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(180, 27);
            txtMaSV.TabIndex = 0;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(20, 75);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Text = "Họ tên :";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(130, 72);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(180, 27);
            txtHoTen.TabIndex = 1;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(20, 115);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Text = "Giới tính :";
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Checked = true;
            rdoNam.Location = new Point(130, 113);
            rdoNam.Name = "rdoNam";
            rdoNam.TabIndex = 2;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(210, 113);
            rdoNu.Name = "rdoNu";
            rdoNu.TabIndex = 3;
            rdoNu.Text = "Nữ";
            // 
            // lblNgoaiNgu
            // 
            lblNgoaiNgu.AutoSize = true;
            lblNgoaiNgu.Location = new Point(350, 35);
            lblNgoaiNgu.Name = "lblNgoaiNgu";
            lblNgoaiNgu.Text = "Ngoại ngữ :";
            // 
            // chkAnh
            // 
            chkAnh.AutoSize = true;
            chkAnh.Checked = true;
            chkAnh.CheckState = CheckState.Checked;
            chkAnh.Location = new Point(450, 34);
            chkAnh.Name = "chkAnh";
            chkAnh.TabIndex = 4;
            chkAnh.Text = "Anh";
            chkAnh.UseVisualStyleBackColor = true;
            // 
            // chkPhap
            // 
            chkPhap.AutoSize = true;
            chkPhap.Location = new Point(515, 34);
            chkPhap.Name = "chkPhap";
            chkPhap.TabIndex = 5;
            chkPhap.Text = "Pháp";
            chkPhap.UseVisualStyleBackColor = true;
            // 
            // chkHoa
            // 
            chkHoa.AutoSize = true;
            chkHoa.Location = new Point(590, 34);
            chkHoa.Name = "chkHoa";
            chkHoa.TabIndex = 6;
            chkHoa.Text = "Hoa";
            chkHoa.UseVisualStyleBackColor = true;
            // 
            // lblDanToc
            // 
            lblDanToc.AutoSize = true;
            lblDanToc.Location = new Point(350, 75);
            lblDanToc.Name = "lblDanToc";
            lblDanToc.Text = "Dân tộc :";
            // 
            // cboDanToc
            // 
            cboDanToc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanToc.Location = new Point(450, 72);
            cboDanToc.Name = "cboDanToc";
            cboDanToc.Size = new Size(190, 28);
            cboDanToc.TabIndex = 7;
            // 
            // lvSinhVien
            // 
            lvSinhVien.Columns.AddRange(new ColumnHeader[] { colMaSV, colHoTen, colGioiTinh, colNgoaiNgu, colDanToc });
            lvSinhVien.ContextMenuStrip = ctmsLV;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.Location = new Point(12, 185);
            lvSinhVien.MultiSelect = false;
            lvSinhVien.Name = "lvSinhVien";
            lvSinhVien.Size = new Size(660, 250);
            lvSinhVien.TabIndex = 1;
            lvSinhVien.UseCompatibleStateImageBehavior = false;
            lvSinhVien.View = View.Details;
            lvSinhVien.SelectedIndexChanged += lvSinhVien_SelectedIndexChanged;
            // 
            // Columns
            // 
            colMaSV.Text = "Mã SV";
            colMaSV.Width = 100;
            colHoTen.Text = "Họ tên";
            colHoTen.Width = 190;
            colGioiTinh.Text = "Giới tính";
            colGioiTinh.Width = 90;
            colNgoaiNgu.Text = "Ngoại ngữ";
            colNgoaiNgu.Width = 140;
            colDanToc.Text = "Dân tộc";
            colDanToc.Width = 120;
            // 
            // ctmsLV
            // 
            ctmsLV.ImageScalingSize = new Size(20, 20);
            ctmsLV.Items.AddRange(new ToolStripItem[] { tsmiXoa });
            ctmsLV.Name = "ctmsLV";
            ctmsLV.Size = new Size(110, 30);
            ctmsLV.Opening += ctmsLV_Opening;
            // 
            // tsmiXoa
            // 
            tsmiXoa.Name = "tsmiXoa";
            tsmiXoa.Size = new Size(109, 26);
            tsmiXoa.Text = "Xóa";
            tsmiXoa.Click += tsmiXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 450);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 36);
            btnThem.TabIndex = 2;
            btnThem.Text = "&Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(122, 450);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 36);
            btnSua.TabIndex = 3;
            btnSua.Text = "&Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(232, 450);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 36);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(342, 450);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 36);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "&Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(572, 450);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 36);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Th&oát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 500);
            Controls.Add(grpThongTin);
            Controls.Add(lvSinhVien);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThoat);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            FormClosing += Form6_FormClosing;
            Load += Form6_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ctmsLV.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTin;
        private Label lblMaSV;
        private TextBox txtMaSV;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblGioiTinh;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Label lblNgoaiNgu;
        private CheckBox chkAnh;
        private CheckBox chkPhap;
        private CheckBox chkHoa;
        private Label lblDanToc;
        private ComboBox cboDanToc;
        private ListView lvSinhVien;
        private ColumnHeader colMaSV;
        private ColumnHeader colHoTen;
        private ColumnHeader colGioiTinh;
        private ColumnHeader colNgoaiNgu;
        private ColumnHeader colDanToc;
        private ContextMenuStrip ctmsLV;
        private ToolStripMenuItem tsmiXoa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnThoat;
    }
}