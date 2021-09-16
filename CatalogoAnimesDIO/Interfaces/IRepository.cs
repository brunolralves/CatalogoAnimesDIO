using System.Collections.Generic;

namespace CatalogoAnimesDIO.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T GetByID(int id);

        void Insert(T entity);

        void Delete(int id);

        void Update(int id, T entity);

        int NextId();

    }
}
