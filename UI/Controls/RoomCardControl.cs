using MiniHotel.Models;
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
    public partial class RoomCardControl : UserControl
    {
        public RoomCardControl(Room room)
        {
            InitializeComponent();
            lblRoomNumber.Text = $"Phòng: {room.RoomNumber}";
            lblStatus.Text = room.RoomStatus;
            lblType.Text = $"Loại: {room.RoomTypeID}";
            switch (room.RoomStatus)
            {
                case "Available":
                    this.BackColor = Color.Blue;
                    this.btnChiTiet.Show();
                    this.btnDatNhan.Show();
                    break;
                case "Booked":
                    this.BackColor = Color.Yellow;
                    this.btnDatNhan.Text = "Nhận";
                    break;
                case "Occupied":
                    this.BackColor = Color.Green;
                    this.btnDatNhan.Hide();
                    break;
                case "Maintenance":
                    this.BackColor = Color.Gray;
                    this.btnDatNhan.Hide();
                    this.btnChiTiet.Hide();
                    break;
            }

        }
    }
}
