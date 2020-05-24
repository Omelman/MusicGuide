using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGuide.Models
{
    [Serializable]
    public class Artist : Info
    {
        public List<Album> albums = new List<Album>();
        public Artist(string name = "", string year = "", string genre = "", string link = "") : base(name, year, genre, link){}

        public void AddNewAlbum(Album album)
        {
            albums.Add(album);
        }

        public void DeleteAlbum(string name)
        {
            if (albums.Count == 0) Console.WriteLine("Empty");
            else
            {
                foreach (Album element in albums)
                {
                    if (element.Name == name) { albums.Remove(element); break; }
                }
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Number of artist albums : " + albums.Count);
            if (albums.Count == 0) Console.WriteLine("Empty");
            else
            {
                Console.WriteLine("List of albums : ");
                foreach (Album element in albums)
                {
                    Console.WriteLine(element.Name);
                }
            }
        }
    }
}
