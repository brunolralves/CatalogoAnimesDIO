using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoAnimesDIO.Interfaces
{
    interface IRepository<T>
    {
        List<T> List();
        T GetByID(int id);

        void Insert(T entity);

        void Delete(int id);

        void Update(int id, T entity);

        int NextId();

    }
}
