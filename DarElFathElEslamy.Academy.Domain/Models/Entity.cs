using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarElFathElEslamy.Academy.Domain.Models
{
    public abstract class Entity<TKey>
    {
        public TKey Id { set; get; }
    }
}
