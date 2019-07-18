using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using Globals;

namespace Datalayer
{
    public class DocentenContext : DbContext
    {
        public DocentenContext() :base("OdiseeAdministratie")
        {
         
        }
        public DbSet<Docent> Docents {get; set;}
        public DbSet<OLA> OLAs { get; set; }
        public DbSet<OPO> OPOes { get; set; }

        
    }
}
