namespace ReadQRCode_Realtime
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pic_cam = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_url_DroidCam = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cam)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_cam
            // 
            this.pic_cam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_cam.Location = new System.Drawing.Point(12, 50);
            this.pic_cam.Name = "pic_cam";
            this.pic_cam.Size = new System.Drawing.Size(963, 615);
            this.pic_cam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cam.TabIndex = 0;
            this.pic_cam.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL: ";
            // 
            // txt_url_DroidCam
            // 
            this.txt_url_DroidCam.Location = new System.Drawing.Point(53, 6);
            this.txt_url_DroidCam.Name = "txt_url_DroidCam";
            this.txt_url_DroidCam.Size = new System.Drawing.Size(319, 20);
            this.txt_url_DroidCam.TabIndex = 2;
            this.txt_url_DroidCam.Text = "http://192.168.1.196:4747/video";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(378, 3);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(981, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 615);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Camera from Droid Cam Tablet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(978, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result Decode QRcode";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.txt_url_DroidCam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_cam);
            this.Name = "Form1";
            this.Text = "Read QR code Real time";
            ((System.ComponentModel.ISupportInitialize)(this.pic_cam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_cam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_url_DroidCam;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

