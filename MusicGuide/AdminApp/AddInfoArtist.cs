using MusicGuide.Models;
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
    public partial class AddInfoArtist : Form
    {
        internal Storage store;
        ListBox listbox;
        public AddInfoArtist(ref Storage store, ref ListBox listbox)
        {
            this.listbox = listbox;
            this.store = store;
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void AddInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Year = textBox2.Text;
            string Genre = textBox3.Text;
            Artist artist = new Artist(Name,Year,Genre);
            store.AddNewArtist(artist);
            store.Save();
            listbox.Items.Add(Name);
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
