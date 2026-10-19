namespace QuanLysinhvien
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // lblMaKhoa
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(30, 30);
            this.lblMaKhoa.Text = "Mã khoa";
            
            // txtMaKhoa
            this.txtMaKhoa.Location = new System.Drawing.Point(100, 27);
            this.txtMaKhoa.Size = new System.Drawing.Size(200, 23);
            
            // lblMaLop
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(30, 70);
            this.lblMaLop.Text = "Mã lớp";
            
            // txtMaLop
            this.txtMaLop.Location = new System.Drawing.Point(100, 67);
            this.txtMaLop.Size = new System.Drawing.Size(200, 23);
            
            // lblTenLop
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(30, 110);
            this.lblTenLop.Text = "Tên lớp";
            
            // txtTenLop
            this.txtTenLop.Location = new System.Drawing.Point(100, 107);
            this.txtTenLop.Size = new System.Drawing.Size(200, 23);
            
            // btnThem
            this.btnThem.Location = new System.Drawing.Point(30, 160);
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            
            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(130, 160);
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            
            // btnSua
            this.btnSua.Location = new System.Drawing.Point(230, 160);
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(350, 220);
            this.Controls.Add(this.lblMaKhoa);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Text = "frmLop";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}