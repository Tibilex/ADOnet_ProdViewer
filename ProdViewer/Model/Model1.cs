using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProdViewer
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<tabletest> tabletests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tabletest>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tabletest>()
                .Property(e => e.Info)
                .IsUnicode(false);

            modelBuilder.Entity<tabletest>()
                .Property(e => e.Manufacture)
                .IsUnicode(false);
        }
    }
}
