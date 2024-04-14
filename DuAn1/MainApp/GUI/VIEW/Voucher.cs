using Main.DAL.Services;
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
    public partial class Voucher : Form
    {
        MaGiamGiaServices mggsv = new MaGiamGiaServices();
        string idmgg;
        public Voucher()
        {
            InitializeComponent();
        }

        private void HoaDon1_Load(object sender, EventArgs e)
        {
            LoadData();
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
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            KhachHang khachHang = new KhachHang();
            khachHang.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            //HoaDon hoadon = new HoaDon();
            //hoadon.Show();
        }

        private void button_Click_BanHang(object sender, EventArgs e)
        {
            this.Hide();

            BanHang banHang = new BanHang();
            banHang.ShowDialog();
            this.Close();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            this.Hide();

            Voucher voucher = new Voucher();
            voucher.ShowDialog()
                ; this.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login loGin = new Login();
            loGin.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (mggsv.Them(txtMaVoucher.Text, Convert.ToInt32(textBox3.Text), dateTimePicker2.Value, dtp_hethan.Value))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }

        }
        private void LoadData()
        {
            int stt = 1;
            dgvDanhSachVoucher.DataSource = mggsv.Getallmagiam().Select(x => new
            {
                STT = stt++,
                x.Idmagiamgia,
                x.Tenma,
                x.Phamtramgiam,
                x.Ngaybatdau,
                x.Ngayketthuc
            }).ToList();
            dgvDanhSachVoucher.Columns[0].HeaderText = "STT";
            dgvDanhSachVoucher.Columns[1].HeaderText = "Tên mã";
            dgvDanhSachVoucher.Columns[2].HeaderText = "Phần trăm giảm";
            dgvDanhSachVoucher.Columns[3].HeaderText = "Ngày bắt đầu";
            dgvDanhSachVoucher.Columns[4].HeaderText = "Ngày kết thúc";
        }

        private void dgvDanhSachVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            if (d < 0)
            {

            }
            else if (d >= 0)
            {
                idmgg = dgvDanhSachVoucher.Rows[d].Cells[1].Value.ToString();
                txtMaVoucher.Text = dgvDanhSachVoucher.Rows[d].Cells[2].Value.ToString();
                textBox3.Text = dgvDanhSachVoucher.Rows[d].Cells[3].Value.ToString();
                dateTimePicker2.Value = Convert.ToDateTime(dgvDanhSachVoucher.Rows[d].Cells[4].Value);
                dtp_hethan.Value = Convert.ToDateTime(dgvDanhSachVoucher.Rows[d].Cells[5].Value);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idmgg == null)
            {
                MessageBox.Show("Vui lòng chọn voucher cần sửa");
            }
            else
            {
                if (mggsv.Sua(idmgg, txtMaVoucher.Text, Convert.ToInt32(textBox3.Text), Convert.ToDateTime(dateTimePicker2.Value), Convert.ToDateTime(dtp_hethan.Value)))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (idmgg == null)
            {
                MessageBox.Show("Chưa chọn voucher cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    mggsv.Xoa(idmgg);
                    LoadData();
                }
            }
        }

    }
}
