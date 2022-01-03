using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBook.Model
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }

        public ICollection<Marks> MarksOfThisDisc { get; set; }
        public ICollection<Teachers> TeachersOnThisDisc { get; set; }
        public ICollection<Class> ClassesOfThisDisc { get; set; }
        public Discipline()
        {
            MarksOfThisDisc = new List<Marks>();
            TeachersOnThisDisc = new List<Teachers>();
            ClassesOfThisDisc = new List<Class>();
        }
    }
}
