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
    public partial class NhanVien : Form
    {
        NguoiDungServices ndservices;
        string idnv;
        public NhanVien()
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login loGin = new Login();
            loGin.ShowDialog();

        }
        private void LoadData()
        {
            int stt = 1;
            dataGridView1.DataSource = ndservices.GetallND().Select(x => new
            {
                STT = stt++,
                x.IdnguoiDung,
                x.Ten,
                x.Diachi,
                x.Email,
                x.MatKhau,
                x.Trangthai,
                x.Dthoai,

            }).ToList();
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "ID";
            dataGridView1.Columns[2].HeaderText = "Tên";
            dataGridView1.Columns[3].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Mật khẩu";
            dataGridView1.Columns[6].HeaderText = "Trạng thái";
            dataGridView1.Columns[7].HeaderText = "SĐT";
            dataGridView1.Columns[5].Visible = false;


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ndservices.AddUser(txtTen.Text, txtMatKhau.Text, txtDiaChi.Text, txtEmail.Text, txtSoDienThoai.Text, cbxTrangThai.Text));
            LoadData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            if (d < 0)
            {

            }
            else
            {
                cbxTrangThai.ResetText();
                idnv = dataGridView1.Rows[d].Cells[1].Value.ToString();
                txtTen.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
                txtSoDienThoai.Text = dataGridView1.Rows[d].Cells[7].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[d].Cells[4].Value.ToString();
                txtMatKhau.Text = dataGridView1.Rows[d].Cells[5].Value.ToString();
                cbxTrangThai.SelectedValue = dataGridView1.Rows[d].Cells[6].Value.ToString();
                cbxTrangThai.SelectedText = dataGridView1.Rows[d].Cells[6].Value.ToString();
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            ndservices = new();
            LoadData();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (idnv == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa");
            }
            else
            {
                MessageBox.Show(ndservices.UpdateUser(idnv, txtTen.Text, txtMatKhau.Text, txtDiaChi.Text, txtEmail.Text, txtSoDienThoai.Text, cbxTrangThai.Text));
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(idnv == null)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần xóa","Thông báo",MessageBoxButtons.OK);
            }    
            else if (MessageBox.Show("Bạn có thực sự muốn xóa không?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ndservices.Xoa(idnv);
                LoadData();
            }
        }
    }
}
