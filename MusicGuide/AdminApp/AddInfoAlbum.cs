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
    public partial class AddInfoAlbum : Form
    {
        internal Storage store;
        Artist artist;
        ListBox listbox;
        public AddInfoAlbum(ref Storage store, ref ListBox listbox, ref Artist artist )
        {
            this.artist = artist;
            this.listbox = listbox;
            this.store = store;
            InitializeComponent();
        }

        private void AddInfoAlbum_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Year = textBox2.Text;
            string Genre = textBox3.Text;
            string Link = textBox4.Text;
            Album album = new Album(Name, Year, Genre, Link);
            artist.AddNewAlbum(album);
            store.Save();
            listbox.Items.Add(Name);
            this.Hide();
        }
    }
}
