using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarElFathElEslamy.Academy.Domain.Models
{
    class UserCourses
    {
        public long userId { get; set; }

        public User User { get; set; }

        public CourseType CourseType { get; set; }
    }
}
