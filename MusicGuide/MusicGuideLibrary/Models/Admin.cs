﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGuide.MusicGuideLibrary.Models
{
    [Serializable]
    class Admin : User
    {
        public Admin(string login, string password) : base(login, password){ }
    }
}
