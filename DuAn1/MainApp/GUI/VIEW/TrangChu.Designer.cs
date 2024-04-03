namespace APPBanHang
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            panel2 = new Panel();
            btn1 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            btnTrangChu = new Button();
            btnSanPham = new Button();
            btnNhanVien = new Button();
            btnKhachHang = new Button();
            btnExit = new Button();
            btnVoucher = new Button();
            btnBanHang = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 149);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 175);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(203, 146);
            panel5.Name = "panel5";
            panel5.Size = new Size(941, 451);
            panel5.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btn1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(203, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 53);
            panel2.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.Location = new Point(901, 0);
            btn1.Name = "btn1";
            btn1.Size = new Size(40, 30);
            btn1.TabIndex = 4;
            btn1.Text = "X";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(286, 8);
            label1.Name = "label1";
            label1.Size = new Size(182, 29);
            label1.TabIndex = 3;
            label1.Text = "Snaker Shop";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(597, 100);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DeepSkyBlue;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(203, 53);
            panel4.Name = "panel4";
            panel4.Size = new Size(941, 97);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 57);
            label3.Name = "label3";
            label3.Size = new Size(62, 18);
            label3.TabIndex = 1;
            label3.Text = "Quyền :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 21);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 0;
            label2.Text = "Xin Chào :";
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Location = new Point(0, 192);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(205, 31);
            btnTrangChu.TabIndex = 1;
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
            btnSanPham.TabIndex = 7;
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
            btnNhanVien.TabIndex = 8;
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
            btnKhachHang.TabIndex = 9;
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
            btnExit.TabIndex = 11;
            btnExit.Text = " Đăng Xuất";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button6_Click;
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
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 573);
            Controls.Add(btnBanHang);
            Controls.Add(btnVoucher);
            Controls.Add(btnExit);
            Controls.Add(btnKhachHang);
            Controls.Add(btnNhanVien);
            Controls.Add(btnSanPham);
            Controls.Add(btnTrangChu);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChu";
            Load += TrangChu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btn1;
        private Panel panel5;
        private Button btnTrangChu;
        private Button btnSanPham;
        private Button btnNhanVien;
        private Button btnKhachHang;
        private Button btnExit;
        private Button btnVoucher;
        private Button btnBanHang;
    }
}