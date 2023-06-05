using DataAccessLayer.Models;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Repositories.InterfaceRepositories;

namespace DataAccessLayer.Repositories
{
    public class CountryRepository : IEntityRepository<Country>
    {
        private readonly DbSet<Country> _countries;

        public CountryRepository(TimetableContext context)
        {
            _countries = context.Set<Country>();
        }

        public void Add(Country entity)
        {
            _countries.Add(entity);
        }

        public void Delete(Country entity)
        {
            _countries.Remove(entity);
        }

        public IEnumerable<Country> GetAll()
        {
            return _countries.ToList();
        }

        public Country? GetById(int id)
        {
            return _countries.Find(id);
        }

        public void Update(Country entity)
        {
            _countries.Update(entity);
        }
    }
}
