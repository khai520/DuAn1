namespace APPBanHang
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
            label1 = new Label();
            dgvDanhSachSanPham = new DataGridView();
            panel1 = new Panel();
            button13 = new Button();
            cbxNhaCungCap = new ComboBox();
            label12 = new Label();
            txtNguoiNhap = new TextBox();
            label7 = new Label();
            button8 = new Button();
            dtpNgayNhap = new DateTimePicker();
            button11 = new Button();
            cbxTrangThai = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            button10 = new Button();
            button9 = new Button();
            txtSoLuongTon = new TextBox();
            txtTenSP = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(249, 393);
            label1.Name = "label1";
            label1.Size = new Size(242, 23);
            label1.TabIndex = 2;
            label1.Text = "Danh Sách Sản Phẩm";
            // 
            // dgvDanhSachSanPham
            // 
            dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSanPham.Location = new Point(235, 432);
            dgvDanhSachSanPham.Margin = new Padding(3, 4, 3, 4);
            dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            dgvDanhSachSanPham.RowHeadersWidth = 51;
            dgvDanhSachSanPham.RowTemplate.Height = 25;
            dgvDanhSachSanPham.Size = new Size(1073, 316);
            dgvDanhSachSanPham.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button13);
            panel1.Controls.Add(cbxNhaCungCap);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtNguoiNhap);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(dtpNgayNhap);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(cbxTrangThai);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(txtSoLuongTon);
            panel1.Controls.Add(txtTenSP);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(235, 64);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 320);
            panel1.TabIndex = 0;
            // 
            // button13
            // 
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(855, 247);
            button13.Margin = new Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Size = new Size(192, 56);
            button13.TabIndex = 32;
            button13.Text = "Thêm Nhà Cung Cấp";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // cbxNhaCungCap
            // 
            cbxNhaCungCap.FormattingEnabled = true;
            cbxNhaCungCap.Location = new Point(606, 111);
            cbxNhaCungCap.Margin = new Padding(3, 4, 3, 4);
            cbxNhaCungCap.Name = "cbxNhaCungCap";
            cbxNhaCungCap.Size = new Size(138, 28);
            cbxNhaCungCap.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(606, 79);
            label12.Name = "label12";
            label12.Size = new Size(141, 20);
            label12.TabIndex = 30;
            label12.Text = "Nhà Cung Cấp";
            // 
            // txtNguoiNhap
            // 
            txtNguoiNhap.BorderStyle = BorderStyle.FixedSingle;
            txtNguoiNhap.Location = new Point(755, 111);
            txtNguoiNhap.Margin = new Padding(3, 4, 3, 4);
            txtNguoiNhap.Multiline = true;
            txtNguoiNhap.Name = "txtNguoiNhap";
            txtNguoiNhap.Size = new Size(172, 30);
            txtNguoiNhap.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(767, 80);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 28;
            label7.Text = "Người Nhập";
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(32, 247);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(192, 56);
            button8.TabIndex = 26;
            button8.Text = "Thêm sản phẩm";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Location = new Point(32, 191);
            dtpNgayNhap.Margin = new Padding(3, 4, 3, 4);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(234, 27);
            dtpNgayNhap.TabIndex = 25;
            // 
            // button11
            // 
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(447, 247);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(192, 56);
            button11.TabIndex = 24;
            button11.Text = "Lọc";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // cbxTrangThai
            // 
            cbxTrangThai.FormattingEnabled = true;
            cbxTrangThai.Location = new Point(454, 111);
            cbxTrangThai.Margin = new Padding(3, 4, 3, 4);
            cbxTrangThai.Name = "cbxTrangThai";
            cbxTrangThai.Size = new Size(138, 28);
            cbxTrangThai.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(454, 79);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 17;
            label9.Text = "Trạng Thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(29, 155);
            label8.Name = "label8";
            label8.Size = new Size(112, 20);
            label8.TabIndex = 16;
            label8.Text = "Ngày Nhập";
            // 
            // button10
            // 
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(240, 247);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(192, 56);
            button10.TabIndex = 13;
            button10.Text = "Sửa";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(655, 247);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(192, 56);
            button9.TabIndex = 12;
            button9.Text = "Xóa";
            button9.UseVisualStyleBackColor = true;
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuongTon.Location = new Point(251, 111);
            txtSoLuongTon.Margin = new Padding(3, 4, 3, 4);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.Size = new Size(180, 27);
            txtSoLuongTon.TabIndex = 7;
            // 
            // txtTenSP
            // 
            txtTenSP.BorderStyle = BorderStyle.FixedSingle;
            txtTenSP.Location = new Point(32, 111);
            txtTenSP.Margin = new Padding(3, 4, 3, 4);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(192, 27);
            txtTenSP.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(248, 80);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 3;
            label5.Text = "Số Lượng Tồn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 79);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 24);
            label2.Name = "label2";
            label2.Size = new Size(134, 31);
            label2.TabIndex = 0;
            label2.Text = "Sản Phẩm";
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Location = new Point(0, 256);
            btnTrangChu.Margin = new Padding(3, 4, 3, 4);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(234, 41);
            btnTrangChu.TabIndex = 15;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 229);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnSanPham
            // 
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Location = new Point(0, 305);
            btnSanPham.Margin = new Padding(3, 4, 3, 4);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(234, 41);
            btnSanPham.TabIndex = 23;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(0, 355);
            btnNhanVien.Margin = new Padding(3, 4, 3, 4);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(234, 41);
            btnNhanVien.TabIndex = 24;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += button3_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Location = new Point(0, 404);
            btnKhachHang.Margin = new Padding(3, 4, 3, 4);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(234, 41);
            btnKhachHang.TabIndex = 25;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += button4_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(0, 707);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(234, 41);
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
            panel2.Location = new Point(233, 3);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1075, 61);
            panel2.TabIndex = 28;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.Location = new Point(1030, 0);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(46, 40);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "X";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btn1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(327, 11);
            label11.Name = "label11";
            label11.Size = new Size(226, 36);
            label11.TabIndex = 3;
            label11.Text = "Snaker Shop";
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 65);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(682, 133);
            panel3.TabIndex = 2;
            // 
            // btnVoucher
            // 
            btnVoucher.FlatStyle = FlatStyle.Flat;
            btnVoucher.Location = new Point(0, 453);
            btnVoucher.Margin = new Padding(3, 4, 3, 4);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(234, 41);
            btnVoucher.TabIndex = 60;
            btnVoucher.Text = "Voucher";
            btnVoucher.UseVisualStyleBackColor = true;
            btnVoucher.Click += button_Click_Voucher;
            // 
            // btnBanHang
            // 
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Location = new Point(0, 503);
            btnBanHang.Margin = new Padding(3, 4, 3, 4);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(234, 41);
            btnBanHang.TabIndex = 74;
            btnBanHang.Text = "Bán Hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += button_Click_BanHang;
            // 
            // SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 764);
            Controls.Add(label1);
            Controls.Add(dgvDanhSachSanPham);
            Controls.Add(btnBanHang);
            Controls.Add(btnVoucher);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnExit);
            Controls.Add(btnKhachHang);
            Controls.Add(btnNhanVien);
            Controls.Add(btnSanPham);
            Controls.Add(pictureBox1);
            Controls.Add(btnTrangChu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SanPham";
            Load += SanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvDanhSachSanPham;
        private Panel panel1;
        private Button button10;
        private TextBox txtSoLuongTon;
        private TextBox txtTenSP;
        private Label label5;
        private Label label3;
        private Label label2;
        private ComboBox cbxTrangThai;
        private Label label9;
        private Label label8;
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
        private Button button9;
        private Button button11;
        private Button btnVoucher;
        private Button btnBanHang;
        private Button button8;
        private DateTimePicker dtpNgayNhap;
        private TextBox txtNguoiNhap;
        private Label label7;
        private Button button13;
        private ComboBox cbxNhaCungCap;
        private Label label12;
    }
}