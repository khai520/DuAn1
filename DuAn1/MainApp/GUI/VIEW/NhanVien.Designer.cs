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
            btnLuu = new Button();
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
            btn_xoa = new Button();
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
            panel4.Location = new Point(234, 71);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1075, 695);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(296, 332);
            label1.Name = "label1";
            label1.Size = new Size(373, 36);
            label1.TabIndex = 2;
            label1.Text = "Danh Sách Nhân Viên";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 385);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1069, 289);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_xoa);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbxTrangThai);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnLuu);
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1075, 320);
            panel1.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(32, 180);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 27);
            txtEmail.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(32, 148);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 16;
            label10.Text = "Email";
            // 
            // cbxTrangThai
            // 
            cbxTrangThai.FormattingEnabled = true;
            cbxTrangThai.Items.AddRange(new object[] { "DANG LAM", "NGHI VIEC" });
            cbxTrangThai.Location = new Point(727, 173);
            cbxTrangThai.Margin = new Padding(3, 4, 3, 4);
            cbxTrangThai.Name = "cbxTrangThai";
            cbxTrangThai.Size = new Size(138, 28);
            cbxTrangThai.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(727, 148);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 14;
            label9.Text = "Trạng Thái";
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(703, 253);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 56);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnLuu
            // 
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.Location = new Point(568, 253);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(114, 56);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(542, 173);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(172, 27);
            txtMatKhau.TabIndex = 8;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Location = new Point(542, 107);
            txtSoDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(172, 27);
            txtSoDienThoai.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(266, 111);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(255, 159);
            txtDiaChi.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(32, 111);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(218, 27);
            txtTen.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(542, 145);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 4;
            label6.Text = "Mật Khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(538, 80);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 3;
            label5.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(263, 79);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 2;
            label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 85);
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
            label2.Size = new Size(262, 31);
            label2.TabIndex = 0;
            label2.Text = "Thông Tin Nhân Viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -35);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 229);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Location = new Point(0, 256);
            btnTrangChu.Margin = new Padding(3, 4, 3, 4);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(234, 41);
            btnTrangChu.TabIndex = 4;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += button1_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Location = new Point(0, 305);
            btnSanPham.Margin = new Padding(3, 4, 3, 4);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(234, 41);
            btnSanPham.TabIndex = 5;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += button2_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Location = new Point(0, 355);
            btnNhanVien.Margin = new Padding(3, 4, 3, 4);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(234, 41);
            btnNhanVien.TabIndex = 6;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Location = new Point(0, 404);
            btnKhachHang.Margin = new Padding(3, 4, 3, 4);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(234, 41);
            btnKhachHang.TabIndex = 7;
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
            panel2.Location = new Point(234, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1075, 71);
            panel2.TabIndex = 10;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.Location = new Point(1026, 4);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(46, 40);
            btn1.TabIndex = 4;
            btn1.Text = "X";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(327, 11);
            label8.Name = "label8";
            label8.Size = new Size(226, 36);
            label8.TabIndex = 3;
            label8.Text = "Snaker Shop";
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
            // btn_xoa
            // 
            btn_xoa.FlatStyle = FlatStyle.Flat;
            btn_xoa.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xoa.Location = new Point(848, 253);
            btn_xoa.Margin = new Padding(3, 4, 3, 4);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(114, 56);
            btn_xoa.TabIndex = 18;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 764);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhanVien";
            Load += NhanVien_Load;
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
        private Button btnSua;
        private Button btnLuu;
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
        private Button btn_xoa;
    }
}