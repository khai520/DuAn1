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
using MainApp.GUI.VIEW;

namespace APPBanHang
{
    public partial class SanPham : Form
    {
        SanphamServices _sanphamService;
        CtSanphamService ctSanphamService;
        NhaCungCapServices ncc;
        MauSacService mau;
        KichThuocService kt;
        Chatlieuservices cl;
        DeGiayService dg;
        string id, idctsp;
        public SanPham()
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
            //HoaDon hoadon = new HoaDon();
            //hoadon.Show();
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



        private void btnSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham sanPham = new SanPham();
            sanPham.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loGin = new Login();
            loGin.ShowDialog();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            _sanphamService = new();
            ctSanphamService = new();
            ncc = new();
            mau = new();
            kt = new();
            cl = new();
            dg = new();
            LoadData();
        }
        private void LoadData()
        {
            
            //var result = from sp in _sanphamService
            int Stt = 1;
            dgvDanhSachSanPham.DataSource = _sanphamService.GetSanphams().Select(x => new
            {
                STT = Stt++,
                x.Masp,
                x.Tensp,
                x.Soluong,
                x.Giaban,
                x.Trangthai
            }).ToList();

            dgvDanhSachSanPham.Columns[0].HeaderText = "STT";
            dgvDanhSachSanPham.Columns[1].HeaderText = "Masp";
            dgvDanhSachSanPham.Columns[2].HeaderText = "Tên sản phẩm";
            dgvDanhSachSanPham.Columns[3].HeaderText = "Tổng số lượng";
            dgvDanhSachSanPham.Columns[4].HeaderText = "Giá bán";
            dgvDanhSachSanPham.Columns[5].HeaderText = "Trạng thái";


        }
        public void Loadtab2()
        {
            _sanphamService.UpdateSL(id);
            int Stt2 = 1;
            var tab2 = ctSanphamService.GetallChitietsanpham().Join(ncc.getallSnhacungcap(), x => x.Idncc, y => y.Idncc, (x, y) => new
            {
                STT = Stt2++,
                x.Idctsp,
                x.Masp,
                x.Soluong,
                y.Tenncc,
                x.Idmau,
                x.Idchatlieu,
                x.Idkichthuoc,
                x.Iddegiay,
            }).ToList();
            if (id != null)
            {
                dgv_tab2.DataSource = tab2.Where(x => x.Masp == id).ToList();
                dgv_tab2.Columns[0].HeaderText = "STT";
                dgv_tab2.Columns[1].HeaderText = "IDctsp";
                dgv_tab2.Columns[2].HeaderText = "Masp";
                dgv_tab2.Columns[3].HeaderText = "Số lượng";
                dgv_tab2.Columns[4].HeaderText = "Nhà cung cấp";
                dgv_tab2.Columns[5].HeaderText = "Màu";
                dgv_tab2.Columns[6].HeaderText = "Chất liệu";
                dgv_tab2.Columns[7].HeaderText = "Kích thước";
                dgv_tab2.Columns[8].HeaderText = "Đế giày";
                cbx_Ncc.DataSource = ncc.getallSnhacungcap().ToList();
                cbx_Ncc.ValueMember = "IDNCC";
                cbx_Ncc.DisplayMember = "TENNCC";
                cbx_Mau.DataSource = mau.GetallMau().ToList();
                cbx_Mau.DisplayMember = "MAU";
                cbx_Kichthuoc.DataSource = kt.Getallkt().ToList();
                cbx_Kichthuoc.DisplayMember = "kichthuoc1";
                cbx_Chatlieu.DataSource = cl.Getallchatlieu().ToList();
                cbx_Chatlieu.DisplayMember = "Chatlieu1";
                cbx_DeGiay.DataSource = dg.Getalldegiay().ToList();
                cbx_DeGiay.DisplayMember = "degiay1";
            }
            else
            {
                dgv_tab2.DataSource = tab2;
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
            chiTietSanPham.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ThongTinNhaCungCap ttncc = new ThongTinNhaCungCap();
            ttncc.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangchu = new TrangChu();
            trangchu.ShowDialog();
            this.Close();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang kh = new KhachHang();
            kh.ShowDialog();
            this.Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien nhan = new NhanVien();
            nhan.ShowDialog();
            this.Close();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {

            if (_sanphamService.GetSanphams().Find(x => x.Tensp == txtTenSP.Text) != null)
            {
                var check = MessageBox.Show("Đã có sản phẩm trong kho bạn có muốn cập nhật không", "Thông báo", MessageBoxButtons.YesNoCancel);
                if (check == DialogResult.Yes)
                {
                    var spdaco = _sanphamService.GetSanphams().Find(x => x.Tensp == txtTenSP.Text);
                    _sanphamService.UpdateSP(spdaco.Masp, txtTenSP.Text, txtGiaBan.Text);
                }
                else if (check == DialogResult.No)
                {
                    MessageBox.Show(_sanphamService.AddSP(txtTenSP.Text, txtGiaBan.Text));
                }
            }
            else
            {
                MessageBox.Show(_sanphamService.AddSP(txtTenSP.Text, txtGiaBan.Text));
            }
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                MessageBox.Show("Chưa chọn sản phẩm cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show(_sanphamService.XoaSp(id), "Thông báo", MessageBoxButtons.OK);
                    LoadData();
                }
            }



        }

        private void dgvDanhSachSanPham_SelectionChanged(object sender, EventArgs e)
        {

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
                Clear2();
                txtTenSP.Text = dgvDanhSachSanPham.Rows[d].Cells[2].Value.ToString();
                txtGiaBan.Text = dgvDanhSachSanPham.Rows[d].Cells[4].Value.ToString();
            }
            
            Loadtab2();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_sanphamService.UpdateSP(id, txtTenSP.Text, txtGiaBan.Text));
            LoadData();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        public string Checkvali(dynamic? x)
        {
            if (!string.IsNullOrEmpty(x))
            {
                var y = x.ToString();
                return y;
            }
            else
            {
                return null;
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                MessageBox.Show(ctSanphamService.Them(cbx_Ncc.SelectedValue, id, cbx_Mau.Text, cbx_Chatlieu.Text, cbx_Kichthuoc.Text, cbx_DeGiay.Text, txt_Sl.Text));
                Loadtab2();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn thêm chi tiết!");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (idctsp == null)
            {
                MessageBox.Show("Chọn sản phẩm muốn sửa chi tiết");
            }
            else
            {
                MessageBox.Show(ctSanphamService.Sua(idctsp, cbx_Ncc.SelectedValue, cbx_Mau.Text, cbx_Chatlieu.Text, cbx_Kichthuoc.Text, cbx_DeGiay.Text, txt_Sl.Text));
                Loadtab2();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show(ctSanphamService.Xoa(idctsp));
                Loadtab2();
            }

        }

        private void dgv_tab2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;

            if (d < 0)
            {

            }
            else if (d >= 0)
            {
                cbx_Ncc.ResetText();
                cbx_Mau.ResetText();
                cbx_Chatlieu.ResetText();
                cbx_DeGiay.ResetText();
                cbx_Kichthuoc.ResetText();
                idctsp = dgv_tab2.Rows[d].Cells[1].Value.ToString();
                id = dgv_tab2.Rows[d].Cells[2].Value.ToString();
                txt_Sl.Text = dgv_tab2.Rows[d].Cells[3].Value.ToString();
                if (dgv_tab2.Rows[d].Cells[4].Value != null)
                {
                    cbx_Ncc.SelectedValue = dgv_tab2.Rows[d].Cells[4].Value.ToString();
                    cbx_Ncc.SelectedText = dgv_tab2.Rows[d].Cells[4].Value.ToString();
                }
                if (dgv_tab2.Rows[d].Cells[5].Value != null)
                {
                    cbx_Mau.SelectedText = dgv_tab2.Rows[d].Cells[5].Value.ToString();
                }
                if (dgv_tab2.Rows[d].Cells[6].Value != null)
                {
                    cbx_Chatlieu.SelectedText = dgv_tab2.Rows[d].Cells[6].Value.ToString();
                }
                if (dgv_tab2.Rows[d].Cells[7].Value != null)
                {
                    cbx_Kichthuoc.SelectedText = dgv_tab2.Rows[d].Cells[7].Value.ToString();
                }
                if (dgv_tab2.Rows[d].Cells[8].Value != null)
                {
                    cbx_DeGiay.SelectedText = dgv_tab2.Rows[d].Cells[8].Value.ToString();
                }
            }
        }
        public void Clear2()
        {
            cbx_Ncc.SelectedIndex = 0;
            cbx_Mau.SelectedIndex = -1;
            cbx_Chatlieu.SelectedIndex = -1;
            cbx_Kichthuoc.SelectedIndex = -1;
            cbx_DeGiay.SelectedIndex = -1;
        }
        public void Clear()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            id = null;
            _sanphamService = new();
            ctSanphamService = new();
            LoadData();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
