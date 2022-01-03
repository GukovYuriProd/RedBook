using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBook.Model
{
    public class WorkType
    {
        public int Id { get; set; }
        public string ClassOfWork { get; set; }

        public ICollection<Marks> Marks { get; set; }
        public WorkType()
        {
            Marks = new List<Marks>();
        }
    }
}
