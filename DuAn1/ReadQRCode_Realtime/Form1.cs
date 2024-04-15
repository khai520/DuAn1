using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace ReadQRCode_Realtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MJPEGStream stream;

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if(btn_Connect.Text == "Connect")
            {
                stream = new MJPEGStream(txt_url_DroidCam.Text);
                stream.NewFrame += stream_NewFrame;
                stream.Start();
                timer1.Enabled = true;
                timer1.Start();
                btn_Connect.Text = "Disconnect";
            }
            else
            {
                btn_Connect.Text = "Connect";
                timer1.Stop();
                stream.Stop();
                pic_cam.Image = null;
            }
          
        }
        public void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var newFrame = (Bitmap)eventArgs.Frame.Clone();
            this.Invoke(new MethodInvoker(delegate () {
                if (pic_cam.Image != null)
                {
                    pic_cam.Image.Dispose();
                }
                pic_cam.Image = newFrame;
            }));
        }
        
    private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            if (i == 100)
            {
                btn_Connect_Click(sender, e);
            }
            Bitmap img = (Bitmap)pic_cam.Image;
            if (img != null)
            {
                try
                {
                    ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                    Result result = Reader.Decode(img);
                    string decoded = Convert.ToString(result).ToString().Trim();
                    if (!listBox1.Items.Contains(decoded))
                    {
                        listBox1.Items.Insert(0, decoded);
                    }

                    img.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }

            }
        }
    }
}
