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

namespace MusicGuide.AdminApp
{
    public partial class LoginFormAdmin : Form
    {
        internal Storage store;
        public LoginFormAdmin(ref Storage store)
        {
            this.store = store;
            InitializeComponent();
        }

        private void Login_As_User(object sender, EventArgs e)
        {
            Form userautor = Application.OpenForms[0];
            userautor.Left = this.Left;
            userautor.Top = this.Top;
            userautor.Show();
            this.Hide();
        }

        private void LoginFormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
