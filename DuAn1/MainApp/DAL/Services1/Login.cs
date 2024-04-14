
using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.DAL.Services
{
    internal class Login
    {
        public List<NguoiDung> GetAll(List<NguoiDung> list)
        {
            return list.ToList();
        }
        public bool CheckLogin(string tk, string mk, List<NguoiDung> list)
        {
            if (tk == "" || mk == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                if (GetAll(list).Where(x => x.Email == tk && x.MatKhau == mk).ToList().Count() > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
            }
        }

    }
}
