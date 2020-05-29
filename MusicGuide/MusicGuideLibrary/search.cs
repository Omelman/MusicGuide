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

namespace MusicGuide.MusicGuideLibrary
{
    public partial class Search : Form
    {
        internal Storage store;
        public Search(ref Storage store)
        {
            this.store = store;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (textBox1.Text == "") MessageBox.Show("Please, enter your request");else
            if ((radioButton2.Checked != true) && (radioButton1.Checked != true)) MessageBox.Show("Please, choose parametr");
            else
            {
                string searched = textBox1.Text;
                bool check = false;
                if (radioButton1.Checked)
                {
                    foreach (Artist artist in store.artists)
                    {
                        foreach (Album album in artist.albums)
                        {
                            foreach (Song song in album.songs)
                            {
                                if (searched == song.Name)
                                {
                                    var item1 = new ListViewItem(new[] { song.Name, artist.Name, album.Name });
                                    listView1.Items.Add(item1);
                                    check = true;
                                }
                            }
                        }
                    }
                }

                if (radioButton2.Checked)
                {
                    foreach (Artist artist in store.artists)
                    {
                        if (searched == artist.Name)
                        {
                            foreach (Album album in artist.albums)
                            {
                                foreach (Song song in album.songs)
                                {
                                    var item1 = new ListViewItem(new[] { song.Name, artist.Name, album.Name });
                                    listView1.Items.Add(item1);
                                    check = true;
                                }
                            }
                        }
                    }
                }
                if (check == false) MessageBox.Show("Not found");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}
