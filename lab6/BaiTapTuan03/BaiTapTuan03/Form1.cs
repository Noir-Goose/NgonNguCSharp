using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapTuan03
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối tới SQL Server chạy trên Docker Desktop (Port 1433)
        // Nhớ thay Password nếu bạn đặt mật khẩu khác khi tạo container Docker
        string connectionString =
            "Server=127.0.0.1,1433;" +
            "Database=QLSinhVien;" +
            "User Id=sa;" +
            "Password=SqlServer@;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }


        // 1. Chức năng Thêm dữ liệu
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Mã môn học và Tên môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO MonHoc (MaMH, TenMH) VALUES (@MaMH, @TenMH)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 2. Chức năng Xóa dữ liệu (Mã môn học không được để trống, Tên môn học không cần nhập)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã môn học cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM MonHoc WHERE MaMH = @MaMH";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text.Trim());
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Không tìm thấy Mã môn học cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 3. Chức năng Sửa dữ liệu
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Mã môn học và Tên môn học không được để trống khi sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE MonHoc SET TenMH = @TenMH WHERE MaMH = @MaMH";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text.Trim());
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Cập nhật môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Không tìm thấy Mã môn học để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}