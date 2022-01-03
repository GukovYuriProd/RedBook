using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBook.Model
{
    public class Class
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public char Letter { get; set; }

        public ICollection<Teachers> TeachersInClass { get; set; }
        public ICollection<Discipline> DisciplinesInClass { get; set; }
        public ICollection<Students> StudentsInClass { get; set; }
        public Class()
        {
            TeachersInClass = new List<Teachers>();
            DisciplinesInClass = new List<Discipline>();
            StudentsInClass = new List<Students>();
        }
    }
}
