using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBook.Model
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Class LeaarningClass { get; set; }
        public ICollection<Marks> Marks { get; set; }
        public Students()
        {
            Marks = new List<Marks>();
        }
    }
}
