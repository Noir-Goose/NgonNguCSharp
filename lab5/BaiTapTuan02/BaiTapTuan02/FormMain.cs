using System;
using System.Windows.Forms;

namespace BaiTapTuan02
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm mở Form con bên trong FormMain (MDI)
        /// Tránh mở trùng lặp cùng 1 form
        /// </summary>
        private void OpenChildForm(Form childForm)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == childForm.GetType())
                {
                    form.Activate();
                    return;
                }
            }

            childForm.MdiParent = this;
            childForm.Show();
        }
        // Mở Form bài tập
        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());
        }

        private void bài5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5());
        }

        private void bài6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form6());
        }

        private void bài7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form7());
        }

        private void bài8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form8());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}