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
            listSeries[id].Delete();
        }

        public SerieEntity findById(int id)
        {
            return listSeries[id];
        }

        public void insert(SerieEntity entity)
        {
            listSeries.Add(entity);
        }

        public List<SerieEntity> list()
        {
            return listSeries;
        }

        public int nextId()
        {
            return listSeries.Count;
        }

        public void update(int id, SerieEntity entity)
        {
            listSeries[id] = entity;
        }
    }
}