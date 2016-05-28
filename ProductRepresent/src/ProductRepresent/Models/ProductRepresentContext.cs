using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Data.Entity;

namespace ProductRepresent.Models
{
    public class ProductRepresentContext : DbContext
    {
        #region DBSet
        public virtual DbSet<PR0100> PR0100s { get; set; }
        public virtual DbSet<PR0200> PR0200s { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PR0100>(ConfigurePR0100);
        }

        private static void ConfigurePR0100(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PR0100>(b =>
            {
                //b.Key(c => c.TeamId);
                //b.Property(e => e.Version)
                //    .ValueGeneratedOnAddOrUpdate()
                //    .ConcurrencyToken();
            });
        }

    }
}
