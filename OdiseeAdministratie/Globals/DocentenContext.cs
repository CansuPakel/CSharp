using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals
{
    public class DocentenContext : DbContext
    {
        public DbSet<Docent> Docenten {get; set;}
        public DbSet Type { get; set; }

    }
}
