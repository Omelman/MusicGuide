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
    public partial class UsersInfo : Form
    {
        internal Storage store;
        public UsersInfo(ref Storage store)
        {
            this.store = store;
            InitializeComponent();
            foreach(User user in store.users)
            {
                var item1 = new ListViewItem(new[] { user.Login, user.Password });
                listView1.Items.Add(item1);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
