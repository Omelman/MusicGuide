using MusicGuide.MusicGuideLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicGuide.UserApp
{
    public partial class SingUp : Form
    {
        internal Storage store;

        public SingUp(ref Storage store)
        {
            this.store = store;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SingUp_Load(object sender, EventArgs e)
        {

        }

        private void AutPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SingUpLogin.Text) || string.IsNullOrWhiteSpace(SingUpPassword.Text))
            {
                if (string.IsNullOrWhiteSpace(SingUpLogin.Text))
                {
                    SingUpLogin.BackColor = Color.MediumSeaGreen;
                }
                if (string.IsNullOrWhiteSpace(SingUpPassword.Text))
                {

                    SingUpPassword.BackColor = Color.MediumSeaGreen;
                }
                MessageBox.Show("Fill in the blank space, please");
                SingUpLogin.BackColor = Color.White;
                SingUpPassword.BackColor = Color.White;
            }
            else if (SingUpLogin.Text.Length < 2 || SingUpPassword.Text.Length >= 10)
            {
                SingUpLogin.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Name has inappropriate length, try again");
                SingUpLogin.BackColor = Color.White;
                SingUpLogin.Text = string.Empty;
            }
            else if (SingUpPassword.Text.Length < 2 || SingUpPassword.Text.Length >= 10)
            {
                SingUpPassword.BackColor = Color.MediumSeaGreen;
                MessageBox.Show("Password has inappropriate length, try again");
                SingUpPassword.BackColor = Color.White;
                SingUpPassword.Text = string.Empty;
            }
            else
            {

                string nickname;
                int number;
                int password;
                bool isInt = int.TryParse(SingUpPassword.Text, out number);
                bool isIntName = int.TryParse(SingUpLogin.Text, out number);
                // Данные с полей
                if (isIntName == true || isInt == false)
                {
                    if (isIntName == true)
                    {

                        SingUpLogin.BackColor = Color.MediumSeaGreen;
                        MessageBox.Show("Name consists only of numbers, try again");
                        SingUpLogin.Text = string.Empty;
                        SingUpLogin.BackColor = Color.White;
                    }
                    else
                    {
                        nickname = SingUpLogin.Text;
                    }
                    if (isInt == false)
                    {

                        SingUpPassword.BackColor = Color.MediumSeaGreen;
                        MessageBox.Show("Password consists not only of numbers, try again");
                        SingUpPassword.Text = string.Empty;
                        SingUpPassword.BackColor = Color.White;
                    }
                    else
                    {
                        password = Convert.ToInt32(SingUpPassword.Text);
                    }
                }
                else
                {
                    // Берем введенные данные с полей
                    string name = SingUpLogin.Text;
                    string pass = SingUpPassword.Text;
                    // Проверяем, есть ли в считанном ранее списке пользователь с таким ником и паролем
                    // Это LINQ выражение, которое сверяет данные каждого из элементов списка (u) с введенными данными
                    if (store.users.FirstOrDefault(u => u.Login == name || u.Password == pass) == null)
                    {
                        User user = new User(name, pass);
                        store.AddNewUser(user);
                        MessageBox.Show("We are glad to hear you joined us!");
                        store.Save();
                        Form Menu = new MenuUser(ref store);
                        Menu.Left = this.Left;
                        Menu.Top = this.Top;
                        Menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, such buyer already exists in our app(");
                        SingUpLogin.Text = string.Empty;
                        SingUpPassword.Text = string.Empty;
                    }
                }
            }
        }

        private void SingUpLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
