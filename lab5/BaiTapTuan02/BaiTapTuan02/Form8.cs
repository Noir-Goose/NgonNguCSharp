using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaiTapTuan02
{
    public partial class Form8 : Form
    {
        private int totalSeconds = 30 * 60; // 30 phút = 1800 giây
        private bool isRunning = false;

        public Form8()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                // Bắt đầu đếm ngược
                timer1.Start();
                btnStart.Text = "Tạm dừng";
                isRunning = true;
            }
            else
            {
                // Tạm dừng
                timer1.Stop();
                btnStart.Text = "Bắt đầu";
                isRunning = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;

                // Quy đổi ra Phút:Giây
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds % 60;

                // Cập nhật lên màn hình dạng 00:00
                lblTimer.Text = string.Format("{0:D2}:{1:D2}", minutes, seconds);
            }
            else
            {
                // Hết giờ
                timer1.Stop();
                MessageBox.Show("Đã hết thời gian!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Khôi phục trạng thái ban đầu
                totalSeconds = 30 * 60;
                lblTimer.Text = "30:00";
                btnStart.Text = "Bắt đầu";
                isRunning = false;
            }
        }
    }
}