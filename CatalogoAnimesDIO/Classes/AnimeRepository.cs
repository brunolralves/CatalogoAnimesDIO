using CatalogoAnimesDIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoAnimesDIO.Classes
{
    public class AnimeRepository : IRepository<Anime>
    {

        private List<Anime> listAnimes = new List<Anime>();

        public void Delete(int id)
        {
            listAnimes[id].Delete();
        }

        public Anime GetByID(int id)
        {
            return listAnimes[id] ;
        }

        public void Insert(Anime anime)
        {
            listAnimes.Add(anime);
        }

        public List<Anime> List()
        {
            return listAnimes;
        }

        public int NextId()
        {
            return listAnimes.Count;
        }

        public void Update(int id, Anime anime)
        {
            listAnimes[id] = anime;
        }
    }
}
