using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLysinhvien
{
    public partial class Form1 : Form
    {
        
        string connectionString = @"Data Source=localhost;Initial Catalog=QLSinhVien;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã khoa, Mã lớp, Tên lớp!", "Cảnh báo");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Lop (MaLop, MaKhoa, TenLop) VALUES (@MaLop, @MaKhoa, @TenLop)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!");
                        txtMaKhoa.Clear(); txtMaLop.Clear(); txtTenLop.Clear();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã lớp cần xóa!", "Cảnh báo");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Lop WHERE MaLop = @MaLop";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                            txtMaKhoa.Clear(); txtMaLop.Clear(); txtTenLop.Clear();
                        }
                        else MessageBox.Show("Không tìm thấy Mã lớp!");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp không được để trống!", "Cảnh báo");
                return;
            }
            bool hasMaKhoa = !string.IsNullOrWhiteSpace(txtMaKhoa.Text);
            bool hasTenLop = !string.IsNullOrWhiteSpace(txtTenLop.Text);
            if (!hasMaKhoa && !hasTenLop)
            {
                MessageBox.Show("Phải nhập ít nhất Mã khoa hoặc Tên lớp để sửa!", "Cảnh báo");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    List<string> updates = new List<string>();
                    if (hasMaKhoa) updates.Add("MaKhoa = @MaKhoa");
                    if (hasTenLop) updates.Add("TenLop = @TenLop");

                    string query = "UPDATE Lop SET " + string.Join(", ", updates) + " WHERE MaLop = @MaLop";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                        if (hasMaKhoa) cmd.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text.Trim());
                        if (hasTenLop) cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text.Trim());

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0) MessageBox.Show("Cập nhật thành công!");
                        else MessageBox.Show("Không tìm thấy Mã lớp cần sửa!");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
    }
}