using NextSoft.Domain.Entitites;
using System.Collections.Generic;

namespace NextSoft.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(int id);

        T Select(int id);

        IList<T> SelectAll();
    }
}
