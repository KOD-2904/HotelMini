using System.Windows.Forms;

namespace MiniHotel.UI.Controls
{
    partial class RoomCardControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnDatNhan;
        private System.Windows.Forms.Button btnChiTiet;

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
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnDatNhan = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRoomNumber.Location = new System.Drawing.Point(10, 10);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(77, 28);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "Phòng:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 40);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Trạng thái";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(10, 65);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(88, 20);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Loại phòng";
            // 
            // btnDatNhan
            // 
            this.btnDatNhan.BackColor = System.Drawing.Color.LightBlue;
            this.btnDatNhan.Location = new System.Drawing.Point(3, 90);
            this.btnDatNhan.Name = "btnDatNhan";
            this.btnDatNhan.Size = new System.Drawing.Size(72, 37);
            this.btnDatNhan.TabIndex = 3;
            this.btnDatNhan.Text = "Đặt";
            this.btnDatNhan.UseVisualStyleBackColor = true;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.LightCoral;
            this.btnChiTiet.Location = new System.Drawing.Point(103, 90);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(72, 37);
            this.btnChiTiet.TabIndex = 5;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // RoomCardControl
            // 
            this.BackColor = System.Drawing.Color.Teal;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnDatNhan);
            this.Controls.Add(this.btnChiTiet);
            this.Name = "RoomCardControl";
            this.Size = new System.Drawing.Size(180, 130);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}

