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
    public class RoomRepository
    {
        private readonly string _stringConnection;
        public RoomRepository()
        {
            _stringConnection = ConfigHelper.GetConnectionString();
        }
        public List<Room> GetAllRoom() 
        {
            var room = new List<Room>();
            using (SqlConnection conn = new SqlConnection(_stringConnection)) 
            {
                conn.Open();
                string sql = "SELECT RoomID, RoomNumber, RoomTypeID, Status, Note FROM Rooms";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    room.Add(new Room 
                    {
                        RoomID = (int)reader["RoomID"],
                        RoomNumber = reader["RoomNumber"].ToString(),
                        RoomTypeID = (int)reader["RoomTypeID"],
                        RoomStatus = reader["Status"].ToString(),
                        Note = reader["Note"]?.ToString()
                    });
                }
            }
            return room;
        }

    }
}
