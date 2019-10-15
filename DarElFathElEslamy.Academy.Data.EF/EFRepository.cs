using DarElFathElEslamy.Academy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DarElFathElEslamy.Academy.Data.EF
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        private readonly EFUnitOfWork _uof;
        public EFRepository(EFUnitOfWork uof)
        {
            _uof = uof;
        }
        public IUnitOfWork UOF => _uof;

        public T Add(T item)
        {
            return _uof.Set<T>().Add(item);
        }
        public IQueryable<T> GetAll()
        {
            return _uof.Set<T>();
        }

        public void Modify(T item)
        {
            _uof.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(T item)
        {
            _uof.Entry(item).State = System.Data.Entity.EntityState.Deleted;
        }
    }
}
