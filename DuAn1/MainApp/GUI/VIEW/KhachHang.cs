using Main.DAL.Services;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Services;

namespace APPBanHang
{
    public partial class KhachHang : Form
    {
        KhachHangService khachHangService;
        LoaiKhachHangService loaiKhachHangService;
        string idkh;
        public KhachHang()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            SanPham sanpham = new SanPham();
            sanpham.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            NhanVien nhanvien = new NhanVien();
            nhanvien.ShowDialog();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            //HoaDon hoadon = new HoaDon();
            //hoadon.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.ShowDialog();

        }
        private void button_Click_Voucher(object sender, EventArgs e)
        {
            this.Hide();

            Voucher voucher = new Voucher();
            voucher.ShowDialog();
            this.Close();
        }
        private void button_Click_BanHang(object sender, EventArgs e)
        {
            this.Hide();

            BanHang banHang = new BanHang();
            banHang.ShowDialog();
            this.Close();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();

            KhachHang khachHang = new KhachHang();
            khachHang.ShowDialog();
            this.Close();
        }
        public void loaddatakh()
        {
            int stt = 1;
            dgvDanhSachKhachHang.DataSource = khachHangService.Getallkh().Select(x => new
            {

                STT = stt++,
                x.Idkh,

                x.Idloaind,
                x.Ten,
                x.Sdt,
                x.Diachi,
                x.Email,

            }).ToList();
            dgvDanhSachKhachHang.Columns[0].HeaderText = "STT";
            dgvDanhSachKhachHang.Columns[1].HeaderText = "idkh";
            dgvDanhSachKhachHang.Columns[2].HeaderText = "idloaind";
            dgvDanhSachKhachHang.Columns[3].HeaderText = "ten";
            dgvDanhSachKhachHang.Columns[4].HeaderText = "sdt";
            dgvDanhSachKhachHang.Columns[5].HeaderText = "diachi";
            dgvDanhSachKhachHang.Columns[6].HeaderText = "Email";


        }

        private void btnLuu_Click(object sender, EventArgs e)
        { if (MessageBox.Show("Bạn có muốn lưu không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (khachHangService.Getallkh().Find(x => x.Ten == txtTenKhachHang.Text) != null)
                {
                    var check = MessageBox.Show("Đã có khách hàng trong danh sách  bạn có muốn cập nhật không", "Thông báo", MessageBoxButtons.YesNoCancel);
                    if (check == DialogResult.Yes)
                    {
                        var spdaco = khachHangService.Getallkh().Find(x => x.Ten == txtTenKhachHang.Text);
                        khachHangService.Sua(spdaco.Idkh, txtTenKhachHang.Text, txtSoDienThoai.Text, txtDiaChi.Text, txtDiem.Text, txtEmail.Text);
                    }
                    else if (check == DialogResult.No)
                    {
                        MessageBox.Show(khachHangService.Them(txtTenKhachHang.Text, txtSoDienThoai.Text, txtDiaChi.Text, txtEmail.Text, txtDiem.Text));
                    }
                }
          
            else
            {
                MessageBox.Show(khachHangService.Them(txtTenKhachHang.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtEmail.Text, txtDiem.Text));
                }
            }
            loaddatakh();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            khachHangService = new KhachHangService();
            loaddatakh();
        }

        private void dgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;

            if (d < 0)
            {

            }
            else if (d >= 0)
            {
                idkh = dgvDanhSachKhachHang.Rows[d].Cells[1].Value.ToString();
                txtTenKhachHang.Text = dgvDanhSachKhachHang.Rows[d].Cells[3].Value.ToString();
                txtSoDienThoai.Text = dgvDanhSachKhachHang.Rows[d].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvDanhSachKhachHang.Rows[d].Cells[5].Value.ToString();
                txtEmail.Text = dgvDanhSachKhachHang.Rows[d].Cells[6].Value.ToString();
                txtDiem.Text = dgvDanhSachKhachHang.Rows[d].Cells[2].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(khachHangService.Sua(idkh, txtTenKhachHang.Text, txtDiaChi.Text, txtSoDienThoai.Text, txtEmail.Text, txtDiem.Text));
            }
            loaddatakh();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(khachHangService.Xoa(idkh));
                loaddatakh();
            }
        }
    }
}
