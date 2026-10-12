using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        // Từ điển Anh - Việt
        private Dictionary<string, string> tuDienAnhViet = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        // Từ điển Việt - Anh
        private Dictionary<string, string> tuDienVietAnh = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public Form1()
        {
            InitializeComponent();
            LoadData(); 
        }

        private void LoadData()
        {
            // 1. Nạp dữ liệu cho Anh - Việt
            tuDienAnhViet.Add("student", "Sinh viên, học sinh");
            tuDienAnhViet.Add("teacher", "Giáo viên");
            tuDienAnhViet.Add("worker", "Công nhân");
            tuDienAnhViet.Add("hat", "Cái mũ");
            tuDienAnhViet.Add("head", "Cái đầu");
            tuDienAnhViet.Add("mouse", "Con chuột");
            tuDienAnhViet.Add("cat", "Con mèo");
            tuDienAnhViet.Add("dog", "Con chó");
            tuDienAnhViet.Add("snake", "Con rắn");
            tuDienAnhViet.Add("lumb", "Cái lưng");
            tuDienAnhViet.Add("loaf", "Ổ bánh mì");
            tuDienAnhViet.Add("frog", "Con ếch");
            tuDienAnhViet.Add("sheep", "Con cừu");

            // Đổ vào ComboBox và ListBox Tab 1
            foreach (var key in tuDienAnhViet.Keys)
            {
                cboAnh.Items.Add(key);
                lstTuAnh.Items.Add(key);
            }

            // 2. Nạp dữ liệu cho Việt - Anh (Dịch ngược lại từ điển trên)
            foreach (var pair in tuDienAnhViet)
            {
                // Nếu nghĩa tiếng Việt chưa tồn tại trong từ điển Việt-Anh thì thêm vào
                if (!tuDienVietAnh.ContainsKey(pair.Value))
                {
                    tuDienVietAnh.Add(pair.Value, pair.Key);
                }
            }

            // Đổ vào ComboBox và ListBox Tab 2
            foreach (var key in tuDienVietAnh.Keys)
            {
                cboViet.Items.Add(key);
                lstTuViet.Items.Add(key);
            }
        }

        // ================= TAB 1: ANH - VIỆT =================
        private void HienThiNghiaAnhViet(string tuKhoa)
        {
            tuKhoa = tuKhoa.Trim();
            if (tuDienAnhViet.ContainsKey(tuKhoa))
                txtViet.Text = tuDienAnhViet[tuKhoa];
            else
                txtViet.Text = "Không tìm thấy từ này trong từ điển!";
        }

        private void lstTuAnh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTuAnh.SelectedItem != null)
            {
                string tuChon = lstTuAnh.SelectedItem.ToString();
                cboAnh.Text = tuChon;
                HienThiNghiaAnhViet(tuChon);
            }
        }

        private void cboAnh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HienThiNghiaAnhViet(cboAnh.Text);
                e.SuppressKeyPress = true;
            }
        }

        // ================= TAB 2: VIỆT - ANH =================
        private void HienThiNghiaVietAnh(string tuKhoa)
        {
            tuKhoa = tuKhoa.Trim();
            if (tuDienVietAnh.ContainsKey(tuKhoa))
                txtAnh.Text = tuDienVietAnh[tuKhoa];
            else
                txtAnh.Text = "Không tìm thấy từ này trong từ điển!";
        }

        private void lstTuViet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTuViet.SelectedItem != null)
            {
                string tuChon = lstTuViet.SelectedItem.ToString();
                cboViet.Text = tuChon;
                HienThiNghiaVietAnh(tuChon);
            }
        }

        private void cboViet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HienThiNghiaVietAnh(cboViet.Text);
                e.SuppressKeyPress = true;
            }
        }

        // ================= NÚT THOÁT =================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}