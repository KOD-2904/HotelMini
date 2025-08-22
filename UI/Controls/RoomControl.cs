using MiniHotel.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniHotel.UI.Controls
{
    public partial class RoomControl : UserControl
    {
        private readonly RoomService _roomService;
        public RoomControl()
        {
            InitializeComponent();
            _roomService = new RoomService();
            LoadRoom();
        }

        private void LoadRoom()
        {
            flowRooms.Controls.Clear();
            var rooms = _roomService.getAllRooms();
            foreach (var room in rooms)
            {
                var card = new Controls.RoomCardControl(room);
                flowRooms.Controls.Add(card);
            }

        }
    }
}
