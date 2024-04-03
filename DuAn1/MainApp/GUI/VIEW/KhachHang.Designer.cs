namespace APPBanHang
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            btnTrangChu = new Button();
            btnSanPham = new Button();
            btnNhanVien = new Button();
            btnKhachHang = new Button();
            btnLogout = new Button();
            label1 = new Label();
            dgvDanhSachKhachHang = new DataGridView();
            panel1 = new Panel();
            txtDiem = new TextBox();
            label10 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            btnSua = new Button();
            btnLoc = new Button();
            btnLuu = new Button();
            label7 = new Label();
            dtpNgaySinh = new DateTimePicker();
            txtSoDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            txtTenKhachHang = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            label8 = new Label();
            panel3 = new Panel();
            btnVoucher = new Button();
            btnBanHang = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachKhachHang).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Location = new Point(0, 192);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(205, 31);
            btnTrangChu.TabIndex = 14;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += button1_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Location = new Point(0, 229);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(205, 31);
            btnSanPham.TabIndex = 15;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += button2_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(0, 266);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(205, 31);
            btnNhanVien.TabIndex = 16;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += button3_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Location = new Point(0, 303);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(205, 31);
            btnKhachHang.TabIndex = 17;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(0, 530);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(205, 31);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(212, 298);
            label1.Name = "label1";
            label1.Size = new Size(196, 18);
            label1.TabIndex = 2;
            label1.Text = "Danh Sách Khách Hàng";
            // 
            // dgvDanhSachKhachHang
            // 
            dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachKhachHang.Location = new Point(208, 328);
            dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang";
            dgvDanhSachKhachHang.RowTemplate.Height = 25;
            dgvDanhSachKhachHang.Size = new Size(937, 233);
            dgvDanhSachKhachHang.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtDiem);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnLoc);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dtpNgaySinh);
            panel1.Controls.Add(txtSoDienThoai);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtTenKhachHang);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(208, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 240);
            panel1.TabIndex = 0;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(688, 143);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(151, 23);
            txtDiem.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(688, 118);
            label10.Name = "label10";
            label10.Size = new Size(44, 16);
            label10.TabIndex = 18;
            label10.Text = "Điểm";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(27, 143);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 23);
            txtEmail.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(24, 118);
            label9.Name = "label9";
            label9.Size = new Size(47, 16);
            label9.TabIndex = 16;
            label9.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(688, 83);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 23);
            textBox4.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(688, 59);
            label6.Name = "label6";
            label6.Size = new Size(104, 16);
            label6.TabIndex = 14;
            label6.Text = "Số Điện Thoại";
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(606, 184);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 42);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoc.Location = new Point(725, 184);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(100, 42);
            btnLoc.TabIndex = 12;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.Location = new Point(488, 184);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 42);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(471, 118);
            label7.Name = "label7";
            label7.Size = new Size(79, 16);
            label7.TabIndex = 10;
            label7.Text = "Ngày Sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(471, 143);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 23);
            dtpNgaySinh.TabIndex = 9;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(471, 83);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(197, 23);
            txtSoDienThoai.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(233, 83);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(224, 120);
            txtDiaChi.TabIndex = 6;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(28, 83);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(168, 23);
            txtTenKhachHang.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(471, 59);
            label5.Name = "label5";
            label5.Size = new Size(104, 16);
            label5.TabIndex = 3;
            label5.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(230, 59);
            label4.Name = "label4";
            label4.Size = new Size(57, 16);
            label4.TabIndex = 2;
            label4.Text = "Địa Chỉ";
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
            label2.Size = new Size(183, 25);
            label2.TabIndex = 0;
            label2.Text = "Thêm Khách Hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 175);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(205, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 53);
            panel2.TabIndex = 21;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Location = new Point(900, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 30);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btn1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(286, 8);
            label8.Name = "label8";
            label8.Size = new Size(182, 29);
            label8.TabIndex = 3;
            label8.Text = "Snaker Shop";
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
            btnBanHang.TabIndex = 73;
            btnBanHang.Text = "Bán Hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += button_Click_BanHang;
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 573);
            Controls.Add(label1);
            Controls.Add(dgvDanhSachKhachHang);
            Controls.Add(btnBanHang);
            Controls.Add(btnVoucher);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnKhachHang);
            Controls.Add(btnNhanVien);
            Controls.Add(btnSanPham);
            Controls.Add(btnTrangChu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachKhachHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTrangChu;
        private Button btnSanPham;
        private Button btnNhanVien;
        private Button btnKhachHang;
        private Button btnLogout;
        private Label label1;
        private DataGridView dgvDanhSachKhachHang;
        private Panel panel1;
        private Button btnSua;
        private Button btnLoc;
        private Button btnLuu;
        private Label label7;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTenKhachHang;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnExit;
        private Label label8;
        private Panel panel3;
        private Button btnVoucher;
        private Button btnBanHang;
        private TextBox txtEmail;
        private Label label9;
        private TextBox textBox4;
        private Label label6;
        private TextBox txtDiem;
        private Label label10;
    }
}