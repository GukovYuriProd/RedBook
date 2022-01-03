using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RedBook.Model
{
    public class DBBinContext: DbContext
    {
        public DBBinContext(): base("DBConnection") {

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Discipline> Discipline { get; set; }
        public DbSet<Marks> Marks { get; set; }
        public DbSet<Class> Classe { get; set; }
        public DbSet<WorkType> WorkType { get; set; }
    }
}
