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
    public partial class MenuAdmin : Form
    {
        internal Storage store;
        public MenuAdmin(ref Storage store)
        {
            this.store = store;

            InitializeComponent();
            //fill artistlist
            foreach (Artist element in store.artists)
            {
                listBox1.Items.Add(element.Name);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form AddInfo = new AddInfoArtist(ref store,ref listBox1);

            AddInfo.Left = this.Left;
            AddInfo.Top = this.Top;
            AddInfo.Show();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Select");

            //reload
            listBox2.Items.Clear();
            //albums mode
            if (listBox1.SelectedItem != null)
            {
                string selected = listBox1.SelectedItem.ToString();
                Artist artist = new Artist();
                foreach (Artist element in store.artists)
                {
                    if (element.Name == selected)
                    {
                        artist = element;
                        break;
                    }
                }
                //fill box 2
                foreach (Album element in artist.albums)
                {
                    listBox2.Items.Add(element.Name);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) MessageBox.Show("Please, select artist"); else { 
            string selected = listBox1.SelectedItem.ToString();
            foreach (Artist element in store.artists)
            {
                if (element.Name == selected)
                {
                    MessageBox.Show("Name: " + element.Name +
                        "\n" + "Genre: " + element.Genre +
                        "\n" + "Year: " + element.Year +
                        "\n" + "Link: " + element.Link);
                    break;
                }
            }
        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) MessageBox.Show("Please, select artist");
            else
            {
                string selected = listBox1.SelectedItem.ToString();
                foreach (Artist element in store.artists)
                {
                    if (element.Name == selected)
                    {
                        store.artists.Remove(element);
                        store.Save();
                        break;
                    }
                }
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.ClearSelected();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) MessageBox.Show("Please, select artist");
            else
            {
                string selected = listBox1.SelectedItem.ToString();
                Artist artist = new Artist();
                foreach (Artist element in store.artists)
                {
                    if (element.Name == selected)
                    {
                        artist = element;
                        break;
                    }
                }
                Form AddInfo = new AddInfoAlbum(ref store, ref listBox2, ref artist);

                AddInfo.Left = this.Left;
                AddInfo.Top = this.Top;
                AddInfo.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null||listBox1.SelectedItem == null) MessageBox.Show("Please, select artist and album");
            else
            {
                string selected1 = listBox1.SelectedItem.ToString();
                string selected2 = listBox2.SelectedItem.ToString();

                foreach (Artist element in store.artists)
                {
                    if (element.Name == selected1)
                    {
                        foreach (Album element2 in element.albums)
                        {
                            if (element2.Name == selected2)
                            {
                                element.DeleteAlbum(element2.Name);
                                store.Save();
                                break;
                            }
                        }

                       break;
                    }
                }
                listBox1.Items.Remove(listBox2.SelectedItem);
                listBox1.ClearSelected();
            }
        }
    }
}
