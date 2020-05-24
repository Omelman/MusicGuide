using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGuide.Models
{
    //basic info class
    [Serializable]
    public abstract class Info
    {
        public string Name { private set; get; }
        //
        public string Year { private set; get; }
        //
        public string Genre { private set; get; }
        //
        public string Link { private set; get; }

        public Info(string name = "", string year = "", string genre = "", string link = "")
        {
            this.Name = name;
            this.Year = year;
            this.Genre = genre;
            this.Link = link;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Year : " + Year);
            Console.WriteLine("Genre : " + Genre);
            Console.WriteLine("Link : " + Link);
        }
    }
}
