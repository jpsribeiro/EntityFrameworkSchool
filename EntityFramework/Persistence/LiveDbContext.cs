using EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Persistence
{
    public class LiveDbContext : DbContext
    {
        public LiveDbContext(DbContextOptions<LiveDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<ContactInfromation> ContactInfromations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //FLUENT API
            modelBuilder
                .Entity<School>()
                .ToTable("tb_School");

            modelBuilder
                .Entity<School>()
                .HasKey(x => x.Id);

            modelBuilder
                .Entity<Student>()
                .HasKey(x => x.Id);

            modelBuilder
                .Entity<ContactInfromation>()
                .HasKey(x => x.Id);

            //se o ID fosse GUID
            //modelBuilder
            //    .Entity<School>()
            //    .Property(s => s.Id)
            //    .HasDefaultValueSql("NEWID()");

            modelBuilder
                .Entity<School>()
                .HasData(new School(1,"Escola daora"), new School(2, "Escola supimpa"));

            modelBuilder
                .Entity<School>()
                .Property(x => x.Name)
                .HasMaxLength(100)
                .HasDefaultValue("TITULO PADRAO")
                .HasColumnName("Name");

            //1:N -> 1 escola tem muitos Alunos
            modelBuilder
                .Entity<School>()
                .HasMany(x => x.Students)
                .WithOne(x => x.School)
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            //1:1
            modelBuilder
                .Entity<School>()
                .HasOne(x => x.ContactInfromation)
                .WithOne()
                .HasForeignKey<ContactInfromation>(x => x.SchoolId);
        }

    }
}
