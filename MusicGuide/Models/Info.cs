using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGuide.Models
{
    //basic info class
    abstract class Info
    {
        public string Name { private set; get; }
        //
        public int Year { private set; get; }
        //
        public string Genre { private set; get; }
        //
        public string Link { private set; get; }

        public Info(string name = "", int year = 0, string genre = "", string link = "")
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
