using MusicGuide.Models;
using MusicGuide.MusicGuideLibrary;
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
            listBox3.Items.Clear();
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
                        "\n" + "Year: " + element.Year);
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
                        store.DeleteArtist(element.Name);
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
            //reload
            listBox3.Items.Clear();
            //albums mode
            if (listBox2.SelectedItem != null&& listBox1.SelectedItem != null)
            {
                string selected1 = listBox1.SelectedItem.ToString();
                string selected2 = listBox2.SelectedItem.ToString();

                Album album = new Album();
                foreach (Artist element1 in store.artists)
                {
                    if (element1.Name == selected1)
                    {
                        foreach (Album element2 in element1.albums)
                        {
                            if(element2.Name == selected2)
                            {
                                album = element2;
                                break;
                            }
                        }
                            break;
                    }
                }
                //fill box 3
                foreach (Song element in album.songs)
                {
                    listBox3.Items.Add(element.Name);
                }
            }
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
                listBox2.Items.Remove(listBox2.SelectedItem);
                listBox2.ClearSelected();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null|| listBox1.SelectedItem == null) MessageBox.Show("Please, select album");
            else
            {
                string selected1 = listBox1.SelectedItem.ToString();
                string selected2 = listBox2.SelectedItem.ToString();
                Album album = new Album();
                foreach (Artist element in store.artists)
                {
                    if (element.Name == selected1)
                    {
                        foreach (Album element2 in element.albums)
                        {
                            if (element2.Name == selected2)
                            {
                                album = element2;
                                break;
                            }
                        }

                        break;
                    }
                }
                Form AddInfo = new AddInfoSong(ref store, ref listBox3, ref album);

                AddInfo.Left = this.Left;
                AddInfo.Top = this.Top;
                AddInfo.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null || listBox1.SelectedItem == null || listBox3.SelectedItem == null) MessageBox.Show("Please, select artist,album and song");
            else
            {
                string selected1 = listBox1.SelectedItem.ToString();
                string selected2 = listBox2.SelectedItem.ToString();
                string selected3 = listBox3.SelectedItem.ToString();

                foreach (Artist element in store.artists)
                {
                    if (element.Name == selected1)
                    {
                        foreach (Album element2 in element.albums)
                        {
                            if (element2.Name == selected2)
                            {
                                foreach (Song element3 in element2.songs)
                                {
                                    if (element3.Name == selected3)
                                    {
                                        element2.DeleteSong(element3.Name);
                                        store.Save();
                                        break;
                                    }
                                }
                                break;
                            }
                        }

                        break;
                    }
                }
                listBox3.Items.Remove(listBox3.SelectedItem);
                listBox3.ClearSelected();
            }
        }

        private void User_Button(object sender, EventArgs e)
        {
            Form user = new UsersInfo(ref store);

            user.Left = this.Left;
            user.Top = this.Top;
            user.Show();
        }

        private void Search_Button(object sender, EventArgs e)
        {
            Form search = new Search(ref store);

            search.Left = this.Left;
            search.Top = this.Top;
            search.Show();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null) MessageBox.Show("Please, select album");
            else
            {
                string selected1 = listBox1.SelectedItem.ToString();
                string selected2 = listBox2.SelectedItem.ToString();

                foreach (Artist element1 in store.artists)
                {
                   if(selected1 == element1.Name)
                        foreach (Album element2 in element1.albums)
                        {
                            if (element2.Name == selected2)
                            {
                                MessageBox.Show("Name: " + element2.Name +
                                                        "\n" + "Genre: " + element2.Genre +
                                                        "\n" + "Year: " + element2.Year);
                                break;
                            }
                        }
                   
              
                }
            }
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem == null) MessageBox.Show("Please, select song");
            else
            {
                string selected1 = listBox1.SelectedItem.ToString();
                string selected2 = listBox2.SelectedItem.ToString();
                string selected3 = listBox3.SelectedItem.ToString();

                foreach (Artist element1 in store.artists)
                {
                    if (selected1 == element1.Name)
                        foreach (Album element2 in element1.albums)
                        {
                            if (element2.Name == selected2)
                                foreach (Song element3 in element2.songs)
                                {
                                    if (element3.Name == selected3) { 
                                    MessageBox.Show("Name: " + element3.Name +
                                                            "\n" + "Genre: " + element3.Genre +
                                                            "\n" + "Year: " + element3.Year );
                                    break;
                                }
                                }
                        }


                }
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
          
        }

        private void MenuAdmin_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }

        private void MenuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            store.Save();
            MessageBox.Show("Done");
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            store.Load();
            MessageBox.Show("Done");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
          "To get help click help",
          "Help",
          MessageBoxButtons.OK,
          MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button1,
          0,
          "https://github.com/Omelman/MusicGuide");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
