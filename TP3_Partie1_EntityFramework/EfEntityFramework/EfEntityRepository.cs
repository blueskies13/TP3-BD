using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Partie1_EntityFramework.Model;

namespace TP3_Partie1_EntityFramework.EfEntityFramework
{
    public class EfEntityRepository<T> : IEntityRepository<T> where T : Entity
    {
        private readonly DbContext _context;
        public EfEntityRepository()
        {
            _context = new TutoringDbContext();
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

        public void Update(T Entity) 
        {
            _context.Set<T>().Attach(Entity);
            _context.Entry(Entity);
        }

        public void Add(T Entity)
        {
            _context.Set<T>().Add(Entity);
            _context.SaveChanges();
        }

        public void Delete(T Entity)
        {
            _context.Set<T>().Remove(Entity);
            _context.SaveChanges();
        }

        public void DeleteAll()
        {
            _context.Set<T>().RemoveRange(_context.Set<T>());
            _context.SaveChanges();
        }

        public T GetById(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        internal void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
