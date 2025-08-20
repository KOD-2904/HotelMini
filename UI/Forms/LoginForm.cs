using MiniHotel.BLL;
using MiniHotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MiniHotel.UI.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string username = txtUsername.Text;
            User user = _authService.Login(username, password);

            if (user != null)
            {
                MessageBox.Show($"Xin chào {user.Username} ({user.Role})");
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //string connStr = @"Server=DESKTOP-3UU5LVQ\SQLEXPRESS;Database=MiniHotel;Integrated Security=True;TrustServerCertificate=True;";

            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connStr))
            //    {
            //        conn.Open();
            //        MessageBox.Show("✅ Kết nối thành công tới DB HotelMini!", "Thông báo",
            //                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("❌ Lỗi kết nối: " + ex.Message, "Lỗi",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
    }
}
