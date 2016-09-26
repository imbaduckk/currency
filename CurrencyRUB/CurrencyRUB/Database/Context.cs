using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyRUB
{
    class Context:DbContext
    {
        public Context() : base("Rates")
        {

        }
        public DbSet<Rate> Rates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rate>().Property(p => p.Value)
                .HasPrecision(3,4);
        }
    }
}
