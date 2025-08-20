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
        public User GetUser(string username, string password)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(_connectionString)) 
            { 
                conn.Open();
                string sqlString = @"SELECT u.UserID, u.Username, u.PasswordHash, r.RoleName
                    FROM Users u
                    INNER JOIN Roles r ON u.RoleID = r.RoleID
                    WHERE u.Username = @Username AND u.PasswordHash = @Password
                          AND u.Status = 'Active'";
                SqlCommand sqlCommand = new SqlCommand(sqlString, conn);
                sqlCommand.Parameters.AddWithValue("@Username", username);
                sqlCommand.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            UserID = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            PasswordHash = reader.GetString(2),
                            Role = reader.GetString(3)

                        };
                    }
                 }
            }
            return user;
        }
    }
}
