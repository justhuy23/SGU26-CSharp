namespace Bai2
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpListbox = new System.Windows.Forms.GroupBox();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.grpXuLy = new System.Windows.Forms.GroupBox();
            this.btnLe = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.grpListbox.SuspendLayout();
            this.grpXuLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTitle.Location = new System.Drawing.Point(220, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LISTBOX";
            // 
            // grpListbox
            // 
            this.grpListbox.Controls.Add(this.lstSo);
            this.grpListbox.Controls.Add(this.btnNhap);
            this.grpListbox.Controls.Add(this.txtNhap);
            this.grpListbox.Location = new System.Drawing.Point(20, 70);
            this.grpListbox.Name = "grpListbox";
            this.grpListbox.Size = new System.Drawing.Size(200, 300);
            this.grpListbox.TabIndex = 1;
            this.grpListbox.TabStop = false;
            this.grpListbox.Text = "Listbox";
            // 
            // lstSo
            // 
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 15;
            this.lstSo.Location = new System.Drawing.Point(20, 110);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSo.Size = new System.Drawing.Size(160, 169);
            this.lstSo.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNhap.Location = new System.Drawing.Point(20, 65);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(160, 30);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(20, 30);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(160, 23);
            this.txtNhap.TabIndex = 0;
            // 
            // grpXuLy
            // 
            this.grpXuLy.Controls.Add(this.btnLe);
            this.grpXuLy.Controls.Add(this.btnChan);
            this.grpXuLy.Controls.Add(this.btnBinhPhuong);
            this.grpXuLy.Controls.Add(this.btnTang2);
            this.grpXuLy.Controls.Add(this.btnXoaChon);
            this.grpXuLy.Controls.Add(this.btnXoaDauCuoi);
            this.grpXuLy.Controls.Add(this.btnTong);
            this.grpXuLy.Location = new System.Drawing.Point(240, 70);
            this.grpXuLy.Name = "grpXuLy";
            this.grpXuLy.Size = new System.Drawing.Size(320, 300);
            this.grpXuLy.TabIndex = 2;
            this.grpXuLy.TabStop = false;
            this.grpXuLy.Text = "Xử Lý Listbox";
            // 
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(20, 260);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(280, 30);
            this.btnLe.TabIndex = 6;
            this.btnLe.Text = "Chọn số lẽ";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(20, 220);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(280, 30);
            this.btnChan.TabIndex = 5;
            this.btnChan.Text = "Chọn số chẵn";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(20, 180);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(280, 30);
            this.btnBinhPhuong.TabIndex = 4;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(20, 140);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(280, 30);
            this.btnTang2.TabIndex = 3;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(20, 100);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(280, 30);
            this.btnXoaChon.TabIndex = 2;
            this.btnXoaChon.Text = "Xóa Phần tử đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(20, 60);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(280, 30);
            this.btnXoaDauCuoi.TabIndex = 1;
            this.btnXoaDauCuoi.Text = "Xóa Phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(20, 20);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(280, 30);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tổng các phần tử trong List";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(20, 380);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(540, 30);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "KẾT THÚC";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 431);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.grpXuLy);
            this.Controls.Add(this.grpListbox);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "frmListbox";
            this.grpListbox.ResumeLayout(false);
            this.grpListbox.PerformLayout();
            this.grpXuLy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpListbox;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox grpXuLy;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnKetThuc;
    }
}