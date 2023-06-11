using DataAccessLayer.Repositories.InterfaceRepositories;
using DataAccessLayer.Context;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly DbSet<City> _cities;
        public CityRepository(TimetableContext context)
        {
            _cities = context.Set<City>();
        }

        public void Add(City entity)
        {
            _cities.Add(entity);
        }

        public void Delete(City entity)
        {
            _cities?.Remove(entity);
        }

        public IEnumerable<City> GetAll()
        {
            return _cities.ToList();
        }

        public City? GetById(int id)
        {
            return _cities.Find(id);
        }

        public void Update(City entity)
        {
            _cities.Update(entity);
        }
    }
}
