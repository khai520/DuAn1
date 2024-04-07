namespace MainApp.GUI.VIEW
{
    partial class ChiTietSanPham
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbx_Ms = new ComboBox();
            cbx_cl = new ComboBox();
            txt_Gb = new TextBox();
            cbx_Kc = new ComboBox();
            btnLuu = new Button();
            btnDong = new Button();
            label1 = new Label();
            txt_Ten = new TextBox();
            panel2 = new Panel();
            label6 = new Label();
            button13 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 94);
            label2.Name = "label2";
            label2.Size = new Size(56, 14);
            label2.TabIndex = 1;
            label2.Text = "Kích Cỡ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 155);
            label3.Name = "label3";
            label3.Size = new Size(62, 14);
            label3.TabIndex = 2;
            label3.Text = "Màu Sắc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 126);
            label4.Name = "label4";
            label4.Size = new Size(69, 14);
            label4.TabIndex = 3;
            label4.Text = "Chất Liệu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 195);
            label5.Name = "label5";
            label5.Size = new Size(58, 14);
            label5.TabIndex = 5;
            label5.Text = "Giá Bán";
            // 
            // cbx_Ms
            // 
            cbx_Ms.FormattingEnabled = true;
            cbx_Ms.Location = new Point(110, 152);
            cbx_Ms.Name = "cbx_Ms";
            cbx_Ms.Size = new Size(152, 23);
            cbx_Ms.TabIndex = 7;
            // 
            // cbx_cl
            // 
            cbx_cl.FormattingEnabled = true;
            cbx_cl.Location = new Point(108, 123);
            cbx_cl.Name = "cbx_cl";
            cbx_cl.Size = new Size(154, 23);
            cbx_cl.TabIndex = 8;
            cbx_cl.SelectedIndexChanged += cbx_cl_SelectedIndexChanged;
            // 
            // txt_Gb
            // 
            txt_Gb.BorderStyle = BorderStyle.FixedSingle;
            txt_Gb.Location = new Point(109, 192);
            txt_Gb.Name = "txt_Gb";
            txt_Gb.Size = new Size(153, 23);
            txt_Gb.TabIndex = 9;
            // 
            // cbx_Kc
            // 
            cbx_Kc.FormattingEnabled = true;
            cbx_Kc.Location = new Point(108, 94);
            cbx_Kc.Name = "cbx_Kc";
            cbx_Kc.Size = new Size(154, 23);
            cbx_Kc.TabIndex = 10;
            // 
            // btnLuu
            // 
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.Location = new Point(52, 295);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(95, 42);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnDong
            // 
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDong.Location = new Point(358, 295);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(95, 42);
            btnDong.TabIndex = 15;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 65);
            label1.Name = "label1";
            label1.Size = new Size(63, 14);
            label1.TabIndex = 16;
            label1.Text = "Tên giày";
            // 
            // txt_Ten
            // 
            txt_Ten.BorderStyle = BorderStyle.FixedSingle;
            txt_Ten.Location = new Point(108, 59);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(154, 23);
            txt_Ten.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aquamarine;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(877, 38);
            panel2.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(155, 7);
            label6.Name = "label6";
            label6.Size = new Size(225, 25);
            label6.TabIndex = 0;
            label6.Text = "Chi Tiết Sản Phẩm";
            // 
            // button13
            // 
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(164, 295);
            button13.Name = "button13";
            button13.Size = new Size(168, 42);
            button13.TabIndex = 33;
            button13.Text = "Thêm Nhà Cung Cấp";
            button13.UseVisualStyleBackColor = true;
            // 
            // ChiTietSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 410);
            Controls.Add(button13);
            Controls.Add(panel2);
            Controls.Add(txt_Ten);
            Controls.Add(label1);
            Controls.Add(btnDong);
            Controls.Add(btnLuu);
            Controls.Add(cbx_Kc);
            Controls.Add(txt_Gb);
            Controls.Add(cbx_cl);
            Controls.Add(cbx_Ms);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChiTietSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tên giày";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbx_Ms;
        private ComboBox cbx_cl;
        private TextBox txt_Gb;
        private ComboBox cbx_Kc;
        private Button btnLuu;
        private Button btnDong;
        private Label label1;
        private TextBox txt_Ten;
        private Panel panel2;
        private Label label6;
        private Button button13;
    }
}