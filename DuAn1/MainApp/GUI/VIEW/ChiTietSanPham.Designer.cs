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
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 102);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Kích Cỡ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 144);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Màu Sắc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 188);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Chất Liệu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 222);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 5;
            label5.Text = "Giá Bán";
            // 
            // cbx_Ms
            // 
            cbx_Ms.FormattingEnabled = true;
            cbx_Ms.Location = new Point(139, 141);
            cbx_Ms.Margin = new Padding(3, 4, 3, 4);
            cbx_Ms.Name = "cbx_Ms";
            cbx_Ms.Size = new Size(335, 28);
            cbx_Ms.TabIndex = 7;
            // 
            // cbx_cl
            // 
            cbx_cl.FormattingEnabled = true;
            cbx_cl.Location = new Point(139, 180);
            cbx_cl.Margin = new Padding(3, 4, 3, 4);
            cbx_cl.Name = "cbx_cl";
            cbx_cl.Size = new Size(335, 28);
            cbx_cl.TabIndex = 8;
            // 
            // txt_Gb
            // 
            txt_Gb.Location = new Point(139, 219);
            txt_Gb.Margin = new Padding(3, 4, 3, 4);
            txt_Gb.Name = "txt_Gb";
            txt_Gb.Size = new Size(334, 27);
            txt_Gb.TabIndex = 9;
            // 
            // cbx_Kc
            // 
            cbx_Kc.FormattingEnabled = true;
            cbx_Kc.Location = new Point(139, 99);
            cbx_Kc.Margin = new Padding(3, 4, 3, 4);
            cbx_Kc.Name = "cbx_Kc";
            cbx_Kc.Size = new Size(335, 28);
            cbx_Kc.TabIndex = 10;
            // 
            // btnLuu
            // 
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Location = new Point(139, 296);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(109, 56);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnDong
            // 
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Location = new Point(321, 296);
            btnDong.Margin = new Padding(3, 4, 3, 4);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(109, 56);
            btnDong.TabIndex = 15;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 52);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 16;
            label1.Text = "Tên giày";
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(139, 48);
            txt_Ten.Margin = new Padding(3, 4, 3, 4);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(335, 27);
            txt_Ten.TabIndex = 17;
            // 
            // ChiTietSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 368);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChiTietSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tên giày";
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
    }
}