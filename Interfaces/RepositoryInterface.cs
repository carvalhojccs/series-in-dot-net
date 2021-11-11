using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface RepositoryInterface<T>
    {
         List<T> list();
         T findById(int id);
         void insert(T entity);
        void delete(int id);
        void update(int id, T entity);
        int nextId();         
    }
}