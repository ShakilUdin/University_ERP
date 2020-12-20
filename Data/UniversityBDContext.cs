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

        public DbSet<LabManager> LabManagers { get; set; }

        public DbSet<PartTimeFaculty> PartTimeFaculties { get; set; }

        public DbSet<Secretary> Secretaries { get; set; }

        public DbSet<FullTimeFaculty> FullTimeFaculties { get; set; }

       
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Under Grad Student
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
                .Property(p => p.Firstname)
                .HasMaxLength(10);

            modelBuilder.Entity<PhDStudent>()
                .Property(p => p.Lastname)
                .HasMaxLength(10);

            modelBuilder.Entity<PhDStudent>()
                .Property(p => p.Streetaddress)
                .HasMaxLength(300);

            modelBuilder.Entity<PhDStudent>()
                .Property(p => p.City)
                .HasMaxLength(20);

            modelBuilder.Entity<PhDStudent>()
                .Property(p => p.Telephone)
                .IsRequired();
            modelBuilder.Entity<PhDStudent>()
                .Property(p => p.Phdadvisor)
                .HasMaxLength(250);
            
        }
    }
}
