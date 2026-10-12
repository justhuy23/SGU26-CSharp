using System;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Nút Nhập: Thêm số vào ListBox
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int number;
            // Kiểm tra dữ liệu nhập
            if (!int.TryParse(txtNhap.Text, out number))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhap.Clear();
                txtNhap.Focus();
                return;
            }

            // Thêm số vào ListBox
            lstSo.Items.Add(number);
            txtNhap.Clear();
            txtNhap.Focus();
        }

        // 2. Nút Tính Tổng
        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var item in lstSo.Items)
            {
                sum += int.Parse(item.ToString());
            }
            MessageBox.Show($"Tổng các phần tử trong List là: {sum}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 3. Nút Xóa Phần tử đầu và cuối
        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xóa phần tử đầu tiên (index 0)
            lstSo.Items.RemoveAt(0);

            // Nếu sau khi xóa mà vẫn còn phần tử, xóa phần tử cuối cùng
            if (lstSo.Items.Count > 0)
            {
                lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
            }
        }

        // 4. Nút Xóa Phần tử đang chọn
        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (lstSo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một phần tử để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Duyệt ngược từ dưới lên để tránh lỗi index thay đổi khi xóa
            for (int i = lstSo.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndices[i]);
            }
        }

        // 5. Nút Tăng mỗi phần tử lên 2
        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int val = int.Parse(lstSo.Items[i].ToString());
                lstSo.Items[i] = val + 2;
            }
        }

        // 6. Nút Thay bằng bình phương
        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int val = int.Parse(lstSo.Items[i].ToString());
                lstSo.Items[i] = val * val;
            }
        }

        // 7. Nút Chọn số chẵn
        private void btnChan_Click(object sender, EventArgs e)
        {
            lstSo.ClearSelected(); // Bỏ chọn tất cả trước
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int val = int.Parse(lstSo.Items[i].ToString());
                if (val % 2 == 0)
                {
                    lstSo.SetSelected(i, true); // Chọn phần tử chẵn
                }
            }
        }

        // 8. Nút Chọn số lẻ
        private void btnLe_Click(object sender, EventArgs e)
        {
            lstSo.ClearSelected(); // Bỏ chọn tất cả trước
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int val = int.Parse(lstSo.Items[i].ToString());
                if (val % 2 != 0)
                {
                    lstSo.SetSelected(i, true); // Chọn phần tử lẻ
                }
            }
        }

        // 9. Nút Kết thúc
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}