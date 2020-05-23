using MusicGuide.Models;
using MusicGuide.MusicGuideLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGuide.MusicGuideLibrary.Models
{
    [Serializable]
    public class Storage
    {
        public List<Artist> artists = new List<Artist>();
        public List<User> users = new List<User>();

        public void AddNewArtist(Artist artist)
        {
            artists.Add(artist);
        }
        public void AddNewUser(User user)
        {
            users.Add(user);
        }
        public void Save()
        {
            new Dao(this).Save();
        }

        public void Load()
        {
            new Dao(this).Load();
        }
    }
}
