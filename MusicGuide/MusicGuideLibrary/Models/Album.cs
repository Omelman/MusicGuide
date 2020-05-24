using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGuide.Models
{
    //class for albums
    [Serializable]
    public class Album : Info
    {
        public List<Song> songs = new List<Song>();
        public Album(string name = "", string year = "", string genre = "", string link = "") : base(name, year, genre, link) {}
       
        public void AddNewSong(Song song)
        {
            songs.Add(song);
        }

        public void DeleteSong(string name)
        {
            if (songs.Count == 0) Console.WriteLine("Empty");
            else
            {
                foreach (Song element in songs)
                {
                    if (element.Name == name) { songs.Remove(element); break; }
                }
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Number of songs in album : " + songs.Count);
            if (songs.Count == 0) Console.WriteLine("Empty");
            else
            {
                Console.WriteLine("List of songs : ");
                foreach (Song element in songs)
                {
                    Console.WriteLine(element.Name);
                }
            }
        }
    }
}
