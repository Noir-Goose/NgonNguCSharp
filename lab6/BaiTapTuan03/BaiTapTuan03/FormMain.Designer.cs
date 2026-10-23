namespace BaiTapTuan03
{
    partial class FormMain
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
            menuStrip1 = new MenuStrip();
            mnuTaoTonKho = new ToolStripMenuItem();
            mnuNhapKho = new ToolStripMenuItem();
            mnuThemSP = new ToolStripMenuItem();
            mnuBanHang = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuTaoTonKho, mnuNhapKho, mnuThemSP, mnuBanHang });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuTaoTonKho
            // 
            mnuTaoTonKho.Name = "mnuTaoTonKho";
            mnuTaoTonKho.Size = new Size(102, 24);
            mnuTaoTonKho.Text = "Tạo tồn kho";
            mnuTaoTonKho.Click += new EventHandler(mnuTaoTonKho_Click);
            // 
            // mnuNhapKho
            // 
            mnuNhapKho.Name = "mnuNhapKho";
            mnuNhapKho.Size = new Size(83, 24);
            mnuNhapKho.Text = "Nhập kho";
            mnuNhapKho.Click += new EventHandler(mnuNhapKho_Click);
            // 
            // mnuThemSP
            // 
            mnuThemSP.Name = "mnuThemSP";
            mnuThemSP.Size = new Size(128, 24);
            mnuThemSP.Text = "Thêm sản phẩm";
            mnuThemSP.Click += new EventHandler(mnuThemSP_Click);
            // 
            // mnuBanHang
            // 
            mnuBanHang.Name = "mnuBanHang";
            mnuBanHang.Size = new Size(85, 24);
            mnuBanHang.Text = "Bán hàng";
            mnuBanHang.Click += new EventHandler(mnuBanHang_Click);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "FormMain - Quản Lý Cửa Hàng";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuTaoTonKho;
        private ToolStripMenuItem mnuNhapKho;
        private ToolStripMenuItem mnuThemSP;
        private ToolStripMenuItem mnuBanHang;
    }
}