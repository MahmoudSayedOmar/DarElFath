using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarElFathElEslamy.Academy.Domain
{
    public interface IRepository<T>
    {
        IUnitOfWork UOF { get; }
        IQueryable<T> GetAll();

        T Add(T item);

        void Modify(T item);
        void Remove(T item);
    }
}
