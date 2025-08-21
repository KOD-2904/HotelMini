using MiniHotel.BLL;
using MiniHotel.Models;
using MiniHotel.Models.Responses;
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
        private readonly UserService _userService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService();
            _userService = new UserService();
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
            LoginResult result = _authService.Login(txtUsername.Text, txtPassword.Text);

            if (result.Success)
            {
                // Login thành công
                MessageBox.Show($"Chào {result.User.FullName}, đăng nhập thành công!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                
            }
            else
            {
                // Login thất bại, hiển thị message
                MessageBox.Show(result.Message);
            }

            //string password = "123";
            //string username = "trong";
            //string fullname = "Trần Trọng Thịnh";
            //int role = 1;
            //string phone = "0338515037";
            //string email = "ttthinh2904@gmail.com";
            //User user = new User
            //{
            //    Username = username,
            //    FullName = fullname,
            //    Email = email,
            //    Phone = phone,
            //    PasswordHash = password,
            //    Role = role
            //};

            //var createUserResult = _userService.creatUser(user);
            //if (createUserResult.Success)
            //{
            //    MessageBox.Show($"Chào {fullname}, đăng nhập thành công!", createUserResult.Message, MessageBoxButtons.OK, MessageBoxIcon.None);
            //    MainForm mainForm = new MainForm();
            //    mainForm.Show();
            //}
            //else
            //{
            //    MessageBox.Show($"{createUserResult.Message}");
            //}


        }
    }
}
