using global_kinetics_domain;
using System.Collections.Generic;

namespace global_kinetic_persistence
{
    public interface IRepository<T> where T: Domain
    {
        IList<T> GetAll();
        void Add(T entity);
        void DeleteAll();
    }
}
