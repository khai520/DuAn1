using Main.BLL.Models2;
using WinFormsApp1.Services;
using Main.DAL.Services;
namespace APPBanHang
{
    public partial class Login : Form
    {
        NguoiDungServices NguoiDungServices = new NguoiDungServices();
        public Login()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txt_mk.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txt_mk.UseSystemPasswordChar = true;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NguoiDung nguoiDung = new();
            if (NguoiDungServices.CheckLogin(txt_tendn.Text, txt_mk.Text))
            {
                nguoiDung = NguoiDungServices.checktkdn(txt_tendn.Text, txt_mk.Text).Find(x => x.Email == txt_tendn.Text && x.MatKhau == txt_mk.Text);
                if (nguoiDung.IdvaiTro == "VT01")
                {
                    this.Hide();
                    TrangChu trangChu = new TrangChu();
                    trangChu.ShowDialog();

                }
                else if (nguoiDung.IdvaiTro == "VT02")
                {
                    this.Hide();
                    BanHang banHang = new BanHang();
                    banHang.ShowDialog();
                }
            }
            //else
            //{
            //    if (txt_tendn.Text == "")
            //    {
            //        MessageBox.Show(" moi nhap email va mk", "thong bao", MessageBoxButtons.OK);
            //    }
            //    else if (txt_mk.Text == "")
            //    {
            //        MessageBox.Show(" moi nhap email va mk", "thong bao", MessageBoxButtons.OK);
            //    }
            //    else 
            //    {
            //        MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK);
            //    }
            //}
            //----------------------------------------------------------------------------------------------------------
            //if(txt_tendn.Text == "")
            //{
            //    MessageBox.Show(" moi nhap email va mk", "thong bao", MessageBoxButtons.OK);
            //}
            //else if (txt_mk.Text == "")
            //{
            //    MessageBox.Show(" moi nhap email va mk", "thong bao", MessageBoxButtons.OK);
            //}
            //else
            //{
            //    if (nguoiDung.IdvaiTro == "VT01")
            //    {
            //        this.Hide();
            //        TrangChu trangChu = new TrangChu();
            //        trangChu.ShowDialog();

            //    }
            //    else if (nguoiDung.IdvaiTro == "VT02")
            //    {
            //        this.Hide();
            //        BanHang banHang = new BanHang();
            //        banHang.ShowDialog();
            //    }

            //}
            //TrangChu trangchu = new TrangChu();
            //trangchu.Show();
        }
    }
}