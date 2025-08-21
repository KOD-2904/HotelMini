using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotel.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }   // Họ tên đầy đủ
        public string Username { get; set; }   // Tài khoản đăng nhập
        public string PasswordHash { get; set; } // Mật khẩu (hiện tại lưu plain text, sau này hash)
        public int Role { get; set; }     
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
    }
}
