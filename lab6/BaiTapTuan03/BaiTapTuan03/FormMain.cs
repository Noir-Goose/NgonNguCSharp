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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnuTaoTonKho_Click(object sender, EventArgs e)
        {
            // Gọi hàm tạo tồn kho tự động
            ThucHienTaoTonKho();
        }

        private void mnuThemSP_Click(object sender, EventArgs e)
        {
            FormSanPham frm = new FormSanPham();
            frm.ShowDialog();
        }

        private void mnuNhapKho_Click(object sender, EventArgs e)
        {
            using FormNhapKho frm = new FormNhapKho();
            frm.ShowDialog(this);
        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            FormBanHang frm = new FormBanHang();
            frm.ShowDialog();
        }
        private void ThucHienTaoTonKho()
        {
            string connStr = "Server=127.0.0.1,1433;Database=QLCuaHang;User Id=sa;Password=SqlServer@;Encrypt=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    // Câu lệnh tạo tồn kho ngày hôm nay dựa vào ngày hôm qua
                    string query = @"
    INSERT INTO TONKHO (NgayTon, MaSP, SLDau, SLNhap, SLBan)
    SELECT 
        CAST(GETDATE() AS DATE), 
        sp.MaSP,
        ISNULL(tk.SLDau, 0) + ISNULL(tk.SLNhap, 0) - ISNULL(tk.SLBan, 0),
        0, 
        0
    FROM SANPHAM sp
    LEFT JOIN TONKHO tk ON sp.MaSP = tk.MaSP AND tk.NgayTon = DATEADD(day, -1, CAST(GETDATE() AS DATE))
    WHERE NOT EXISTS (
        SELECT 1 FROM TONKHO WHERE NgayTon = CAST(GETDATE() AS DATE) AND MaSP = sp.MaSP
    );";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Đã tạo dữ liệu tồn kho thành công cho {rows} sản phẩm!", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tạo tồn kho: " + ex.Message);
                }
            }
        }
    }
}
