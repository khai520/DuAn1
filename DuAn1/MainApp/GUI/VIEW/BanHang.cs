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
        string mahd, id, mahdct, idsp;
        int sltong, gia, sl;
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
            dgvDanhSachHoaDon.DataSource = _hoadonService.GetHoadons().Select(x => new
            {
                STT = Stt++,
                x.Mahd,
                x.Idkh,
                x.IdnguoiDung,
                x.Idmagiamgia,
                x.Ngayban,
                x.Tongtien,
                x.Trangthai,
                x.Soluong,
            }).ToList().Where(x => x.Trangthai == "CHUA TT").ToList();
            dgvDanhSachHoaDon.Columns[0].HeaderText = "STT";
            dgvDanhSachHoaDon.Columns[1].HeaderText = "MaHD";
            dgvDanhSachHoaDon.Columns[2].HeaderText = "Tên khách hàng";
            dgvDanhSachHoaDon.Columns[3].HeaderText = "Tên nhân viên";
            dgvDanhSachHoaDon.Columns[4].HeaderText = "Mã giảm giá";
            dgvDanhSachHoaDon.Columns[5].HeaderText = "Ngày bán";
            dgvDanhSachHoaDon.Columns[6].HeaderText = "Tổng tiền";
            dgvDanhSachHoaDon.Columns[7].HeaderText = "Trạng thái";
            dgvDanhSachHoaDon.Columns[8].Visible = true;
        }

        private void loaddanhsachsanpham()
        {
            loaddatasp();
            int Stt = 1;
            dgvDanhSachSanPham.DataSource = _ctsp.GetallChitietsanpham().Join(_SanphamServices.GetSanphams(), x => x.Masp, y => y.Masp, (x, y) => new
            {
                x.Idctsp,
                y.Tensp,
                x.Soluong,
                y.Giaban,
                y.Trangthai,
                x.Idncc,
                x.Idmau,
                x.Idchatlieu,
                x.Idkichthuoc,
                x.Iddegiay,
            }).ToList().Join(_ncc.getallSnhacungcap(), x => x.Idncc, y => y.Idncc, (x, y) => new
            {
                STT = Stt++,
                x.Tensp,
                x.Soluong,
                x.Giaban,
                x.Trangthai,
                y.Tenncc,
                x.Idmau,
                x.Idchatlieu,
                x.Idkichthuoc,
                x.Iddegiay,
                x.Idctsp
            }).ToList().Where(x => x.Trangthai == "Còn hàng").ToList();
            dgvDanhSachSanPham.Columns[0].HeaderText = "STT";
            dgvDanhSachSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvDanhSachSanPham.Columns[2].HeaderText = "Số lượng";
            dgvDanhSachSanPham.Columns[3].HeaderText = "Giá bán";
            dgvDanhSachSanPham.Columns[4].HeaderText = "Trạng thái";
            dgvDanhSachSanPham.Columns[5].HeaderText = "Nhà cung cấp";
            dgvDanhSachSanPham.Columns[6].HeaderText = "Màu";
            dgvDanhSachSanPham.Columns[7].HeaderText = "Chất liệu";
            dgvDanhSachSanPham.Columns[8].HeaderText = "Kích thước";
            dgvDanhSachSanPham.Columns[9].HeaderText = "Đế giày";
            dgvDanhSachSanPham.Columns[10].Visible = false;


        }
        public void loaddatasp()
        {
            foreach(var item in _SanphamServices.GetSanphams())
            {
                _SanphamServices.UpdateSL(item.Masp);
            }
        }
        private void loadhoadonchitiet()
        {
            int Stt = 1;
            dgvHoaDonChiTiet.DataSource = _hoadonChiTietServices.GetHoaDonCT().Where(x => x.Mahd == mahd).Join(_ctsp.GetallChitietsanpham(), x => x.Idctsp, x => x.Idctsp, (x, y) => new
            {
                x.Slban,
                x.Gia,
                x.Ngayban,
                x.Mahdct,
                x.Mahd,
                x.Idctsp,
                y.Masp
            }).ToList().Join(_SanphamServices.GetSanphams(), x => x.Masp, y => y.Masp, (x, y) => new
            {
                STT = Stt++,
                y.Tensp,
                x.Slban,
                x.Gia,
                x.Ngayban,
                x.Mahdct,
                x.Mahd,
                x.Idctsp,
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
            dgvHoaDonChiTiet.Columns[8].Visible = false;
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
            idsp = null;
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
                Clear();
                mahd = dgvDanhSachHoaDon.Rows[d].Cells[1].Value.ToString();
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

                idsp = _ctsp.GetallChitietsanpham().Find(x => x.Idctsp == dgvDanhSachSanPham.Rows[d].Cells[10].Value.ToString()).Masp;
                id = dgvDanhSachSanPham.Rows[d].Cells[10].Value.ToString();
                lb_SPThem.Text = dgvDanhSachSanPham.Rows[d].Cells[1].Value.ToString();
                sl = sltong = Convert.ToInt32(dgvDanhSachSanPham.Rows[d].Cells[2].Value.ToString());
                gia = Convert.ToInt32(dgvDanhSachSanPham.Rows[d].Cells[3].Value.ToString());
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
                id = dgvHoaDonChiTiet.Rows[d].Cells[7].Value.ToString();
                idsp = dgvHoaDonChiTiet.Rows[d].Cells[8].Value.ToString();
                gia = Convert.ToInt32(_SanphamServices.GetSanphams().Find(x => x.Masp == idsp).Giaban);
                sl= sltong = Convert.ToInt32(_ctsp.GetallChitietsanpham().Find(x => x.Idctsp == id).Soluong);
                sl += Convert.ToInt32(dgvHoaDonChiTiet.Rows[d].Cells[2].Value.ToString());
                nUD.Maximum = sl;
                lb_SPThem.Text = dgvHoaDonChiTiet.Rows[d].Cells[1].Value.ToString();
                MessageBox.Show($"{sltong}");
                mahdct = dgvHoaDonChiTiet.Rows[d].Cells[5].Value.ToString();
                mahd = dgvHoaDonChiTiet.Rows[d].Cells[6].Value.ToString();
                nUD.Value = Convert.ToInt32(dgvHoaDonChiTiet.Rows[d].Cells[2].Value.ToString());
            }
        }

        private void nUD_ValueChanged(object sender, EventArgs e)
        {
            lb_Gia.Text = Convert.ToString(nUD.Value * gia);
        }
        public long Tongtien()
        {
            long tong = 0;
            foreach (var item in _hoadonChiTietServices.GetHoaDonCT())
            {
                tong += Convert.ToInt64(item.Gia);
            }
            return tong;
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
                    if (nUD.Value != 0)
                    {
                        var list = _hoadonChiTietServices.GetHoaDonCT().Find(x => x.Idctsp == id);
                        if (_hoadonChiTietServices.GetHoaDonCT().Find(x => x.Idctsp == id) == null)
                        {
                            _hoadonChiTietServices.AddHoaDonCT(mahd, id, (int)(nUD.Value), lb_Gia.Text);
                            _ctsp.UpdateSL(idsp, sltong - Convert.ToInt32(nUD.Value));
                        }
                        else
                        {
                            _hoadonChiTietServices.UpdateHoaDonCT(list.Mahdct, Convert.ToInt32(list.Slban) + Convert.ToInt32(nUD.Value), Convert.ToInt32(list.Gia) + Convert.ToInt32(lb_Gia.Text));
                            _ctsp.UpdateSL(idsp, sltong - Convert.ToInt32(nUD.Value));
                        }
                        _hoadonService.UpdateGia(mahd, Tongtien());
                        _SanphamServices.UpdateSL(idsp);
                      
                   BanHang_Load_1(sender,e);
                   
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Chọn số lượng");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn sản phẩm");
                }
            }
            else
            {
                MessageBox.Show("Chưa Thêm hóa đơn hóa đơn");
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (mahd != null)
            {
                if (id != null)
                {
                    if (nUD.Value >= 0)
                    {
                        var list = _hoadonChiTietServices.GetHoaDonCT().Find(x => x.Idctsp == id);
                        _hoadonChiTietServices.UpdateHoaDonCT(list.Mahdct, Convert.ToInt32(nUD.Value), Convert.ToInt32(lb_Gia.Text));
                        _ctsp.UpdateSL(idsp, sltong - Convert.ToInt32(nUD.Value));

                    }
                    else
                    {
                        btn_Xoa_Click(sender, e);
                    }
                    _hoadonService.UpdateGia(mahd, Tongtien());
                    _SanphamServices.UpdateSL(idsp);
                    loaddanhsachsanpham();
                    loaddanhsachhoadon();
                    loadhoadonchitiet();
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
                    _ctsp.UpdateSL(idsp, sltong + Convert.ToInt32(nUD.Value));
                    _hoadonService.UpdateGia(mahd, Tongtien());
                    _SanphamServices.UpdateSL(idsp);

                    BanHang_Load_1(sender, e);
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

        private void nUD_KeyUp(object sender, KeyEventArgs e)
        {
            if (id != null)
            {
                if (nUD.Value > nUD.Maximum)
                {
                    MessageBox.Show("Quá số lượng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }

        }

        private void nUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (id != null)
            {
                if (nUD.Value <= 0)
                {
                    MessageBox.Show("Quá số lượng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
        }

        private void dgvHoaDonChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (_hoadonService.GetHoadons().Where(x => x.Trangthai == "CHUA TT").Count() <= 5)
            {

            }
        }
    }
}
