using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarElFathElEslamy.Academy.Domain.Models
{
    public enum Gender
    {
        male, female
    }
    public class User : Entity<long>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public Gender Gender { set; get; }
        
    }
}
