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
            Form AddInfo = new AddInfo(ref store,ref listBox1);

            AddInfo.Left = this.Left;
            AddInfo.Top = this.Top;
            AddInfo.Show();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Select");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string selected = listBox1.SelectedItem.ToString();
            foreach(Artist element in store.artists)
            {
                if(element.Name == selected)
                {
                    MessageBox.Show("Name: " + element.Name +
                        "\n"+"Genre: "+ element.Genre +
                        "\n" + "Year: " + element.Year +
                        "\n" + "Link: " + element.Link);
                    break;
                }
            }
            
        }
    }
}
