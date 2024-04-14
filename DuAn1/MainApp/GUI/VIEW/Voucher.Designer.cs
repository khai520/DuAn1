namespace APPBanHang
{
    partial class Voucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voucher));
            label1 = new Label();
            dgvDanhSachVoucher = new DataGridView();
            label3 = new Label();
            dtp_batdau = new Panel();
            btn_xoa = new Button();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            dtp_hethan = new DateTimePicker();
            label7 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            txtMaVoucher = new TextBox();
            label5 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnLogout = new Button();
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            btnSanPham = new Button();
            btnTrangChu = new Button();
            btnExit = new Button();
            label11 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnVoucher = new Button();
            btnBanHang = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachVoucher).BeginInit();
            dtp_batdau.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(704, 91);
            label1.Name = "label1";
            label1.Size = new Size(181, 23);
            label1.TabIndex = 55;
            label1.Text = "Voucher Đã Thêm";
            // 
            // dgvDanhSachVoucher
            // 
            dgvDanhSachVoucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachVoucher.Location = new Point(695, 124);
            dgvDanhSachVoucher.Margin = new Padding(3, 4, 3, 4);
            dgvDanhSachVoucher.Name = "dgvDanhSachVoucher";
            dgvDanhSachVoucher.RowHeadersWidth = 51;
            dgvDanhSachVoucher.RowTemplate.Height = 25;
            dgvDanhSachVoucher.Size = new Size(614, 643);
            dgvDanhSachVoucher.TabIndex = 54;
            dgvDanhSachVoucher.CellClick += dgvDanhSachVoucher_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(11, 25);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 2;
            label3.Text = "Voucher";
            // 
            // dtp_batdau
            // 
            dtp_batdau.BackColor = Color.White;
            dtp_batdau.Controls.Add(btn_xoa);
            dtp_batdau.Controls.Add(dateTimePicker2);
            dtp_batdau.Controls.Add(label8);
            dtp_batdau.Controls.Add(dtp_hethan);
            dtp_batdau.Controls.Add(label7);
            dtp_batdau.Controls.Add(textBox3);
            dtp_batdau.Controls.Add(label6);
            dtp_batdau.Controls.Add(txtMaVoucher);
            dtp_batdau.Controls.Add(label5);
            dtp_batdau.Controls.Add(btnThem);
            dtp_batdau.Controls.Add(btnSua);
            dtp_batdau.Controls.Add(label3);
            dtp_batdau.Location = new Point(233, 65);
            dtp_batdau.Margin = new Padding(3, 4, 3, 4);
            dtp_batdau.Name = "dtp_batdau";
            dtp_batdau.Size = new Size(464, 702);
            dtp_batdau.TabIndex = 52;
            // 
            // btn_xoa
            // 
            btn_xoa.FlatStyle = FlatStyle.Flat;
            btn_xoa.Location = new Point(342, 328);
            btn_xoa.Margin = new Padding(3, 4, 3, 4);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(86, 31);
            btn_xoa.TabIndex = 28;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(12, 167);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(315, 27);
            dateTimePicker2.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(11, 140);
            label8.Name = "label8";
            label8.Size = new Size(157, 23);
            label8.TabIndex = 25;
            label8.Text = "Ngày Bắt Đầu";
            // 
            // dtp_hethan
            // 
            dtp_hethan.Location = new Point(11, 244);
            dtp_hethan.Margin = new Padding(3, 4, 3, 4);
            dtp_hethan.Name = "dtp_hethan";
            dtp_hethan.Size = new Size(316, 27);
            dtp_hethan.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 212);
            label7.Name = "label7";
            label7.Size = new Size(159, 23);
            label7.TabIndex = 23;
            label7.Text = "Ngày Hết Hạn";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(188, 96);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 27);
            textBox3.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(189, 68);
            label6.Name = "label6";
            label6.Size = new Size(34, 23);
            label6.TabIndex = 20;
            label6.Text = "%";
            // 
            // txtMaVoucher
            // 
            txtMaVoucher.Location = new Point(12, 92);
            txtMaVoucher.Margin = new Padding(3, 4, 3, 4);
            txtMaVoucher.Name = "txtMaVoucher";
            txtMaVoucher.Size = new Size(139, 27);
            txtMaVoucher.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 65);
            label5.Name = "label5";
            label5.Size = new Size(137, 23);
            label5.TabIndex = 18;
            label5.Text = "Mã Voucher";
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Location = new Point(24, 328);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 31);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Location = new Point(188, 328);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 31);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(0, 707);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(234, 41);
            btnLogout.TabIndex = 51;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Location = new Point(-1, 408);
            btnKhachHang.Margin = new Padding(3, 4, 3, 4);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(234, 41);
            btnKhachHang.TabIndex = 49;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += button4_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(-1, 359);
            btnNhanVien.Margin = new Padding(3, 4, 3, 4);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(234, 41);
            btnNhanVien.TabIndex = 48;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += button3_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Location = new Point(-1, 309);
            btnSanPham.Margin = new Padding(3, 4, 3, 4);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(234, 41);
            btnSanPham.TabIndex = 47;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += button2_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Location = new Point(-1, 256);
            btnTrangChu.Margin = new Padding(3, 4, 3, 4);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(234, 41);
            btnTrangChu.TabIndex = 46;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Location = new Point(1037, 0);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(46, 40);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(233, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1075, 68);
            panel2.TabIndex = 45;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -35);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 233);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // btnVoucher
            // 
            btnVoucher.FlatStyle = FlatStyle.Flat;
            btnVoucher.Location = new Point(0, 457);
            btnVoucher.Margin = new Padding(3, 4, 3, 4);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(234, 41);
            btnVoucher.TabIndex = 59;
            btnVoucher.Text = "Voucher";
            btnVoucher.UseVisualStyleBackColor = true;
            btnVoucher.Click += btnVoucher_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Location = new Point(0, 507);
            btnBanHang.Margin = new Padding(3, 4, 3, 4);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(234, 41);
            btnBanHang.TabIndex = 73;
            btnBanHang.Text = "Bán Hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += button_Click_BanHang;
            // 
            // Voucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 764);
            Controls.Add(btnBanHang);
            Controls.Add(btnVoucher);
            Controls.Add(label1);
            Controls.Add(dgvDanhSachVoucher);
            Controls.Add(dtp_batdau);
            Controls.Add(btnLogout);
            Controls.Add(btnKhachHang);
            Controls.Add(btnNhanVien);
            Controls.Add(btnSanPham);
            Controls.Add(btnTrangChu);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Voucher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HoaDon1";
            Load += HoaDon1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachVoucher).EndInit();
            dtp_batdau.ResumeLayout(false);
            dtp_batdau.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvDanhSachVoucher;
        private Label label3;
        private Panel dtp_batdau;
        private Button btnLogout;
        private Button btnKhachHang;
        private Button btnNhanVien;
        private Button btnSanPham;
        private Button btnTrangChu;
        private Button btnExit;
        private Label label11;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnVoucher;
        private Button btnThem;
        private Button btnSua;
        private TextBox textBox3;
        private Label label6;
        private TextBox txtMaVoucher;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private DateTimePicker dtp_hethan;
        private Label label7;
        private Button btnBanHang;
        private Button btn_xoa;
    }
}