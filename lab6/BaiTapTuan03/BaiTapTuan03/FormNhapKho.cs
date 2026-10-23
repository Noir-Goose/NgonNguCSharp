using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapTuan03
{
    public partial class FormNhapKho : Form
    {
        private const string ConnectionString = "Server=127.0.0.1,1433;Database=QLCuaHang;User Id=sa;Password=SqlServer@;Encrypt=True;TrustServerCertificate=True;";
        private readonly ComboBox cboSanPham = new ComboBox();
        private readonly NumericUpDown numSoLuong = new NumericUpDown();
        private readonly Button btnNhap = new Button();

        public FormNhapKho()
        {
            Text = "Nhập kho";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(460, 210);

            Label lblSanPham = new Label
            {
                AutoSize = true,
                Location = new Point(30, 35),
                Text = "Sản phẩm"
            };
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.Location = new Point(140, 30);
            cboSanPham.Size = new Size(280, 28);

            Label lblSoLuong = new Label
            {
                AutoSize = true,
                Location = new Point(30, 82),
                Text = "Số lượng nhập"
            };
            numSoLuong.Location = new Point(140, 78);
            numSoLuong.Minimum = 1;
            numSoLuong.Maximum = 1000000;
            numSoLuong.Size = new Size(140, 27);

            btnNhap.Location = new Point(140, 130);
            btnNhap.Size = new Size(100, 36);
            btnNhap.Text = "Nhập kho";
            btnNhap.Click += btnNhap_Click;

            Button btnDong = new Button
            {
                Location = new Point(260, 130),
                Size = new Size(100, 36),
                Text = "Đóng"
            };
            btnDong.Click += (sender, args) => Close();

            Controls.Add(lblSanPham);
            Controls.Add(cboSanPham);
            Controls.Add(lblSoLuong);
            Controls.Add(numSoLuong);
            Controls.Add(btnNhap);
            Controls.Add(btnDong);
            Load += FormNhapKho_Load;
        }

        private void FormNhapKho_Load(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(ConnectionString);
                using SqlDataAdapter adapter = new SqlDataAdapter("SELECT MaSP, TenSP FROM SANPHAM ORDER BY TenSP", conn);
                DataTable products = new DataTable();
                adapter.Fill(products);
                cboSanPham.DataSource = products;
                cboSanPham.DisplayMember = "TenSP";
                cboSanPham.ValueMember = "MaSP";
                btnNhap.Enabled = products.Rows.Count > 0;

                if (products.Rows.Count == 0)
                {
                    MessageBox.Show("Chưa có sản phẩm. Hãy thêm sản phẩm trước khi nhập kho.");
                }
            }
            catch (Exception ex)
            {
                btnNhap.Enabled = false;
                MessageBox.Show("Lỗi tải danh sách sản phẩm: " + ex.Message);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.");
                return;
            }

            using SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                using SqlTransaction transaction = conn.BeginTransaction(IsolationLevel.Serializable);
                try
                {
                    string query = @"
DECLARE @Ngay DATE = CAST(GETDATE() AS DATE);

IF EXISTS (
    SELECT 1 FROM TONKHO WITH (UPDLOCK, HOLDLOCK)
    WHERE MaSP = @MaSP AND NgayTon = @Ngay
)
BEGIN
    UPDATE TONKHO
    SET SLNhap = ISNULL(SLNhap, 0) + @SoLuong
    WHERE MaSP = @MaSP AND NgayTon = @Ngay;
END
ELSE
BEGIN
    INSERT INTO TONKHO (NgayTon, MaSP, SLDau, SLNhap, SLBan)
    SELECT
        @Ngay,
        sp.MaSP,
        ISNULL((
            SELECT TOP (1) ISNULL(tk.SLDau, 0) + ISNULL(tk.SLNhap, 0) - ISNULL(tk.SLBan, 0)
            FROM TONKHO tk
            WHERE tk.MaSP = sp.MaSP AND tk.NgayTon < @Ngay
            ORDER BY tk.NgayTon DESC
        ), 0),
        @SoLuong,
        0
    FROM SANPHAM sp
    WHERE sp.MaSP = @MaSP;
END;";
                    using SqlCommand cmd = new SqlCommand(query, conn, transaction);
                    cmd.Parameters.AddWithValue("@MaSP", Convert.ToInt32(cboSanPham.SelectedValue));
                    cmd.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(numSoLuong.Value));
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new InvalidOperationException("Không tìm thấy sản phẩm để nhập kho.");
                    }

                    transaction.Commit();
                    MessageBox.Show("Nhập kho thành công.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập kho: " + ex.Message);
            }
        }
    }
}