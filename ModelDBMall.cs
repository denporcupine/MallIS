using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MallIS
{
    public partial class ModelDBMall : DbContext
    {
        public ModelDBMall()
            : base("name=ModelDBMall")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Mall> Malls { get; set; }
        public virtual DbSet<Pavilion> Pavilions { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<Renter> Renters { get; set; }
        public virtual DbSet<sysdiagram> Sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mall>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Mall>()
                .HasMany(e => e.Pavilions)
                .WithRequired(e => e.Mall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mall>()
                .HasMany(e => e.Rents)
                .WithRequired(e => e.Mall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pavilion>()
                .HasMany(e => e.Rents)
                .WithRequired(e => e.Pavilion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Renter>()
                .HasMany(e => e.Rents)
                .WithRequired(e => e.Renter)
                .WillCascadeOnDelete(false);
        }
    }
}
