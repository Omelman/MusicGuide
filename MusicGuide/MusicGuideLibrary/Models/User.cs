using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGuide.MusicGuideLibrary.Models
{
    [Serializable]
    public abstract class User
    {
        public string Login { set; get; }
        public string Password { set; get; }
    }
}
