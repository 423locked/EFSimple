using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFSimple
{
    class AppContext : DbContext
    {
        public AppContext() : base("DbConnection") { }

        public DbSet<Cat> Cats { get; set; }
    }
}
