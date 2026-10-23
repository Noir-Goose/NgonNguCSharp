using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BaiTapTuan03
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }
        string connStr = "Server=127.0.0.1,1433;Database=QLCuaHang;User Id=sa;Password=SqlServer@;Encrypt=True;TrustServerCertificate=True;";

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            SetKhoaControl(false);
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    LoadComboBoxSanPham(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sản phẩm: " + ex.Message);
            }

            btnTaoHD.Enabled = cboMaSP.Items.Count > 0;
        }

        private void SetKhoaControl(bool status)
        {
            txtMaHD.Enabled = false; // Mã hóa đơn luôn tự sinh nên chỉ để hiển thị
            cboMaSP.Enabled = status;
            txtSoLuong.Enabled = status;
            btnThemCT.Enabled = status;
            btnHuy.Enabled = status;
            btnThanhToan.Enabled = status;
            btnTaoHD.Enabled = !status && cboMaSP.Items.Count > 0;
        }

        // 1. Tạo hóa đơn mới
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO HOADON (NgayTao, TinhTrang) OUTPUT INSERTED.MaHD VALUES (CAST(GETDATE() AS DATE), 0)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int maHD = Convert.ToInt32(cmd.ExecuteScalar());
                        txtMaHD.Text = maHD.ToString();
                    }

                    LoadComboBoxSanPham(conn);
                    if (cboMaSP.Items.Count == 0)
                    {
                        MessageBox.Show("Chưa có sản phẩm để bán.");
                        return;
                    }

                    SetKhoaControl(true);
                    MessageBox.Show("Đã tạo hóa đơn mới thành công! Vui lòng chọn sản phẩm và nhập số lượng.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tạo hóa đơn: " + ex.Message);
                }
            }
        }

        private void LoadComboBoxSanPham(SqlConnection conn)
        {
            string query = "SELECT MaSP, TenSP FROM SANPHAM ORDER BY TenSP";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboMaSP.DataSource = null;
            cboMaSP.DataSource = dt;
            cboMaSP.DisplayMember = "TenSP";
            cboMaSP.ValueMember = "MaSP";
            cboMaSP.SelectedIndex = dt.Rows.Count > 0 ? 0 : -1;
        }

        // 2. Button Thêm chi tiết hóa đơn & kiểm tra tồn kho
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng cần bán!");
                return;
            }

            int slBan = 0;
            if (!int.TryParse(txtSoLuong.Text.Trim(), out slBan) || slBan <= 0)
            {
                MessageBox.Show("Số lượng bán phải là số nguyên lớn hơn 0!");
                return;
            }

            if (!int.TryParse(txtMaHD.Text, out int maHD) || cboMaSP.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng tạo hóa đơn và chọn sản phẩm trước.");
                return;
            }

            int maSP = Convert.ToInt32(cboMaSP.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string updateTonKho = "UPDATE TONKHO SET SLBan = ISNULL(SLBan, 0) + @SoLuong WHERE MaSP = @MaSP AND NgayTon = CAST(GETDATE() AS DATE) AND ISNULL(SLDau, 0) + ISNULL(SLNhap, 0) - ISNULL(SLBan, 0) >= @SoLuong";
                            using (SqlCommand cmd = new SqlCommand(updateTonKho, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@SoLuong", slBan);
                                cmd.Parameters.AddWithValue("@MaSP", maSP);
                                if (cmd.ExecuteNonQuery() == 0)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Không đủ tồn kho hoặc chưa khởi tạo tồn kho hôm nay.", "Cảnh báo");
                                    return;
                                }
                            }

                            string insertCT = "INSERT INTO CHITIETHOADON (MaHD, MaSP, SoLuong) VALUES (@MaHD, @MaSP, @SoLuong)";
                            using (SqlCommand cmd = new SqlCommand(insertCT, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@MaHD", maHD);
                                cmd.Parameters.AddWithValue("@MaSP", maSP);
                                cmd.Parameters.AddWithValue("@SoLuong", slBan);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }

                    MessageBox.Show("Thêm sản phẩm vào hóa đơn thành công!");
                    txtSoLuong.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn: " + ex.Message);
                }
            }
        }

        // 3. Nút Hủy hóa đơn
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaHD.Text, out int maHD))
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string restoreStock = @"UPDATE tk
SET tk.SLBan = ISNULL(tk.SLBan, 0) - details.TotalSold
FROM TONKHO tk
INNER JOIN (
    SELECT c.MaSP, SUM(c.SoLuong) AS TotalSold, CAST(h.NgayTao AS DATE) AS NgayTao
    FROM CHITIETHOADON c
    INNER JOIN HOADON h ON h.MaHD = c.MaHD
    WHERE c.MaHD = @MaHD AND h.TinhTrang = 0
    GROUP BY c.MaSP, CAST(h.NgayTao AS DATE)
) details ON details.MaSP = tk.MaSP AND details.NgayTao = tk.NgayTon";
                            using (SqlCommand cmd = new SqlCommand(restoreStock, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@MaHD", maHD);
                                cmd.ExecuteNonQuery();
                            }

                            using (SqlCommand cmd = new SqlCommand("DELETE FROM CHITIETHOADON WHERE MaHD = @MaHD", conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@MaHD", maHD);
                                cmd.ExecuteNonQuery();
                            }

                            using (SqlCommand cmd = new SqlCommand("DELETE FROM HOADON WHERE MaHD = @MaHD AND TinhTrang = 0", conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@MaHD", maHD);
                                if (cmd.ExecuteNonQuery() == 0)
                                {
                                    throw new InvalidOperationException("Không tìm thấy hóa đơn chưa thanh toán để hủy.");
                                }
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }

                    txtMaHD.Clear();
                    txtSoLuong.Clear();
                    SetKhoaControl(false);
                    MessageBox.Show("Đã hủy hóa đơn và hoàn lại tồn kho.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hủy hóa đơn: " + ex.Message);
                }
            }
        }

        // 4. Nút Thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaHD.Text, out int maHD))
            {
                MessageBox.Show("Vui lòng tạo hóa đơn trước khi thanh toán.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE HOADON SET TinhTrang = 1 WHERE MaHD = @MaHD AND TinhTrang = 0 AND EXISTS (SELECT 1 FROM CHITIETHOADON WHERE MaHD = @MaHD)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", maHD);
                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Hóa đơn không tồn tại, đã thanh toán hoặc chưa có sản phẩm.");
                            return;
                        }
                    }

                    MessageBox.Show("Thanh toán hóa đơn thành công!");
                    txtMaHD.Clear();
                    txtSoLuong.Clear();
                    SetKhoaControl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thanh toán hóa đơn: " + ex.Message);
                }
            }
        }
    }

}
