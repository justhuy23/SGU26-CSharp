using System;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Sự kiện Load Form: Tạo các nút chữ cái từ A -> Z
        private void Form1_Load(object sender, EventArgs e)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                // Thêm từng chữ cái vào TreeView
                treeView1.Nodes.Add(c.ToString());
            }
        }

        // 2. Sự kiện nút Add: Thêm người vào danh bạ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ First Name và Last Name!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy chữ cái đầu tiên của First Name và chuyển thành chữ hoa
            string firstLetter = firstName.Substring(0, 1).ToUpper();

            // Tìm nút cha tương ứng với chữ cái đầu tiên
            TreeNode parentNode = null;
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Text == firstLetter)
                {
                    parentNode = node;
                    break;
                }
            }

            // Nếu tìm thấy nút cha, thêm người mới vào
            if (parentNode != null)
            {
                // Định dạng hiển thị: "First Name, Last Name"
                string displayName = $"{firstName}, {lastName}";
                
                // Thêm vào node con
                parentNode.Nodes.Add(displayName);
                
                // Mở rộng node cha để người dùng nhìn thấy ngay
                parentNode.Expand();

                // Xóa trắng các ô nhập liệu và đưa con trỏ về ô First Name
                txtFirstName.Clear();
                txtLastName.Clear();
                txtFirstName.Focus();
            }
            else
            {
                // Trường hợp chữ cái đầu không phải A-Z (ví dụ: số, ký tự đặc biệt, hoặc tiếng Việt có dấu)
                MessageBox.Show("Chữ cái đầu tiên của tên không hợp lệ (phải từ A-Z)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 3. Sự kiện nút Exit: Thoát chương trình
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}