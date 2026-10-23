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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên sản phẩm và đơn giá!");
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số lớn hơn 0!");
                return;
            }

            string connStr = "Server=127.0.0.1,1433;Database=QLCuaHang;User Id=sa;Password=SqlServer@;Encrypt=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string querySP = "INSERT INTO SANPHAM (TenSP, DonGia) OUTPUT INSERTED.MaSP VALUES (@TenSP, @DonGia)";
                            int maSPNew;
                            using (SqlCommand cmd = new SqlCommand(querySP, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text.Trim());
                                cmd.Parameters.AddWithValue("@DonGia", donGia);
                                maSPNew = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            string queryTonKho = "INSERT INTO TONKHO (NgayTon, MaSP, SLDau, SLNhap, SLBan) VALUES (CAST(GETDATE() AS DATE), @MaSP, 0, 0, 0)";
                            using (SqlCommand cmdTK = new SqlCommand(queryTonKho, conn, transaction))
                            {
                                cmdTK.Parameters.AddWithValue("@MaSP", maSPNew);
                                cmdTK.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }

                    MessageBox.Show("Thêm sản phẩm thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
   
    }
