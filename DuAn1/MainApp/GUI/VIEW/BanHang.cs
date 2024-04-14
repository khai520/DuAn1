using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.DAL.Services;
using WinFormsApp1.Services;

namespace APPBanHang
{
    public partial class BanHang : Form
    {
        HoadonServices _hoadonService;
        SanphamServices _SanphamServices;
        HoaDonChiTietServices _hoadonChiTietServices;
        CtSanphamService _ctsp;
        NhaCungCapServices _ncc;
        string mahd, id, mahdct;
        int sltong;
        decimal gia;
        //int _idCellClick;
        public BanHang()
        {
            InitializeComponent();
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
            this.Hide();

            Voucher voucher = new Voucher();
            voucher.ShowDialog();
            this.Close();
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.ShowDialog();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHang ban = new BanHang();
            ban.ShowDialog();
            this.Close();
        }

        private void btnTimSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu();
            tc.ShowDialog();
            this.Close();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();

            SanPham sanpham = new SanPham();
            sanpham.ShowDialog();
            this.Close();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();

            KhachHang khachHang = new KhachHang();
            khachHang.ShowDialog();
            this.Close();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            this.Hide();

            Voucher voucher = new Voucher();
            voucher.ShowDialog();
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void loaddanhsachhoadon()
        {
            int Stt = 1;
            dgvDanhSachHoaDon.DataSource = _hoadonService.Change().Join(_hoadonChiTietServices.GetHoaDonCT(), x => x.Mahd, y => y.Mahd, (x, y) => new
            {
                STT = Stt++,
                x.Mahd,
                x.Idkh,
                x.IdnguoiDung,
                x.Idmagiamgia,
                x.Ngayban,
                x.Soluong,
                x.Tongtien,
                x.Trangthai,
                y.Mahdct
            }).ToList().Where(x => x.Trangthai == "CHUA TT").ToList();
            dgvDanhSachHoaDon.Columns[0].HeaderText = "STT";
            dgvDanhSachHoaDon.Columns[1].HeaderText = "MaHD";
            dgvDanhSachHoaDon.Columns[2].HeaderText = "Tên khách hàng";
            dgvDanhSachHoaDon.Columns[3].HeaderText = "Tên nhân viên";
            dgvDanhSachHoaDon.Columns[4].HeaderText = "Mã giảm giá";
            dgvDanhSachHoaDon.Columns[5].HeaderText = "Ngày bán";
            dgvDanhSachHoaDon.Columns[6].HeaderText = "Số lượng";
            dgvDanhSachHoaDon.Columns[7].HeaderText = "Tổng tiền";
            dgvDanhSachHoaDon.Columns[8].HeaderText = "Trạng thái";
            dgvDanhSachHoaDon.Columns[9].Visible = false;
        }

        private void loaddanhsachsanpham()
        {
            int Stt = 1;
            dgvDanhSachSanPham.DataSource = _SanphamServices.GetSanphams().Join(_ctsp.GetallChitietsanpham(), x => x.Masp, y => y.Masp, (x, y) => new
            {
                x.Masp,
                x.Tensp,
                x.Soluong,
                x.Giaban,
                x.Trangthai,
                y.Idncc,
                y.Idmau,
                y.Idchatlieu,
                y.Idkichthuoc,
                y.Iddegiay
            }).ToList().Join(_ncc.getallSnhacungcap(), x => x.Idncc, y => y.Idncc, (x, y) => new
            {
                STT = Stt++,
                x.Masp,
                x.Tensp,
                x.Soluong,
                x.Giaban,
                x.Trangthai,
                y.Tenncc,
                x.Idmau,
                x.Idchatlieu,
                x.Idkichthuoc,
                x.Iddegiay
            }).ToList().Where(x => x.Trangthai == "Còn hàng").ToList();
            dgvDanhSachSanPham.Columns[0].HeaderText = "STT";
            dgvDanhSachSanPham.Columns[1].HeaderText = "Masp";
            dgvDanhSachSanPham.Columns[2].HeaderText = "Tên sản phẩm";
            dgvDanhSachSanPham.Columns[3].HeaderText = "Số lượng";
            dgvDanhSachSanPham.Columns[4].HeaderText = "Giá bán";
            dgvDanhSachSanPham.Columns[5].HeaderText = "Trạng thái";
            dgvDanhSachSanPham.Columns[6].HeaderText = "Nhà cung cấp";
            dgvDanhSachSanPham.Columns[7].HeaderText = "Màu";
            dgvDanhSachSanPham.Columns[8].HeaderText = "Chất liệu";
            dgvDanhSachSanPham.Columns[9].HeaderText = "Kích thước";
            dgvDanhSachSanPham.Columns[10].HeaderText = "Đế giày";

        }
        private void loadhoadonchitiet()
        {
            int Stt = 1;
            dgvHoaDonChiTiet.DataSource = _hoadonChiTietServices.GetHoaDonCT().Where(x => x.Mahd == mahd).Join(_SanphamServices.GetSanphams(), x => x.Masp, x => x.Masp, (x, y) => new
            {
                STT = Stt++,
                y.Tensp,
                x.Slban,
                x.Gia,
                x.Ngayban,
                x.Mahdct,
                x.Mahd,
                x.Masp
            }).ToList();
            dgvHoaDonChiTiet.Columns[0].HeaderText = "STT";
            dgvHoaDonChiTiet.Columns[1].HeaderText = "Tên sản phẩm";
            dgvHoaDonChiTiet.Columns[2].HeaderText = "Số lượng";
            dgvHoaDonChiTiet.Columns[3].HeaderText = "Giá";
            dgvHoaDonChiTiet.Columns[4].HeaderText = "Ngày bán";
            dgvHoaDonChiTiet.Columns[5].Visible = false;
            dgvHoaDonChiTiet.Columns[6].Visible = false;
            dgvHoaDonChiTiet.Columns[7].Visible = false;
        }

        private void BanHang_Load_1(object sender, EventArgs e)
        {
            _SanphamServices = new();
            _hoadonChiTietServices = new();
            _hoadonService = new();
            _ctsp = new();
            _ncc = new();
            loaddanhsachhoadon();
            loaddanhsachsanpham();
            loadhoadonchitiet();
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {

        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
        public void Clear()
        {
            id = null;
            mahdct = null;
            gia = 0;
            sltong = 0;
            lb_Gia.Text = null;
            nUD.Value = 0;
            nUD.Minimum = 0;
        }
        private void dgvDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            if (d < 0)
            {

            }
            else if (d >= 0)
            {
                mahd = dgvDanhSachHoaDon.Rows[d].Cells[1].Value.ToString();
                mahdct = dgvDanhSachHoaDon.Rows[d].Cells[9].Value.ToString();
                loadhoadonchitiet();
            }
        }
        private void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            if (d < 0)
            {

            }
            else if (d >= 0)
            {
                id = dgvDanhSachSanPham.Rows[d].Cells[1].Value.ToString();
                lb_SPThem.Text = dgvDanhSachSanPham.Rows[d].Cells[2].Value.ToString();
                sltong = Convert.ToInt32(dgvDanhSachSanPham.Rows[d].Cells[3].Value.ToString());
                gia = Convert.ToDecimal(dgvDanhSachSanPham.Rows[d].Cells[4].Value.ToString());
                nUD.Maximum = sltong;
            }
        }

        private void dgvHoaDonChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            if (d < 0)
            {

            }
            else if (d >= 0)
            {
                gia = Convert.ToInt32(_SanphamServices.GetSanphams().Find(x => x.Masp == dgvHoaDonChiTiet.Rows[d].Cells[7].Value.ToString()).Giaban);
                sltong = Convert.ToInt32(_SanphamServices.GetSanphams().Find(x => x.Masp == dgvHoaDonChiTiet.Rows[d].Cells[7].Value.ToString()).Soluong);
                sltong += Convert.ToInt32(_hoadonChiTietServices.GetHoaDonCT().Find(x => x.Masp == dgvHoaDonChiTiet.Rows[d].Cells[7].Value.ToString()).Slban);
                nUD.Maximum = sltong;
                mahdct = dgvHoaDonChiTiet.Rows[d].Cells[5].Value.ToString();
                nUD.Value = Convert.ToInt32(dgvHoaDonChiTiet.Rows[d].Cells[2].Value.ToString());
                lb_Gia.Text = dgvHoaDonChiTiet.Rows[d].Cells[3].Value.ToString();
            }
        }

        private void nUD_ValueChanged(object sender, EventArgs e)
        {
            lb_Gia.Text = Convert.ToString(nUD.Value * gia);
        }
        public void Reset()
        {

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (mahd != null)
            {
                if (id != null)
                {
                    if (_hoadonChiTietServices.GetHoaDonCT().Find(x => x.Masp == id) == null)
                    {
                        _hoadonChiTietServices.AddHoaDonCT(mahd,id,nUD.Value,lb_Gia.Text);
                    }
                    else
                    {
                        _hoadonChiTietServices.UpdateHoaDonCT(mahdct, mahd, id, nUD.Value, lb_Gia.Text);
                    }
                    _SanphamServices.UpdateSL(id, sltong - Convert.ToInt32(nUD.Value));
                    Clear();
                }
                else
                {
                    MessageBox.Show("Chưa chọn sản phẩm");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn hóa đơn");
            }
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (mahd != null)
            {
                if (id != null)
                {
                    _hoadonChiTietServices.UpdateHoaDonCT(mahdct, mahd, id, nUD.Value, lb_Gia.Text);
                    _SanphamServices.UpdateSL(id, sltong - Convert.ToInt32(nUD.Value));
                    Clear();
                }
                else
                {
                    MessageBox.Show("Chưa chọn sản phẩm");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn hóa đơn");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (mahd != null)
            {
                if (id != null)
                {
                    _hoadonChiTietServices.XoaHDCT(mahdct);
                }
                else
                {
                    MessageBox.Show("Chưa chọn sản phẩm");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn hóa đơn");
            }
        }

            private void nUD_KeyUp(object sender, KeyEventArgs e)
        {
            if (nUD.Value > nUD.Maximum)
            {
                MessageBox.Show("Quá số lượng");
            }
        }

        private void nUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (nUD.Value <= 0)
            {
                MessageBox.Show("Quá số lượng");
            }
        }
    }
}
