namespace APPBanHang
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            panel4 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            txtEmail = new TextBox();
            label10 = new Label();
            cbxTrangThai = new ComboBox();
            label9 = new Label();
            btnSua = new Button();
            btnLoc = new Button();
            btnLuu = new Button();
            label7 = new Label();
            dtpNgaySinh = new DateTimePicker();
            txtMatKhau = new TextBox();
            txtSoDienThoai = new TextBox();
            txtDiaChi = new TextBox();
            txtTen = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnTrangChu = new Button();
            btnSanPham = new Button();
            btnNhanVien = new Button();
            btnKhachHang = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            btn1 = new Button();
            label8 = new Label();
            panel3 = new Panel();
            btnVoucher = new Button();
            btnBanHang = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(panel1);
            panel4.Location = new Point(205, 53);
            panel4.Name = "panel4";
            panel4.Size = new Size(941, 521);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(259, 249);
            label1.Name = "label1";
            label1.Size = new Size(300, 29);
            label1.TabIndex = 2;
            label1.Text = "Danh Sách Nhân Viên";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 289);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(935, 217);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbxTrangThai);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnLoc);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dtpNgaySinh);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtSoDienThoai);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 240);
            panel1.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(28, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 23);
            txtEmail.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(28, 111);
            label10.Name = "label10";
            label10.Size = new Size(47, 16);
            label10.TabIndex = 16;
            label10.Text = "Email";
            // 
            // cbxTrangThai
            // 
            cbxTrangThai.FormattingEnabled = true;
            cbxTrangThai.Location = new Point(636, 130);
            cbxTrangThai.Name = "cbxTrangThai";
            cbxTrangThai.Size = new Size(121, 23);
            cbxTrangThai.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(636, 111);
            label9.Name = "label9";
            label9.Size = new Size(82, 16);
            label9.TabIndex = 14;
            label9.Text = "Trạng Thái";
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(615, 190);
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
            btnLoc.Location = new Point(731, 190);
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
            btnLuu.Location = new Point(497, 190);
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
            label7.Location = new Point(636, 59);
            label7.Name = "label7";
            label7.Size = new Size(79, 16);
            label7.TabIndex = 10;
            label7.Text = "Ngày Sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(631, 80);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 23);
            dtpNgaySinh.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(474, 130);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(151, 23);
            txtMatKhau.TabIndex = 8;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Location = new Point(474, 80);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(151, 23);
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
            // txtTen
            // 
            txtTen.Location = new Point(28, 83);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(191, 23);
            txtTen.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(474, 109);
            label6.Name = "label6";
            label6.Size = new Size(74, 16);
            label6.TabIndex = 4;
            label6.Text = "Mật Khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(471, 60);
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
            label3.Location = new Point(28, 64);
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
            label2.Size = new Size(207, 25);
            label2.TabIndex = 0;
            label2.Text = "Thông Tin Nhân Viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 172);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Location = new Point(0, 192);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(205, 31);
            btnTrangChu.TabIndex = 4;
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
            btnSanPham.TabIndex = 5;
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
            btnNhanVien.TabIndex = 6;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Location = new Point(0, 303);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(205, 31);
            btnKhachHang.TabIndex = 7;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += button4_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(0, 530);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(205, 31);
            btnExit.TabIndex = 9;
            btnExit.Text = "Đăng Xuất";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btn1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(205, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 53);
            panel2.TabIndex = 10;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.Location = new Point(898, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(40, 30);
            btn1.TabIndex = 4;
            btn1.Text = "X";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
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
            btnBanHang.TabIndex = 74;
            btnBanHang.Text = "Bán Hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += button_Click_BanHang;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 573);
            Controls.Add(btnBanHang);
            Controls.Add(btnVoucher);
            Controls.Add(panel2);
            Controls.Add(btnExit);
            Controls.Add(btnKhachHang);
            Controls.Add(btnNhanVien);
            Controls.Add(btnSanPham);
            Controls.Add(btnTrangChu);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhanVien";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private PictureBox pictureBox1;
        private Button btnTrangChu;
        private Button btnSanPham;
        private Button btnNhanVien;
        private Button btnKhachHang;
        private Button btnExit;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox txtMatKhau;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTen;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpNgaySinh;
        private Button btnSua;
        private Button btnLoc;
        private Button btnLuu;
        private Label label7;
        private Panel panel2;
        private Button btn1;
        private Label label8;
        private Panel panel3;
        private Button btnVoucher;
        private Button btnBanHang;
        private ComboBox cbxTrangThai;
        private Label label9;
        private TextBox txtEmail;
        private Label label10;
    }
}