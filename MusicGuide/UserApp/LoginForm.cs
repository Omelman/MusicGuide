using MusicGuide.AdminApp;
using MusicGuide.MusicGuideLibrary.Models;
using MusicGuide.UserApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicGuide
{
    public partial class LoginForm : Form
    {
        internal Storage store;
        public LoginForm()
        {
            InitializeComponent();
            store = new Storage();
            store.Load();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = SingInLogin.Text;
            string password = SingInPassword.Text;
            if (string.IsNullOrWhiteSpace(SingInLogin.Text) || string.IsNullOrWhiteSpace(SingInPassword.Text))
            {
                if (string.IsNullOrWhiteSpace(SingInLogin.Text))
                {
                    SingInLogin.BackColor = Color.MediumSeaGreen;
                }
                if (string.IsNullOrWhiteSpace(SingInPassword.Text))
                {

                    SingInPassword.BackColor = Color.MediumSeaGreen;
                }
                MessageBox.Show("Fill in the blank space, please");
                SingInLogin.BackColor = Color.White;
                SingInPassword.BackColor = Color.White;
            }
            else if (SingInLogin.Text.Length <= 4 || SingInLogin.Text.Length >= 10)
            {
                SingInLogin.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Name has inappropriate length, try again");
                SingInLogin.BackColor = Color.White;
                SingInLogin.Text = string.Empty;
            }
            else if (SingInPassword.Text.Length < 2 || SingInPassword.Text.Length >= 10)

            {
                SingInPassword.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Password has inappropriate length, try again");
                SingInPassword.BackColor = Color.White;
                SingInPassword.Text = string.Empty;
            }
            else
            {

                string nickname;
                int number;
                int pass;
                bool isInt = int.TryParse(SingInPassword.Text, out number);
                bool isIntName = int.TryParse(SingInLogin.Text, out number);
                // Данные с полей
                if (isIntName == true || isInt == false)
                {
                    if (isIntName == true)
                    {

                        SingInLogin.BackColor = Color.MediumSeaGreen;
                        MessageBox.Show("Name consists only of numbers, try again");
                        SingInLogin.Text = string.Empty;
                        SingInLogin.BackColor = Color.White;
                    }
                    else
                    {
                        nickname = SingInLogin.Text;
                    }
                    if (isInt == false)
                    {

                        SingInPassword.BackColor = Color.MediumSeaGreen;
                        MessageBox.Show("Password consists not only of numbers, try again");
                        SingInPassword.Text = string.Empty;
                        SingInPassword.BackColor = Color.White;
                    }
                    else
                    {
                        pass = Convert.ToInt32(SingInPassword.Text);
                    }
                }
                else
                {
                    nickname = SingInLogin.Text;
                    if (store.users.FirstOrDefault(u => u.Login == name && u.Password == password) != null)
                    {
                        MessageBox.Show($"Hello, Dear {name}! We wish you to have a nice day)");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, such Customer doesn`t exist...Try again or sign up !");
                    }

                }
            }
        }

        private void Sing_up(object sender, EventArgs e)
        {
            Form SingUp = new SingUp(ref store);

            SingUp.Left = this.Left;
            SingUp.Top = this.Top;
            SingUp.Show();
            this.Hide();
        }

        private void Login_as_Admin(object sender, EventArgs e)
        {
            Form LoginFormAdmin = new LoginFormAdmin(ref store);

            LoginFormAdmin.Left = this.Left;
            LoginFormAdmin.Top = this.Top;
            LoginFormAdmin.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AutPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
