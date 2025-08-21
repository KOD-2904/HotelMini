using MiniHotel.Common;
using MiniHotel.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotel.DAL
{
    public class UserRepository
    {
        private readonly string _connectionString;
        public UserRepository()
        {
            _connectionString = ConfigHelper.GetConnectionString();
        }
        //public User Login(string username, string password)
        //{
        //    UserRepository userRepository = new UserRepository();
        //    var user = userRepository.GetUserByUsername(username);
        //    if (user == null)
        //        throw new Exception("Username không tồn tại");

        //    if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
        //        throw new Exception("Password không đúng");

        //    return user;
        //}
        public User GetUserByUsername(string username)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"SELECT u.UserID, u.Username, u.PasswordHash, u.RoleID, u.FullName
                       FROM Users u
                       WHERE u.Username = @Username";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null; // Username không tồn tại
                    }

                    return new User
                    {
                        UserID = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        PasswordHash = reader.GetString(2),
                        Role = reader.GetInt32(3),
                        FullName = reader.GetString(4)
                    };
                }
            }
        }
        public bool InsertUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO Users (Username, PasswordHash, RoleID, FullName, Email, Phone)
                           VALUES (@Username, @PasswordHash, @Role, @FullName, @Email, @Phone)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.Parameters.AddWithValue("@FullName", user.FullName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

    }
}
