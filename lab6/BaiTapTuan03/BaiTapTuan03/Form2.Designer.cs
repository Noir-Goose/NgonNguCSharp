
namespace QLSinhVienApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblTenLop;

        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblMaKhoa = new Label();
            lblMaLop = new Label();
            lblTenLop = new Label();
            txtMaKhoa = new TextBox();
            txtMaLop = new TextBox();
            txtTenLop = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Red;
            lblTieuDe.Location = new Point(30, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(540, 45);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ LỚP";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.Location = new Point(80, 95);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(100, 30);
            lblMaKhoa.TabIndex = 1;
            lblMaKhoa.Text = "Mã khoa:";
            lblMaKhoa.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMaLop
            // 
            lblMaLop.Location = new Point(80, 145);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(100, 30);
            lblMaLop.TabIndex = 3;
            lblMaLop.Text = "Mã lớp:";
            lblMaLop.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTenLop
            // 
            lblTenLop.Location = new Point(80, 195);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Size = new Size(100, 30);
            lblTenLop.TabIndex = 5;
            lblTenLop.Text = "Tên lớp:";
            lblTenLop.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(200, 95);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(280, 30);
            txtMaKhoa.TabIndex = 2;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(200, 145);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(280, 30);
            txtMaLop.TabIndex = 4;
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(200, 195);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(280, 30);
            txtTenLop.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ButtonFace;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(90, 255);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 38);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ButtonFace;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Black;
            btnXoa.Location = new Point(240, 255);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 38);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.ButtonFace;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(390, 255);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 38);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 370);
            Controls.Add(lblTieuDe);
            Controls.Add(lblMaKhoa);
            Controls.Add(txtMaKhoa);
            Controls.Add(lblMaLop);
            Controls.Add(txtMaLop);
            Controls.Add(lblTenLop);
            Controls.Add(txtTenLop);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Font = new Font("Segoe UI", 10F);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lớp";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
