namespace SinglarWebinar
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Signalr : DbContext
    {
        public Signalr()
            : base("name=Signalr")
        {
        }

        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
