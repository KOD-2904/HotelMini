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
    public class UserService
    {
        private readonly UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public CreateUserResult creatUser(User user)
        {
            var result = new CreateUserResult();

            if (user == null || string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.PasswordHash))
            {
                result.Success = false;
                result.Message = "Dữ liệu user không hợp lệ";
                return result;
            }

            // 1. Check username tồn tại
            var existing = _userRepository.GetUserByUsername(user.Username);
            if (existing != null)
            {
                result.Success = false;
                result.Message = "Username đã tồn tại";
                return result;
            }

            // 2. Hash password
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);

            // 3. Insert user qua repository
            bool created = _userRepository.InsertUser(user);
            result.Success = created;
            result.Message = created ? "Tạo user thành công" : "Tạo user thất bại";

            return result;
        }
    }
}
