using System.Collections.Generic;

namespace NorthWind.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> Paging();
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);

    }
}
