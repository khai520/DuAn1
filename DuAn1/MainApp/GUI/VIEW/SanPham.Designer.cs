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
            components = new System.ComponentModel.Container();
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
            button1 = new Button();
            label1 = new Label();
            txtGiaBan = new TextBox();
            dgvDanhSachSanPham = new DataGridView();
            label6 = new Label();
            btnThemSanPham = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtTenSP = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tab2 = new TabPage();
            panel4 = new Panel();
            label9 = new Label();
            txt_Sl = new TextBox();
            btn_Clear = new Button();
            cbx_Kichthuoc = new ComboBox();
            cbx_Mau = new ComboBox();
            cbx_Ncc = new ComboBox();
            label4 = new Label();
            dgv_tab2 = new DataGridView();
            label7 = new Label();
            btn_Them = new Button();
            cbx_DeGiay = new ComboBox();
            label8 = new Label();
            cbx_Chatlieu = new ComboBox();
            label10 = new Label();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            bindingSource1 = new BindingSource(components);
            btn_tk = new Button();
            btn_TimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tab1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSanPham).BeginInit();
            tab2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_tab2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Location = new Point(5, 192);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(193, 31);
            btnTrangChu.TabIndex = 15;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 172);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnSanPham
            // 
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Location = new Point(5, 229);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(193, 31);
            btnSanPham.TabIndex = 23;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(5, 266);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(193, 31);
            btnNhanVien.TabIndex = 24;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Location = new Point(5, 303);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(193, 31);
            btnKhachHang.TabIndex = 25;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(5, 530);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(193, 31);
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
            panel2.Location = new Point(204, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(942, 46);
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
            btnVoucher.Location = new Point(5, 340);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(193, 31);
            btnVoucher.TabIndex = 60;
            btnVoucher.Text = "Voucher";
            btnVoucher.UseVisualStyleBackColor = true;
            btnVoucher.Click += button_Click_Voucher;
            // 
            // btnBanHang
            // 
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Location = new Point(5, 377);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(193, 31);
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
            panel1.Controls.Add(btn_tk);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtGiaBan);
            panel1.Controls.Add(dgvDanhSachSanPham);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnThemSanPham);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(txtTenSP);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(8, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 468);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(707, 161);
            button1.Name = "button1";
            button1.Size = new Size(168, 42);
            button1.TabIndex = 39;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
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
            txtGiaBan.Location = new Point(218, 82);
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
            label6.Location = new Point(218, 59);
            label6.Name = "label6";
            label6.Size = new Size(62, 16);
            label6.TabIndex = 33;
            label6.Text = "Giá Bán";
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.FlatStyle = FlatStyle.Flat;
            btnThemSanPham.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemSanPham.Location = new Point(185, 161);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(168, 42);
            btnThemSanPham.TabIndex = 32;
            btnThemSanPham.Text = "Thêm Sản Phẩm";
            btnThemSanPham.UseVisualStyleBackColor = true;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(359, 161);
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
            btnXoa.Location = new Point(533, 161);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(168, 42);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTenSP
            // 
            txtTenSP.BorderStyle = BorderStyle.FixedSingle;
            txtTenSP.Location = new Point(28, 83);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(168, 23);
            txtTenSP.TabIndex = 5;
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
            tab2.Controls.Add(panel4);
            tab2.Location = new Point(4, 24);
            tab2.Name = "tab2";
            tab2.Padding = new Padding(3);
            tab2.Size = new Size(906, 482);
            tab2.TabIndex = 1;
            tab2.Text = "Chi tiết sản phẩm";
            tab2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btn_TimKiem);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(txt_Sl);
            panel4.Controls.Add(btn_Clear);
            panel4.Controls.Add(cbx_Kichthuoc);
            panel4.Controls.Add(cbx_Mau);
            panel4.Controls.Add(cbx_Ncc);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(dgv_tab2);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(btn_Them);
            panel4.Controls.Add(cbx_DeGiay);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(cbx_Chatlieu);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(btn_Sua);
            panel4.Controls.Add(btn_Xoa);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label15);
            panel4.Location = new Point(8, 7);
            panel4.Name = "panel4";
            panel4.Size = new Size(890, 468);
            panel4.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(24, 125);
            label9.Name = "label9";
            label9.Size = new Size(70, 16);
            label9.TabIndex = 40;
            label9.Text = "Số lượng";
            // 
            // txt_Sl
            // 
            txt_Sl.BorderStyle = BorderStyle.FixedSingle;
            txt_Sl.Location = new Point(100, 123);
            txt_Sl.Name = "txt_Sl";
            txt_Sl.Size = new Size(110, 23);
            txt_Sl.TabIndex = 39;
            // 
            // btn_Clear
            // 
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Clear.Location = new Point(708, 162);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(168, 42);
            btn_Clear.TabIndex = 38;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // cbx_Kichthuoc
            // 
            cbx_Kichthuoc.FormattingEnabled = true;
            cbx_Kichthuoc.Items.AddRange(new object[] { "" });
            cbx_Kichthuoc.Location = new Point(570, 82);
            cbx_Kichthuoc.Name = "cbx_Kichthuoc";
            cbx_Kichthuoc.Size = new Size(132, 23);
            cbx_Kichthuoc.TabIndex = 37;
            // 
            // cbx_Mau
            // 
            cbx_Mau.FormattingEnabled = true;
            cbx_Mau.Items.AddRange(new object[] { "" });
            cbx_Mau.Location = new Point(217, 83);
            cbx_Mau.Name = "cbx_Mau";
            cbx_Mau.Size = new Size(174, 23);
            cbx_Mau.TabIndex = 36;
            // 
            // cbx_Ncc
            // 
            cbx_Ncc.FormattingEnabled = true;
            cbx_Ncc.Items.AddRange(new object[] { "" });
            cbx_Ncc.Location = new Point(24, 83);
            cbx_Ncc.Name = "cbx_Ncc";
            cbx_Ncc.Size = new Size(186, 23);
            cbx_Ncc.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 214);
            label4.Name = "label4";
            label4.Size = new Size(182, 18);
            label4.TabIndex = 5;
            label4.Text = "Danh Sách Sản Phẩm";
            // 
            // dgv_tab2
            // 
            dgv_tab2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tab2.Location = new Point(3, 235);
            dgv_tab2.Name = "dgv_tab2";
            dgv_tab2.RowHeadersWidth = 51;
            dgv_tab2.RowTemplate.Height = 25;
            dgv_tab2.Size = new Size(884, 230);
            dgv_tab2.TabIndex = 4;
            dgv_tab2.CellClick += dgv_tab2_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(570, 60);
            label7.Name = "label7";
            label7.Size = new Size(83, 16);
            label7.TabIndex = 33;
            label7.Text = "Kích thước";
            // 
            // btn_Them
            // 
            btn_Them.FlatStyle = FlatStyle.Flat;
            btn_Them.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Them.Location = new Point(186, 162);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(168, 42);
            btn_Them.TabIndex = 32;
            btn_Them.Text = "Thêm chi tiết cho sản phẩm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // cbx_DeGiay
            // 
            cbx_DeGiay.FormattingEnabled = true;
            cbx_DeGiay.Items.AddRange(new object[] { "" });
            cbx_DeGiay.Location = new Point(708, 82);
            cbx_DeGiay.Name = "cbx_DeGiay";
            cbx_DeGiay.Size = new Size(121, 23);
            cbx_DeGiay.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(708, 60);
            label8.Name = "label8";
            label8.Size = new Size(62, 16);
            label8.TabIndex = 30;
            label8.Text = "Đế Giày";
            // 
            // cbx_Chatlieu
            // 
            cbx_Chatlieu.FormattingEnabled = true;
            cbx_Chatlieu.Items.AddRange(new object[] { "", "" });
            cbx_Chatlieu.Location = new Point(397, 83);
            cbx_Chatlieu.Name = "cbx_Chatlieu";
            cbx_Chatlieu.Size = new Size(167, 23);
            cbx_Chatlieu.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(397, 59);
            label10.Name = "label10";
            label10.Size = new Size(71, 16);
            label10.TabIndex = 17;
            label10.Text = "Chất liệu";
            // 
            // btn_Sua
            // 
            btn_Sua.FlatStyle = FlatStyle.Flat;
            btn_Sua.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sua.Location = new Point(360, 162);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(168, 42);
            btn_Sua.TabIndex = 13;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.FlatStyle = FlatStyle.Flat;
            btn_Xoa.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Xoa.Location = new Point(534, 162);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(168, 42);
            btn_Xoa.TabIndex = 12;
            btn_Xoa.Text = "Xóa thông tin chi tiết sản phẩm";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(217, 60);
            label13.Name = "label13";
            label13.Size = new Size(37, 16);
            label13.TabIndex = 3;
            label13.Text = "Màu";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(24, 59);
            label14.Name = "label14";
            label14.Size = new Size(104, 16);
            label14.TabIndex = 1;
            label14.Text = "Nhà cung cấp";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(12, 18);
            label15.Name = "label15";
            label15.Size = new Size(177, 25);
            label15.TabIndex = 0;
            label15.Text = "Chi tiết Sản phẩm";
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // btn_tk
            // 
            btn_tk.FlatStyle = FlatStyle.Flat;
            btn_tk.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tk.Location = new Point(707, 110);
            btn_tk.Name = "btn_tk";
            btn_tk.Size = new Size(168, 42);
            btn_tk.TabIndex = 40;
            btn_tk.Text = "Tìm Kiếm";
            btn_tk.UseVisualStyleBackColor = true;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.FlatStyle = FlatStyle.Flat;
            btn_TimKiem.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_TimKiem.Location = new Point(708, 114);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(168, 42);
            btn_TimKiem.TabIndex = 41;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
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
            tab2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_tab2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
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
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtTenSP;
        private Label label3;
        private Label label2;
        public TabControl tab1;
        private BindingSource bindingSource1;
        private Panel panel4;
        private Label label4;
        private TextBox textBox1;
        private DataGridView dgv_tab2;
        private Label label7;
        private Button btn_Them;
        private ComboBox cbx_DeGiay;
        private Label label8;
        private ComboBox cbx_Chatlieu;
        private Label label10;
        private Button btn_Sua;
        private Button btn_Xoa;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox cbx_Kichthuoc;
        private ComboBox cbx_Mau;
        private ComboBox cbx_Ncc;
        private Button btn_Clear;
        private Button button1;
        private Button btnThoat;
        private Label label9;
        private TextBox txt_Sl;
        private Button btn_tk;
        private Button btn_TimKiem;
    }
}