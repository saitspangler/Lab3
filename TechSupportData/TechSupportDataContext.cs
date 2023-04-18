using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.IdentityModel.Protocols;

namespace TechSupportData
{
    public partial class TechSupportDataContext : DbContext
    {
        public TechSupportDataContext()
        {
        }

        public TechSupportDataContext(DbContextOptions<TechSupportDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               //optionsBuilder.UseSqlServer("Data Source=localhost\\sqlexpress;Initial Catalog=MMABooks;Integrated Security=True");
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["TechSupport"].
                    ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductCode).IsFixedLength();
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
