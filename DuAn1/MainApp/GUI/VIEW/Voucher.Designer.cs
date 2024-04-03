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
            label4 = new Label();
            label1 = new Label();
            dgvDanhSachVoucher = new DataGridView();
            label3 = new Label();
            panel1 = new Panel();
            cbxTrangThai = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            txtMaVoucher = new TextBox();
            label5 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            label2 = new Label();
            txtSoLuong = new TextBox();
            btnTimKiem = new Button();
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 44);
            label4.Name = "label4";
            label4.Size = new Size(94, 18);
            label4.TabIndex = 3;
            label4.Text = "Trạng Thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(616, 68);
            label1.Name = "label1";
            label1.Size = new Size(141, 18);
            label1.TabIndex = 55;
            label1.Text = "Voucher Đã Thêm";
            // 
            // dgvDanhSachVoucher
            // 
            dgvDanhSachVoucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachVoucher.Location = new Point(608, 93);
            dgvDanhSachVoucher.Name = "dgvDanhSachVoucher";
            dgvDanhSachVoucher.RowTemplate.Height = 25;
            dgvDanhSachVoucher.Size = new Size(537, 482);
            dgvDanhSachVoucher.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 19);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 2;
            label3.Text = "Voucher";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cbxTrangThai);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtMaVoucher);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(204, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 526);
            panel1.TabIndex = 52;
            // 
            // cbxTrangThai
            // 
            cbxTrangThai.FormattingEnabled = true;
            cbxTrangThai.Location = new Point(15, 71);
            cbxTrangThai.Name = "cbxTrangThai";
            cbxTrangThai.Size = new Size(121, 23);
            cbxTrangThai.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(10, 183);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(11, 159);
            label8.Name = "label8";
            label8.Size = new Size(120, 18);
            label8.TabIndex = 25;
            label8.Text = "Ngày Bắt Đầu";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(11, 237);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 213);
            label7.Name = "label7";
            label7.Size = new Size(121, 18);
            label7.TabIndex = 23;
            label7.Text = "Ngày Hết Hạn";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 23);
            textBox3.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(167, 105);
            label6.Name = "label6";
            label6.Size = new Size(27, 18);
            label6.TabIndex = 20;
            label6.Text = "%";
            // 
            // txtMaVoucher
            // 
            txtMaVoucher.Location = new Point(10, 124);
            txtMaVoucher.Name = "txtMaVoucher";
            txtMaVoucher.Size = new Size(122, 23);
            txtMaVoucher.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 103);
            label5.Name = "label5";
            label5.Size = new Size(103, 18);
            label5.TabIndex = 18;
            label5.Text = "Mã Voucher";
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Location = new Point(193, 300);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Location = new Point(103, 300);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(167, 44);
            label2.Name = "label2";
            label2.Size = new Size(85, 18);
            label2.TabIndex = 15;
            label2.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(167, 65);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(122, 23);
            txtSoLuong.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Location = new Point(11, 300);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(0, 530);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(205, 31);
            btnLogout.TabIndex = 51;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Location = new Point(-1, 306);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(205, 31);
            btnKhachHang.TabIndex = 49;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += button4_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(-1, 269);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(205, 31);
            btnNhanVien.TabIndex = 48;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += button3_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Location = new Point(-1, 232);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(205, 31);
            btnSanPham.TabIndex = 47;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += button2_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Location = new Point(-1, 192);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(205, 31);
            btnTrangChu.TabIndex = 46;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Location = new Point(907, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 30);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(204, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 51);
            panel2.TabIndex = 45;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 175);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // btnVoucher
            // 
            btnVoucher.FlatStyle = FlatStyle.Flat;
            btnVoucher.Location = new Point(0, 343);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(205, 31);
            btnVoucher.TabIndex = 59;
            btnVoucher.Text = "Voucher";
            btnVoucher.UseVisualStyleBackColor = true;
            btnVoucher.Click += btnVoucher_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Location = new Point(0, 380);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(205, 31);
            btnBanHang.TabIndex = 73;
            btnBanHang.Text = "Bán Hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += button_Click_BanHang;
            // 
            // Voucher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 573);
            Controls.Add(btnBanHang);
            Controls.Add(btnVoucher);
            Controls.Add(label1);
            Controls.Add(dgvDanhSachVoucher);
            Controls.Add(panel1);
            Controls.Add(btnLogout);
            Controls.Add(btnKhachHang);
            Controls.Add(btnNhanVien);
            Controls.Add(btnSanPham);
            Controls.Add(btnTrangChu);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Voucher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HoaDon1";
            Load += HoaDon1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachVoucher).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label1;
        private DataGridView dgvDanhSachVoucher;
        private Label label3;
        private Panel panel1;
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
        private Button btnTimKiem;
        private Button btnThem;
        private Button btnSua;
        private Label label2;
        private TextBox txtSoLuong;
        private TextBox textBox3;
        private Label label6;
        private TextBox txtMaVoucher;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Button btnBanHang;
        private ComboBox cbxTrangThai;
    }
}