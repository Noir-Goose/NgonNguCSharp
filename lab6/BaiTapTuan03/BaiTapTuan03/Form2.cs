
using Microsoft.Data.SqlClient;
using System;

using System.Windows.Forms;

namespace QLSinhVienApp
{
    public partial class Form2 : Form
    {
        private readonly string connectionString =
            "Server=127.0.0.1,1433;" +
            "Database=QLSinhVien;" +
            "User Id=sa;" +
            "Password=SqlServer@;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";

        public Form2()
        {
            InitializeComponent();

            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
        }

        // ==================== THEM LOP ====================
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();

            if (maKhoa == "" || maLop == "" || tenLop == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Mã khoa, Mã lớp và Tên lớp!");
                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql =
                        "INSERT INTO Lop (MaKhoa, MaLop, TenLop) " +
                        "VALUES (@MaKhoa, @MaLop, @TenLop)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                        cmd.Parameters.AddWithValue("@MaLop", maLop);
                        cmd.Parameters.AddWithValue("@TenLop", tenLop);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm lớp thành công!");

                XoaTrang();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thêm lớp: " + ex.Message);
            }
        }

        // ==================== XOA LOP ====================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();

            if (maLop == "")
            {
                MessageBox.Show("Vui lòng nhập Mã lớp cần xóa!");
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa lớp " + maLop + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql =
                        "DELETE FROM Lop WHERE MaLop = @MaLop";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", maLop);

                        int ketQua = cmd.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show("Xóa lớp thành công!");
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã lớp!");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Không thể xóa lớp. Có thể lớp đang được tham chiếu " +
                    "bởi dữ liệu khác.\nChi tiết: " + ex.Message);
            }
        }

        // ==================== SUA LOP ====================
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string maKhoa = txtMaKhoa.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();

            if (maLop == "")
            {
                MessageBox.Show("Mã lớp không được để trống!");
                return;
            }

            if (maKhoa == "" && tenLop == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập Mã khoa hoặc Tên lớp cần sửa!");
                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "UPDATE Lop SET ";

                    if (maKhoa != "" && tenLop != "")
                    {
                        sql += "MaKhoa = @MaKhoa, TenLop = @TenLop";
                    }
                    else if (maKhoa != "")
                    {
                        sql += "MaKhoa = @MaKhoa";
                    }
                    else
                    {
                        sql += "TenLop = @TenLop";
                    }

                    sql += " WHERE MaLop = @MaLop";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", maLop);

                        if (maKhoa != "")
                        {
                            cmd.Parameters.AddWithValue(
                                "@MaKhoa", maKhoa);
                        }

                        if (tenLop != "")
                        {
                            cmd.Parameters.AddWithValue(
                                "@TenLop", tenLop);
                        }

                        int ketQua = cmd.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show("Sửa lớp thành công!");
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã lớp!");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi sửa lớp: " + ex.Message);
            }
        }

        // ==================== XOA TRANG NHAP ====================
        private void XoaTrang()
        {
            txtMaKhoa.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();

            txtMaKhoa.Focus();
        }
    }
}
