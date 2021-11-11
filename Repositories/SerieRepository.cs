using System.Collections.Generic;
using DIO.Series.Entities;
using DIO.Series.Interfaces;

namespace DIO.Series.Repositories
{
    public class SerieRepository : RepositoryInterface<SerieEntity>
    {
        private List<SerieEntity> listSeries = new List<SerieEntity>();
        public void delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public SerieEntity findById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void insert(SerieEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<SerieEntity> list()
        {
            throw new System.NotImplementedException();
        }

        public int nextId()
        {
            throw new System.NotImplementedException();
        }

        public void update(int id, SerieEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}