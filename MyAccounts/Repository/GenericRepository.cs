using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MyAccounts.Models.Entity;

namespace MyAccounts.Repository
{
    /// <summary>
    /// 泛型的 Repository (提供各Repository繼承使用)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericRepository<T> 
        where T : class
    {
        private Money _context;


        private DbSet<T> table = null;

        public GenericRepository()
        {

        }

        public GenericRepository(Money context)
        {
            this._context = context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> SelectAll()
        {
            return table.ToList();
        }

        public T SelectById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
    }
}
