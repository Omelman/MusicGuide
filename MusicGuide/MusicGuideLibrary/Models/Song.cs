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
        public Song(string name = "", string year = "", string genre = "", string link = "") : base(name, year, genre, link) {}
    }

}
