using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Brewr.Models.Mash
{
    public class MashContext : DbContext
    {
        public MashContext()
            : base("Brewr")
        {
        }
        public DbSet<Mash> Mashes {get; set;}
    }
}