using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_ERP.Models;

namespace University_ERP.Data
{
    class UniversityBDContext : DbContext
    {
       

        public DbSet<UnderGradStudent> UnderGradStudents { get; set; }

        public DbSet<GradStudent> GradStudents { get; set; }

        public DbSet<PartTimeStudent> PartTimeStudents { get; set; }

        public DbSet<PhDStudent> PhDStudents { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnderGradStudent>()
                .Property(s => s.Firstname)
                .HasMaxLength(10);

            modelBuilder.Entity<UnderGradStudent>()
                .Property(s => s.Lastname)
                .HasMaxLength(10);

            modelBuilder.Entity<UnderGradStudent>()
                .Property(s => s.Streetaddress)
                .HasMaxLength(300);

            modelBuilder.Entity<UnderGradStudent>()
                .Property(s => s.City)
                .HasMaxLength(20);

            modelBuilder.Entity<UnderGradStudent>()
                .Property(s => s.Telephone)
                .IsRequired();

            // GradStudents

            modelBuilder.Entity<GradStudent>()
                .Property(s => s.Firstname)
                .HasMaxLength(10);

            modelBuilder.Entity<GradStudent>()
                .Property(s => s.Lastname)
                .HasMaxLength(10);

            modelBuilder.Entity<GradStudent>()
                .Property(s => s.Streetaddress)
                .HasMaxLength(300);

            modelBuilder.Entity<GradStudent>()
                .Property(s => s.City)
                .HasMaxLength(20);

            modelBuilder.Entity<GradStudent>()
                .Property(s => s.Telephone)
                .IsRequired();
            // Part Time

            modelBuilder.Entity<PartTimeStudent>()
                .Property(s => s.Firstname)
                .HasMaxLength(10);

            modelBuilder.Entity<PartTimeStudent>()
                .Property(s => s.Lastname)
                .HasMaxLength(10);

            modelBuilder.Entity<PartTimeStudent>()
                .Property(s => s.Streetaddress)
                .HasMaxLength(300);

            modelBuilder.Entity<PartTimeStudent>()
                .Property(s => s.City)
                .HasMaxLength(20);

            modelBuilder.Entity<PartTimeStudent>()
                .Property(s => s.Telephone)
                .IsRequired();

            //PDH Student

            modelBuilder.Entity<PhDStudent>()
                .Property(s => s.Firstname)
                .HasMaxLength(10);

            modelBuilder.Entity<PhDStudent>()
                .Property(s => s.Lastname)
                .HasMaxLength(10);

            modelBuilder.Entity<PhDStudent>()
                .Property(s => s.Streetaddress)
                .HasMaxLength(300);

            modelBuilder.Entity<PhDStudent>()
                .Property(s => s.City)
                .HasMaxLength(20);

            modelBuilder.Entity<PhDStudent>()
                .Property(s => s.Telephone)
                .IsRequired();
        }
    }
}
