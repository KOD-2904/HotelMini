using MiniHotel.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniHotel.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //this.Size = new Size(1946, 1106);
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowRoom_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            RoomControl roomControl = new RoomControl();
            roomControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(roomControl);
        }
    }
}
