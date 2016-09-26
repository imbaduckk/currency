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
        public Context() : base("DBRates4")
        {

        }
        public DbSet<Rate> Rates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rate>().Property(p => p.Value)
                .HasPrecision(6,4);
            modelBuilder.Entity<Rate>().HasKey(t => new { t.Date, t.FromCurrency, t.ToCurrency });
           
        }
    }
}
