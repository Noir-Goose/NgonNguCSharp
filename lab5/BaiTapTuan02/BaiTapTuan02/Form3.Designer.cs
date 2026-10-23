namespace BaiTapTuan02
{
    partial class Form3
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
            tabMain = new TabControl();
            tabAnhViet = new TabPage();
            lblTiengAnh = new Label();
            txtAnh = new TextBox();
            lstAnh = new ListBox();
            lblNghiaViet = new Label();
            txtNghiaViet = new TextBox();
            tabVietAnh = new TabPage();
            lblTiengViet = new Label();
            txtViet = new TextBox();
            lstViet = new ListBox();
            lblNghiaAnh = new Label();
            txtNghiaAnh = new TextBox();
            btnThoat = new Button();
            tabMain.SuspendLayout();
            tabAnhViet.SuspendLayout();
            tabVietAnh.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabAnhViet);
            tabMain.Controls.Add(tabVietAnh);
            tabMain.Location = new Point(20, 15);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(440, 380);
            tabMain.TabIndex = 0;
            tabMain.SelectedIndexChanged += tabMain_SelectedIndexChanged;
            // 
            // tabAnhViet
            // 
            tabAnhViet.Controls.Add(lblTiengAnh);
            tabAnhViet.Controls.Add(txtAnh);
            tabAnhViet.Controls.Add(lstAnh);
            tabAnhViet.Controls.Add(lblNghiaViet);
            tabAnhViet.Controls.Add(txtNghiaViet);
            tabAnhViet.Location = new Point(4, 29);
            tabAnhViet.Name = "tabAnhViet";
            tabAnhViet.Padding = new Padding(3);
            tabAnhViet.Size = new Size(432, 347);
            tabAnhViet.TabIndex = 0;
            tabAnhViet.Text = "ANH - VIỆT";
            tabAnhViet.UseVisualStyleBackColor = true;
            // 
            // lblTiengAnh
            // 
            lblTiengAnh.AutoSize = true;
            lblTiengAnh.Location = new Point(20, 12);
            lblTiengAnh.Name = "lblTiengAnh";
            lblTiengAnh.Size = new Size(77, 20);
            lblTiengAnh.TabIndex = 0;
            lblTiengAnh.Text = "Tiếng Anh";
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(20, 40);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(190, 27);
            txtAnh.TabIndex = 0;
            txtAnh.TextChanged += txtAnh_TextChanged;
            txtAnh.KeyDown += txtAnh_KeyDown;
            // 
            // lstAnh
            // 
            lstAnh.FormattingEnabled = true;
            lstAnh.IntegralHeight = false;
            lstAnh.Location = new Point(20, 70);
            lstAnh.Name = "lstAnh";
            lstAnh.Size = new Size(190, 260);
            lstAnh.TabIndex = 1;
            lstAnh.SelectedIndexChanged += lstAnh_SelectedIndexChanged;
            lstAnh.MouseDoubleClick += lstAnh_MouseDoubleClick;
            // 
            // lblNghiaViet
            // 
            lblNghiaViet.AutoSize = true;
            lblNghiaViet.Location = new Point(235, 12);
            lblNghiaViet.Name = "lblNghiaViet";
            lblNghiaViet.Size = new Size(80, 20);
            lblNghiaViet.TabIndex = 2;
            lblNghiaViet.Text = "Tiếng Việt";
            // 
            // txtNghiaViet
            // 
            txtNghiaViet.BackColor = SystemColors.Window;
            txtNghiaViet.Location = new Point(235, 40);
            txtNghiaViet.Multiline = true;
            txtNghiaViet.Name = "txtNghiaViet";
            txtNghiaViet.ReadOnly = true;
            txtNghiaViet.Size = new Size(180, 290);
            txtNghiaViet.TabIndex = 2;
            txtNghiaViet.TabStop = false;
            // 
            // tabVietAnh
            // 
            tabVietAnh.Controls.Add(lblTiengViet);
            tabVietAnh.Controls.Add(txtViet);
            tabVietAnh.Controls.Add(lstViet);
            tabVietAnh.Controls.Add(lblNghiaAnh);
            tabVietAnh.Controls.Add(txtNghiaAnh);
            tabVietAnh.Location = new Point(4, 29);
            tabVietAnh.Name = "tabVietAnh";
            tabVietAnh.Padding = new Padding(3);
            tabVietAnh.Size = new Size(432, 347);
            tabVietAnh.TabIndex = 1;
            tabVietAnh.Text = "VIỆT - ANH";
            tabVietAnh.UseVisualStyleBackColor = true;
            // 
            // lblTiengViet
            // 
            lblTiengViet.AutoSize = true;
            lblTiengViet.Location = new Point(20, 12);
            lblTiengViet.Name = "lblTiengViet";
            lblTiengViet.Size = new Size(80, 20);
            lblTiengViet.TabIndex = 0;
            lblTiengViet.Text = "Tiếng Việt";
            // 
            // txtViet
            // 
            txtViet.Location = new Point(20, 40);
            txtViet.Name = "txtViet";
            txtViet.Size = new Size(190, 27);
            txtViet.TabIndex = 0;
            txtViet.TextChanged += txtViet_TextChanged;
            txtViet.KeyDown += txtViet_KeyDown;
            // 
            // lstViet
            // 
            lstViet.FormattingEnabled = true;
            lstViet.IntegralHeight = false;
            lstViet.Location = new Point(20, 70);
            lstViet.Name = "lstViet";
            lstViet.Size = new Size(190, 260);
            lstViet.TabIndex = 1;
            lstViet.SelectedIndexChanged += lstViet_SelectedIndexChanged;
            lstViet.MouseDoubleClick += lstViet_MouseDoubleClick;
            // 
            // lblNghiaAnh
            // 
            lblNghiaAnh.AutoSize = true;
            lblNghiaAnh.Location = new Point(235, 12);
            lblNghiaAnh.Name = "lblNghiaAnh";
            lblNghiaAnh.Size = new Size(77, 20);
            lblNghiaAnh.TabIndex = 2;
            lblNghiaAnh.Text = "Tiếng Anh";
            // 
            // txtNghiaAnh
            // 
            txtNghiaAnh.BackColor = SystemColors.Window;
            txtNghiaAnh.Location = new Point(235, 40);
            txtNghiaAnh.Multiline = true;
            txtNghiaAnh.Name = "txtNghiaAnh";
            txtNghiaAnh.ReadOnly = true;
            txtNghiaAnh.Size = new Size(180, 290);
            txtNghiaAnh.TabIndex = 2;
            txtNghiaAnh.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(350, 405);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 32);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Th&oát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 450);
            Controls.Add(btnThoat);
            Controls.Add(tabMain);
            Name = "Form3";
            Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";
            tabMain.ResumeLayout(false);
            tabAnhViet.ResumeLayout(false);
            tabAnhViet.PerformLayout();
            tabVietAnh.ResumeLayout(false);
            tabVietAnh.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabAnhViet;
        private TabPage tabVietAnh;
        private Label lblTiengAnh;
        private TextBox txtAnh;
        private ListBox lstAnh;
        private Label lblNghiaViet;
        private TextBox txtNghiaViet;
        private Label lblTiengViet;
        private TextBox txtViet;
        private ListBox lstViet;
        private Label lblNghiaAnh;
        private TextBox txtNghiaAnh;
        private Button btnThoat;
    }
}