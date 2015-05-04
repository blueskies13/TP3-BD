using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_Partie1_EntityFramework.Model;

namespace TP3_Partie1_EntityFramework
{
    public interface IEntityRepository<T> where T : Entity
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Delete(T Entity);
        void Add(T Entity);
        void Update(T Entity);
        void DeleteAll();
    }
}
