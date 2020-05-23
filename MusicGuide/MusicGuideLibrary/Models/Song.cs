using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGuide.Models
{
    //class song
    [Serializable]
    public class Song : Info
    {
        public Song(string name = "", int year = 0, string genre = "", string link = "") : base(name, year, genre, link) {}
    }

}
