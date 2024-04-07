namespace APPBanHang
{
    partial class BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            btnKhachHang = new Button();
            btnSanPham = new Button();
            btnTrangChu = new Button();
            btnExit = new Button();
            btnNhanVien = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            label11 = new Label();
            btnVoucher = new Button();
            btnLogout = new Button();
            btnBanHang = new Button();
            groupBox1 = new GroupBox();
            dgvDanhSachHoaDon = new DataGridView();
            panel4 = new Panel();
            btnQRCode = new Button();
            btnTimSanPham = new Button();
            txtTimSanPham = new TextBox();
            dgvDanhSachSanPham = new DataGridView();
            panel5 = new Panel();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            dgvHoaDonChiTiet = new DataGridView();
            panel6 = new Panel();
            btnLuu = new Button();
            txtSoDienThoai = new TextBox();
            txtTenKhachHang = new TextBox();
            label4 = new Label();
            panel7 = new Panel();
            label3 = new Label();
            panel8 = new Panel();
            label17 = new Label();
            txtTraLai = new TextBox();
            label15 = new Label();
            label5 = new Label();
            txtKhachDua = new TextBox();
            panel9 = new Panel();
            label6 = new Label();
            label14 = new Label();
            label16 = new Label();
            btnLuuHoaDon = new Button();
            btnTaoHoaDon = new Button();
            btnThanhToan = new Button();
            txtGhiChu = new TextBox();
            txtThanhToan = new TextBox();
            txtCoupon = new TextBox();
            label8 = new Label();
            txtTongTien = new TextBox();
            label7 = new Label();
            label13 = new Label();
            label9 = new Label();
            label10 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHoaDon).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).BeginInit();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonChiTiet).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnKhachHang
            // 
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Location = new Point(-18, 303);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(205, 31);
            btnKhachHang.TabIndex = 65;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Location = new Point(-18, 229);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(205, 31);
            btnSanPham.TabIndex = 63;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Location = new Point(-19, 192);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(205, 31);
            btnTrangChu.TabIndex = 62;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Location = new Point(1690, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 30);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnexit_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(-18, 266);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(205, 31);
            btnNhanVien.TabIndex = 64;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(597, 100);
            panel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 67);
            panel1.TabIndex = 74;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(190, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1739, 53);
            panel2.TabIndex = 61;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(329, 8);
            label11.Name = "label11";
            label11.Size = new Size(182, 29);
            label11.TabIndex = 3;
            label11.Text = "Snaker Shop";
            // 
            // btnVoucher
            // 
            btnVoucher.FlatStyle = FlatStyle.Flat;
            btnVoucher.Location = new Point(-18, 340);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(205, 31);
            btnVoucher.TabIndex = 71;
            btnVoucher.Text = "Voucher";
            btnVoucher.UseVisualStyleBackColor = true;
            btnVoucher.Click += btnVoucher_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(-18, 530);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(205, 31);
            btnLogout.TabIndex = 67;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Location = new Point(-18, 377);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(205, 31);
            btnBanHang.TabIndex = 72;
            btnBanHang.Text = "Bán Hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachHoaDon);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(190, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(956, 208);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvDanhSachHoaDon
            // 
            dgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachHoaDon.Location = new Point(3, 22);
            dgvDanhSachHoaDon.Name = "dgvDanhSachHoaDon";
            dgvDanhSachHoaDon.RowHeadersWidth = 51;
            dgvDanhSachHoaDon.RowTemplate.Height = 25;
            dgvDanhSachHoaDon.Size = new Size(953, 180);
            dgvDanhSachHoaDon.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnQRCode);
            panel4.Controls.Add(btnTimSanPham);
            panel4.Controls.Add(txtTimSanPham);
            panel4.Controls.Add(dgvDanhSachSanPham);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(193, 356);
            panel4.Name = "panel4";
            panel4.Size = new Size(959, 299);
            panel4.TabIndex = 74;
            // 
            // btnQRCode
            // 
            btnQRCode.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQRCode.Location = new Point(787, 38);
            btnQRCode.Name = "btnQRCode";
            btnQRCode.Size = new Size(150, 23);
            btnQRCode.TabIndex = 4;
            btnQRCode.Text = "Quét Mã";
            btnQRCode.UseVisualStyleBackColor = true;
            btnQRCode.Click += btnQRCode_Click;
            // 
            // btnTimSanPham
            // 
            btnTimSanPham.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimSanPham.Location = new Point(479, 41);
            btnTimSanPham.Name = "btnTimSanPham";
            btnTimSanPham.Size = new Size(150, 23);
            btnTimSanPham.TabIndex = 3;
            btnTimSanPham.Text = "Tìm Sản Phẩm";
            btnTimSanPham.UseVisualStyleBackColor = true;
            btnTimSanPham.Click += btnTimSanPham_Click;
            // 
            // txtTimSanPham
            // 
            txtTimSanPham.BorderStyle = BorderStyle.FixedSingle;
            txtTimSanPham.Location = new Point(185, 40);
            txtTimSanPham.Name = "txtTimSanPham";
            txtTimSanPham.Size = new Size(288, 23);
            txtTimSanPham.TabIndex = 2;
            // 
            // dgvDanhSachSanPham
            // 
            dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSanPham.Location = new Point(3, 69);
            dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            dgvDanhSachSanPham.RowHeadersWidth = 51;
            dgvDanhSachSanPham.RowTemplate.Height = 25;
            dgvDanhSachSanPham.Size = new Size(950, 227);
            dgvDanhSachSanPham.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Aquamarine;
            panel5.Controls.Add(label1);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(956, 34);
            panel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(297, 5);
            label1.Name = "label1";
            label1.Size = new Size(297, 29);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Sản Phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(dgvHoaDonChiTiet);
            groupBox2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(190, 661);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(962, 215);
            groupBox2.TabIndex = 76;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa Đơn Chi Tiết";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(884, 18);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // dgvHoaDonChiTiet
            // 
            dgvHoaDonChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonChiTiet.Location = new Point(0, 47);
            dgvHoaDonChiTiet.Name = "dgvHoaDonChiTiet";
            dgvHoaDonChiTiet.RowHeadersWidth = 51;
            dgvHoaDonChiTiet.RowTemplate.Height = 25;
            dgvHoaDonChiTiet.Size = new Size(956, 162);
            dgvHoaDonChiTiet.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnLuu);
            panel6.Controls.Add(txtSoDienThoai);
            panel6.Controls.Add(txtTenKhachHang);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(1152, 147);
            panel6.Name = "panel6";
            panel6.Size = new Size(373, 112);
            panel6.TabIndex = 77;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(288, 79);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Location = new Point(66, 74);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(162, 23);
            txtSoDienThoai.TabIndex = 5;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtTenKhachHang.Location = new Point(63, 38);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(166, 23);
            txtTenKhachHang.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 41);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 2;
            label4.Text = "Tên KH";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Aquamarine;
            panel7.Controls.Add(label3);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(366, 30);
            panel7.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(107, 8);
            label3.Name = "label3";
            label3.Size = new Size(147, 14);
            label3.TabIndex = 0;
            label3.Text = "Thông tin khách hàng";
            // 
            // panel8
            // 
            panel8.Controls.Add(label17);
            panel8.Controls.Add(txtTraLai);
            panel8.Controls.Add(label15);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(txtKhachDua);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(label16);
            panel8.Controls.Add(btnLuuHoaDon);
            panel8.Controls.Add(btnTaoHoaDon);
            panel8.Controls.Add(btnThanhToan);
            panel8.Controls.Add(txtGhiChu);
            panel8.Controls.Add(txtThanhToan);
            panel8.Controls.Add(txtCoupon);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(txtTongTien);
            panel8.Controls.Add(label7);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label10);
            panel8.Location = new Point(1155, 361);
            panel8.Name = "panel8";
            panel8.Size = new Size(370, 352);
            panel8.TabIndex = 78;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(273, 166);
            label17.Name = "label17";
            label17.Size = new Size(31, 15);
            label17.TabIndex = 22;
            label17.Text = "VNĐ";
            // 
            // txtTraLai
            // 
            txtTraLai.Location = new Point(111, 158);
            txtTraLai.Name = "txtTraLai";
            txtTraLai.Size = new Size(147, 23);
            txtTraLai.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 161);
            label15.Name = "label15";
            label15.Size = new Size(46, 15);
            label15.TabIndex = 20;
            label15.Text = "Trả Lại :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 137);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 19;
            label5.Text = "VNĐ";
            // 
            // txtKhachDua
            // 
            txtKhachDua.Location = new Point(111, 129);
            txtKhachDua.Name = "txtKhachDua";
            txtKhachDua.Size = new Size(147, 23);
            txtKhachDua.TabIndex = 18;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Aquamarine;
            panel9.Controls.Add(label6);
            panel9.Location = new Point(0, 1);
            panel9.Name = "panel9";
            panel9.Size = new Size(370, 37);
            panel9.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(119, 11);
            label6.Name = "label6";
            label6.Size = new Size(131, 14);
            label6.TabIndex = 0;
            label6.Text = "Thông Tin Hóa Đơn";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 137);
            label14.Name = "label14";
            label14.Size = new Size(70, 15);
            label14.TabIndex = 17;
            label14.Text = "Khách Đưa :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(273, 109);
            label16.Name = "label16";
            label16.Size = new Size(31, 15);
            label16.TabIndex = 16;
            label16.Text = "VNĐ";
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuuHoaDon.Location = new Point(133, 319);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(114, 30);
            btnLuuHoaDon.TabIndex = 15;
            btnLuuHoaDon.Text = "Lưu Hóa Đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoHoaDon.Location = new Point(5, 319);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Size = new Size(114, 30);
            btnTaoHoaDon.TabIndex = 14;
            btnTaoHoaDon.Text = "Tạo Hóa Đơn";
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.Location = new Point(256, 319);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(114, 30);
            btnThanhToan.TabIndex = 13;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // txtGhiChu
            // 
            txtGhiChu.BorderStyle = BorderStyle.FixedSingle;
            txtGhiChu.Location = new Point(3, 200);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(363, 113);
            txtGhiChu.TabIndex = 10;
            // 
            // txtThanhToan
            // 
            txtThanhToan.Location = new Point(111, 101);
            txtThanhToan.Name = "txtThanhToan";
            txtThanhToan.Size = new Size(147, 23);
            txtThanhToan.TabIndex = 7;
            // 
            // txtCoupon
            // 
            txtCoupon.Location = new Point(111, 72);
            txtCoupon.Name = "txtCoupon";
            txtCoupon.Size = new Size(147, 23);
            txtCoupon.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(273, 48);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 3;
            label8.Text = "VNĐ";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(111, 44);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(147, 23);
            txtTongTien.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 51);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 1;
            label7.Text = "Tổng Tiền :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 182);
            label13.Name = "label13";
            label13.Size = new Size(56, 15);
            label13.TabIndex = 9;
            label13.Text = "Ghi Chú :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 80);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 4;
            label9.Text = "Coupon : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 109);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 6;
            label10.Text = "Thanh Toán :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(519, 58);
            label2.Name = "label2";
            label2.Size = new Size(160, 32);
            label2.TabIndex = 113;
            label2.Text = "Bán Hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 175);
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label2);
            Controls.Add(panel6);
            Controls.Add(panel8);
            Controls.Add(groupBox2);
            Controls.Add(panel4);
            Controls.Add(groupBox1);
            Controls.Add(btnBanHang);
            Controls.Add(btnKhachHang);
            Controls.Add(btnSanPham);
            Controls.Add(btnTrangChu);
            Controls.Add(btnNhanVien);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(btnVoucher);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Load += BanHang_Load_1;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHoaDon).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonChiTiet).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKhachHang;
        private Button btnSanPham;
        private Button btnTrangChu;
        private Button btnExit;
        private Button btnNhanVien;
        private Panel panel3;
        private Panel panel2;
        private Label label11;
        private Button btnVoucher;
        private Button btnLogout;
        private Button btnBanHang;
        private Panel panel1;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachHoaDon;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private TextBox txtTimSanPham;
        private DataGridView dgvDanhSachSanPham;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnXoa;
        private DataGridView dgvHoaDonChiTiet;
        private Panel panel6;
        private Label label5;
        private Label label4;
        private Button button9;
        private Panel panel7;
        private Label label3;
        private TextBox txtSoDienThoai;
        private TextBox txtTenKhachHang;
        private Panel panel8;
        private Label label8;
        private TextBox txtTongTien;
        private Label label7;
        private Panel panel9;
        private Label label6;
        private Button button12;
        private Button button10;
        private TextBox txtGhiChu;
        private Label label13;
        private TextBox txtThanhToan;
        private Label label10;
        private TextBox txtCoupon;
        private Label label9;
        private Button btnThanhToan;
        private Button btnLuuHoaDon;
        private Button btnTaoHoaDon;
        private Button btnLuu;
        private Label label16;
        private TextBox txtKhachDua;
        private Label label14;
        private Label label17;
        private TextBox txtTraLai;
        private Label label15;
        private Button btnTimSanPham;
        private PictureBox pictureBox1;
        private Button btnQRCode;
    }
}