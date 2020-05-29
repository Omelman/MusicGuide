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
    public partial class AddInfoSong : Form
    {
        internal Storage store;
        Album album;
        ListBox listbox;
        public AddInfoSong(ref Storage store, ref ListBox listbox, ref Album album)
        {
            this.album = album;
            this.listbox = listbox;
            this.store = store;
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
            Song song = new Song(Name, Year, Genre);
            album.AddNewSong(song);
            store.Save();
            listbox.Items.Add(Name);
            this.Hide();
        }

        private void AddInfoSong_Load(object sender, EventArgs e)
        {

        }
    }
}
