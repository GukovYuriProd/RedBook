using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBook.Model
{
    public class Marks
    {
        public int Id { get; set; } 
        public DateTime ReceivingTime { get; set; }

        public Discipline Discipline { get; set; }
        public Students Students { get; set; }
        public WorkType WorkType { get; set; }

    }
}
