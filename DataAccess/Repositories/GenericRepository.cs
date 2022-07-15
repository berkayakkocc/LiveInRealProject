using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        public void Add(T entity)
        {
            using Context db = new Context();
            db.Add(entity);
            db.SaveChanges();
        }

        public void Delete(T entity)
        {
            using Context db = new Context();
            db.Remove(entity);
            db.SaveChanges();
        }
        public void Update(T entity)
        {
            using Context db = new Context();
            db.Update(entity);
            db.SaveChanges();        }
        public T GetById(int id)
        {
            using Context db = new Context();
            return db.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using Context db = new Context();
            return db.Set<T>().ToList();
        }

       
    }
}
