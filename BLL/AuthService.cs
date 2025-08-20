using MiniHotel.DAL;
using MiniHotel.Models;
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
        public User Login(string username, string password)
        {
            return _userRepository.GetUser(username, password);
        }
    }
}
