namespace APPBanHang
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            txt_tendn = new TextBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            txt_mk = new TextBox();
            btn_dn = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnexit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 601);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(99, 421);
            label2.Name = "label2";
            label2.Size = new Size(91, 18);
            label2.TabIndex = 2;
            label2.Text = "Since 2024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 376);
            label1.Name = "label1";
            label1.Size = new Size(181, 31);
            label1.TabIndex = 1;
            label1.Text = "Snaker Shop";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 59);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 267);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btn_dn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnexit);
            panel2.Location = new Point(315, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 601);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txt_tendn);
            panel3.Location = new Point(49, 280);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 53);
            panel3.TabIndex = 8;
            // 
            // txt_tendn
            // 
            txt_tendn.BorderStyle = BorderStyle.None;
            txt_tendn.Location = new Point(3, 12);
            txt_tendn.Margin = new Padding(3, 4, 3, 4);
            txt_tendn.Name = "txt_tendn";
            txt_tendn.Size = new Size(325, 20);
            txt_tendn.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(txt_mk);
            panel4.Location = new Point(49, 376);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 53);
            panel4.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(352, 1);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 48);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            pictureBox2.MouseUp += pictureBox2_MouseUp;
            // 
            // txt_mk
            // 
            txt_mk.BorderStyle = BorderStyle.None;
            txt_mk.Location = new Point(3, 12);
            txt_mk.Margin = new Padding(3, 4, 3, 4);
            txt_mk.Name = "txt_mk";
            txt_mk.Size = new Size(325, 20);
            txt_mk.TabIndex = 0;
            txt_mk.UseSystemPasswordChar = true;
            // 
            // btn_dn
            // 
            btn_dn.BackColor = Color.White;
            btn_dn.Cursor = Cursors.Hand;
            btn_dn.FlatStyle = FlatStyle.Flat;
            btn_dn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dn.Location = new Point(50, 463);
            btn_dn.Margin = new Padding(3, 4, 3, 4);
            btn_dn.Name = "btn_dn";
            btn_dn.Size = new Size(175, 45);
            btn_dn.TabIndex = 9;
            btn_dn.Text = "Đăng Nhập";
            btn_dn.UseVisualStyleBackColor = false;
            btn_dn.Click += button2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(46, 353);
            label5.Name = "label5";
            label5.Size = new Size(89, 18);
            label5.TabIndex = 5;
            label5.Text = "Mật Khẩu :";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(46, 249);
            label4.Name = "label4";
            label4.Size = new Size(134, 18);
            label4.TabIndex = 4;
            label4.Text = "Tên Đăng Nhập :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(205, 155);
            label3.Name = "label3";
            label3.Size = new Size(160, 31);
            label3.TabIndex = 3;
            label3.Text = "Đăng Nhập";
            label3.Click += label3_Click;
            // 
            // btnexit
            // 
            btnexit.Cursor = Cursors.Hand;
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.Location = new Point(542, 1);
            btnexit.Margin = new Padding(3, 4, 3, 4);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(54, 53);
            btnexit.TabIndex = 3;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button btnexit;
        private Label label3;
        private Label label5;
        private Label label4;
        private Panel panel4;
        private Button btn_dn;
        private TextBox txt_mk;
        private Panel panel3;
        private TextBox txt_tendn;
        private PictureBox pictureBox2;
    }
}