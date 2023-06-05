using DataAccessLayer.Repositories.InterfaceRepositories;
using DataAccessLayer.Context;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
    public class PlaneRepository : IEntityRepository<Plane>
    {
        private readonly DbSet<Plane> _planes;
        public PlaneRepository(TimetableContext context)
        {
            _planes = context.Set<Plane>();
        }
        public void Add(Plane entity)
        {
            _planes.Add(entity);
        }

        public void Delete(Plane entity)
        {
            _planes.Remove(entity);
        }

        public IEnumerable<Plane> GetAll()
        {
            return _planes.ToList();
        }

        public Plane? GetById(int id)
        {
            return _planes.Find(id);
        }

        public void Update(Plane entity)
        {
            _planes.Update(entity); 
        }
    }
}
