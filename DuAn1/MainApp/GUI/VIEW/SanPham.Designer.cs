﻿namespace APPBanHang
{
    partial class SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            btnTrangChu = new Button();
            pictureBox1 = new PictureBox();
            btnSanPham = new Button();
            btnNhanVien = new Button();
            btnKhachHang = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            btnThoat = new Button();
            label11 = new Label();
            panel3 = new Panel();
            btnVoucher = new Button();
            btnBanHang = new Button();
            tab1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            label1 = new Label();
            txtGiaBan = new TextBox();
            dgvDanhSachSanPham = new DataGridView();
            label6 = new Label();
            btnThemSanPham = new Button();
            cbxNhaCungCap = new ComboBox();
            label12 = new Label();
            cbxTrangThai = new ComboBox();
            label9 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            txtSoLuongTon = new TextBox();
            txtTenSP = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            tab2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tab1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).BeginInit();
            SuspendLayout();
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Location = new Point(0, 192);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(205, 31);
            btnTrangChu.TabIndex = 15;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 172);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnSanPham
            // 
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Location = new Point(0, 229);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(205, 31);
            btnSanPham.TabIndex = 23;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(0, 266);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(205, 31);
            btnNhanVien.TabIndex = 24;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Location = new Point(0, 303);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(205, 31);
            btnKhachHang.TabIndex = 25;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(0, 530);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(205, 31);
            btnExit.TabIndex = 27;
            btnExit.Text = "Đăng Xuất";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(204, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 46);
            panel2.TabIndex = 28;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.Location = new Point(901, 0);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(40, 30);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "X";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btn1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(286, 8);
            label11.Name = "label11";
            label11.Size = new Size(182, 29);
            label11.TabIndex = 3;
            label11.Text = "Snaker Shop";
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(597, 100);
            panel3.TabIndex = 2;
            // 
            // btnVoucher
            // 
            btnVoucher.FlatStyle = FlatStyle.Flat;
            btnVoucher.Location = new Point(0, 340);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(205, 31);
            btnVoucher.TabIndex = 60;
            btnVoucher.Text = "Voucher";
            btnVoucher.UseVisualStyleBackColor = true;
            btnVoucher.Click += button_Click_Voucher;
            // 
            // btnBanHang
            // 
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Location = new Point(0, 377);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(205, 31);
            btnBanHang.TabIndex = 74;
            btnBanHang.Text = "Bán Hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += button_Click_BanHang;
            // 
            // tab1
            // 
            tab1.Controls.Add(tabPage1);
            tab1.Controls.Add(tab2);
            tab1.Location = new Point(211, 51);
            tab1.Name = "tab1";
            tab1.SelectedIndex = 0;
            tab1.Size = new Size(914, 510);
            tab1.TabIndex = 35;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(906, 482);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sản phẩm";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtGiaBan);
            panel1.Controls.Add(dgvDanhSachSanPham);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnThemSanPham);
            panel1.Controls.Add(cbxNhaCungCap);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(cbxTrangThai);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(txtSoLuongTon);
            panel1.Controls.Add(txtTenSP);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(8, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 468);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 214);
            label1.Name = "label1";
            label1.Size = new Size(182, 18);
            label1.TabIndex = 5;
            label1.Text = "Danh Sách Sản Phẩm";
            // 
            // txtGiaBan
            // 
            txtGiaBan.BorderStyle = BorderStyle.FixedSingle;
            txtGiaBan.Location = new Point(530, 82);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(158, 23);
            txtGiaBan.TabIndex = 34;
            // 
            // dgvDanhSachSanPham
            // 
            dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSanPham.Location = new Point(3, 235);
            dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            dgvDanhSachSanPham.RowHeadersWidth = 51;
            dgvDanhSachSanPham.RowTemplate.Height = 25;
            dgvDanhSachSanPham.Size = new Size(884, 230);
            dgvDanhSachSanPham.TabIndex = 4;
            dgvDanhSachSanPham.CellClick += dgvDanhSachSanPham_CellClick;
            dgvDanhSachSanPham.SelectionChanged += dgvDanhSachSanPham_SelectionChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(530, 59);
            label6.Name = "label6";
            label6.Size = new Size(62, 16);
            label6.TabIndex = 33;
            label6.Text = "Giá Bán";
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.FlatStyle = FlatStyle.Flat;
            btnThemSanPham.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemSanPham.Location = new Point(311, 172);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(168, 42);
            btnThemSanPham.TabIndex = 32;
            btnThemSanPham.Text = "Thêm Sản Phẩm";
            btnThemSanPham.UseVisualStyleBackColor = true;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // cbxNhaCungCap
            // 
            cbxNhaCungCap.FormattingEnabled = true;
            cbxNhaCungCap.Location = new Point(708, 82);
            cbxNhaCungCap.Name = "cbxNhaCungCap";
            cbxNhaCungCap.Size = new Size(121, 23);
            cbxNhaCungCap.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(708, 60);
            label12.Name = "label12";
            label12.Size = new Size(108, 16);
            label12.TabIndex = 30;
            label12.Text = "Nhà Cung Cấp";
            // 
            // cbxTrangThai
            // 
            cbxTrangThai.FormattingEnabled = true;
            cbxTrangThai.Items.AddRange(new object[] { "Còn Hàng", "Hết Hàng" });
            cbxTrangThai.Location = new Point(397, 83);
            cbxTrangThai.Name = "cbxTrangThai";
            cbxTrangThai.Size = new Size(121, 23);
            cbxTrangThai.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(397, 59);
            label9.Name = "label9";
            label9.Size = new Size(82, 16);
            label9.TabIndex = 17;
            label9.Text = "Trạng Thái";
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(485, 172);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(168, 42);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(659, 172);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(168, 42);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuongTon.Location = new Point(220, 83);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.Size = new Size(158, 23);
            txtSoLuongTon.TabIndex = 7;
            // 
            // txtTenSP
            // 
            txtTenSP.BorderStyle = BorderStyle.FixedSingle;
            txtTenSP.Location = new Point(28, 83);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(168, 23);
            txtTenSP.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(217, 60);
            label5.Name = "label5";
            label5.Size = new Size(104, 16);
            label5.TabIndex = 3;
            label5.Text = "Số Lượng Tồn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 59);
            label3.Name = "label3";
            label3.Size = new Size(33, 16);
            label3.TabIndex = 1;
            label3.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 0;
            label2.Text = "Sản Phẩm";
            // 
            // tab2
            // 
            tab2.Location = new Point(4, 24);
            tab2.Name = "tab2";
            tab2.Padding = new Padding(3);
            tab2.Size = new Size(906, 482);
            tab2.TabIndex = 1;
            tab2.Text = "Chi tiết sản phẩm";
            tab2.UseVisualStyleBackColor = true;
            // 
            // SanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 573);
            Controls.Add(tab1);
            Controls.Add(btnBanHang);
            Controls.Add(btnVoucher);
            Controls.Add(panel2);
            Controls.Add(btnExit);
            Controls.Add(btnKhachHang);
            Controls.Add(btnNhanVien);
            Controls.Add(btnSanPham);
            Controls.Add(pictureBox1);
            Controls.Add(btnTrangChu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SanPham";
            Load += SanPham_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tab1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTrangChu;
        private PictureBox pictureBox1;
        private Button btnSanPham;
        private Button btnNhanVien;
        private Button btnKhachHang;
        private Button btnExit;
        private Panel panel2;
        private Button btnThoat;
        private Label label11;
        private Panel panel3;
        private Button btnVoucher;
        private Button btnBanHang;
        private TabPage tabPage1;
        private TabPage tab2;
        private Panel panel1;
        private Label label1;
        private TextBox txtGiaBan;
        private DataGridView dgvDanhSachSanPham;
        private Label label6;
        private Button btnThemSanPham;
        private ComboBox cbxNhaCungCap;
        private Label label12;
        private ComboBox cbxTrangThai;
        private Label label9;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtSoLuongTon;
        private TextBox txtTenSP;
        private Label label5;
        private Label label3;
        private Label label2;
        public TabControl tab1;
    }
}