using BlazorSQLServerWebApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BlazorSQLServerWebApp.Server.Models
{
    public partial class UserDBContext : DbContext
    {
        public UserDBContext()
        {
        }
        public UserDBContext(DbContextOptions<UserDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");
                entity.Property(e => e.Id).HasColumnName("Id");
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Country)
                    .HasMaxLength(500)
                    .IsUnicode(false);
               
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}