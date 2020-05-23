using MusicGuide.MusicGuideLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MusicGuide.MusicGuideLibrary.DAL
{
    class Dao
    {
        Storage store;
        const string filePath = "store.bin";

        public Dao(Storage store)
        {
            this.store = store;
        }

        public void Save()
        {
            using (Stream stream = File.Create(filePath))
            {
                var serializer = new BinaryFormatter();
                serializer.Serialize(stream, store);
            }
        }

        public void Load()
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                var serializer = new BinaryFormatter();
                Storage st = (Storage)serializer.Deserialize(stream);

                Copy(st.artists, store.artists);
                Copy(st.users, store.users);
            }


            void Copy<T>(List<T> from, List<T> to)
            {
                to.Clear();
                to.AddRange(from);
            }
        }
    }
}
