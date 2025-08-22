using MiniHotel.DAL;
using MiniHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHotel.BLL
{
    public class RoomService
    {
        private RoomRepository _roomRepository;
        public RoomService()
        {
            _roomRepository = new RoomRepository();
        }
        public List<Room> getAllRooms()
        {
            return _roomRepository.GetAllRoom();
        }
    }
}
