using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBook.Model
{
    public class Teachers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<Class> ClassesOfTeacher { get; set; } 
        public ICollection<Discipline> DisciplinesOfTeacher { get; set; }
        public Teachers()
        {
            ClassesOfTeacher = new List<Class>();
            DisciplinesOfTeacher = new List<Discipline>();
        }
    }
}
