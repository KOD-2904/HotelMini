namespace MiniHotel.UI.Controls
{
    partial class RoomControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowRooms;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            this.flowRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowRooms
            // 
            this.flowRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowRooms.AutoScroll = true;
            this.flowRooms.WrapContents = true;
            this.flowRooms.Name = "flowRooms";
            this.flowRooms.Size = new System.Drawing.Size(600, 400);
            // 
            // RoomControl
            // 
            this.Controls.Add(this.flowRooms);
            this.Name = "RoomControl";
            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);
        }
        #endregion
    }
}
