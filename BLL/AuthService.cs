using MiniHotel.DAL;
using MiniHotel.Models;
using MiniHotel.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotel.BLL
{
    public class AuthService
    {
        private readonly UserRepository _userRepository;
        public AuthService()
        {
            _userRepository = new UserRepository();
        }
        public LoginResult Login(string username, string password)
        {
            var user = _userRepository.GetUserByUsername(username);
            if (user == null)
                return new LoginResult { Success = false, Message = "Username không tồn tại" };

            if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                return new LoginResult { Success = false, Message = "Password không đúng" };

            return new LoginResult { Success = true, User = user };
        }
        public User checkUserExist(string username)
        {
            User user = null;
            return user;
        }
    }
}
