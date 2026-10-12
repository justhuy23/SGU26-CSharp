namespace Bai1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnThoat1 = new System.Windows.Forms.Button();
            this.txtViet = new System.Windows.Forms.TextBox();
            this.lblViet1 = new System.Windows.Forms.Label();
            this.lstTuAnh = new System.Windows.Forms.ListBox();
            this.cboAnh = new System.Windows.Forms.ComboBox();
            this.lblAnh1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnThoat2 = new System.Windows.Forms.Button();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.lblAnh2 = new System.Windows.Forms.Label();
            this.lstTuViet = new System.Windows.Forms.ListBox();
            this.cboViet = new System.Windows.Forms.ComboBox();
            this.lblViet2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1 (ANH - VIỆT)
            // 
            this.tabPage1.Controls.Add(this.btnThoat1);
            this.tabPage1.Controls.Add(this.txtViet);
            this.tabPage1.Controls.Add(this.lblViet1);
            this.tabPage1.Controls.Add(this.lstTuAnh);
            this.tabPage1.Controls.Add(this.cboAnh);
            this.tabPage1.Controls.Add(this.lblAnh1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ANH - VIỆT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnThoat1
            // 
            this.btnThoat1.Location = new System.Drawing.Point(400, 310);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(100, 30);
            this.btnThoat1.TabIndex = 5;
            this.btnThoat1.Text = "Thoát";
            this.btnThoat1.UseVisualStyleBackColor = true;
            this.btnThoat1.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtViet
            // 
            this.txtViet.Location = new System.Drawing.Point(250, 50);
            this.txtViet.Multiline = true;
            this.txtViet.Name = "txtViet";
            this.txtViet.ReadOnly = true;
            this.txtViet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtViet.Size = new System.Drawing.Size(250, 240);
            this.txtViet.TabIndex = 4;
            // 
            // lblViet1
            // 
            this.lblViet1.AutoSize = true;
            this.lblViet1.Location = new System.Drawing.Point(250, 30);
            this.lblViet1.Name = "lblViet1";
            this.lblViet1.Size = new System.Drawing.Size(58, 15);
            this.lblViet1.TabIndex = 3;
            this.lblViet1.Text = "Tiếng Việt";
            // 
            // lstTuAnh
            // 
            this.lstTuAnh.FormattingEnabled = true;
            this.lstTuAnh.ItemHeight = 15;
            this.lstTuAnh.Location = new System.Drawing.Point(30, 80);
            this.lstTuAnh.Name = "lstTuAnh";
            this.lstTuAnh.Size = new System.Drawing.Size(180, 214);
            this.lstTuAnh.TabIndex = 2;
            this.lstTuAnh.SelectedIndexChanged += new System.EventHandler(this.lstTuAnh_SelectedIndexChanged);
            // 
            // cboAnh
            // 
            this.cboAnh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAnh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAnh.FormattingEnabled = true;
            this.cboAnh.Location = new System.Drawing.Point(30, 50);
            this.cboAnh.Name = "cboAnh";
            this.cboAnh.Size = new System.Drawing.Size(180, 23);
            this.cboAnh.TabIndex = 1;
            this.cboAnh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboAnh_KeyDown);
            // 
            // lblAnh1
            // 
            this.lblAnh1.AutoSize = true;
            this.lblAnh1.Location = new System.Drawing.Point(30, 30);
            this.lblAnh1.Name = "lblAnh1";
            this.lblAnh1.Size = new System.Drawing.Size(57, 15);
            this.lblAnh1.TabIndex = 0;
            this.lblAnh1.Text = "Tiếng Anh";
            // 
            // tabPage2 (VIỆT - ANH)
            // 
            this.tabPage2.Controls.Add(this.btnThoat2);
            this.tabPage2.Controls.Add(this.txtAnh);
            this.tabPage2.Controls.Add(this.lblAnh2);
            this.tabPage2.Controls.Add(this.lstTuViet);
            this.tabPage2.Controls.Add(this.cboViet);
            this.tabPage2.Controls.Add(this.lblViet2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VIỆT - ANH";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnThoat2
            // 
            this.btnThoat2.Location = new System.Drawing.Point(400, 310);
            this.btnThoat2.Name = "btnThoat2";
            this.btnThoat2.Size = new System.Drawing.Size(100, 30);
            this.btnThoat2.TabIndex = 5;
            this.btnThoat2.Text = "Thoát";
            this.btnThoat2.UseVisualStyleBackColor = true;
            this.btnThoat2.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(250, 50);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.ReadOnly = true;
            this.txtAnh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnh.Size = new System.Drawing.Size(250, 240);
            this.txtAnh.TabIndex = 4;
            // 
            // lblAnh2
            // 
            this.lblAnh2.AutoSize = true;
            this.lblAnh2.Location = new System.Drawing.Point(250, 30);
            this.lblAnh2.Name = "lblAnh2";
            this.lblAnh2.Size = new System.Drawing.Size(57, 15);
            this.lblAnh2.TabIndex = 3;
            this.lblAnh2.Text = "Tiếng Anh";
            // 
            // lstTuViet
            // 
            this.lstTuViet.FormattingEnabled = true;
            this.lstTuViet.ItemHeight = 15;
            this.lstTuViet.Location = new System.Drawing.Point(30, 80);
            this.lstTuViet.Name = "lstTuViet";
            this.lstTuViet.Size = new System.Drawing.Size(180, 214);
            this.lstTuViet.TabIndex = 2;
            this.lstTuViet.SelectedIndexChanged += new System.EventHandler(this.lstTuViet_SelectedIndexChanged);
            // 
            // cboViet
            // 
            this.cboViet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboViet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboViet.FormattingEnabled = true;
            this.cboViet.Location = new System.Drawing.Point(30, 50);
            this.cboViet.Name = "cboViet";
            this.cboViet.Size = new System.Drawing.Size(180, 23);
            this.cboViet.TabIndex = 1;
            this.cboViet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboViet_KeyDown);
            // 
            // lblViet2
            // 
            this.lblViet2.AutoSize = true;
            this.lblViet2.Location = new System.Drawing.Point(30, 30);
            this.lblViet2.Name = "lblViet2";
            this.lblViet2.Size = new System.Drawing.Size(58, 15);
            this.lblViet2.TabIndex = 0;
            this.lblViet2.Text = "Tiếng Việt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 431);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TỪ ĐIỂN ANH - VIỆT - ANH";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblAnh1;
        private System.Windows.Forms.ComboBox cboAnh;
        private System.Windows.Forms.ListBox lstTuAnh;
        private System.Windows.Forms.Label lblViet1;
        private System.Windows.Forms.TextBox txtViet;
        private System.Windows.Forms.Button btnThoat1;
        
        private System.Windows.Forms.Label lblViet2;
        private System.Windows.Forms.ComboBox cboViet;
        private System.Windows.Forms.ListBox lstTuViet;
        private System.Windows.Forms.Label lblAnh2;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Button btnThoat2;
    }
}