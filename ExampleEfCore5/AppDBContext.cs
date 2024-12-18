using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleEfCore5
{
    public class AppDBContext : DbContext
    {
        //  public int MyProperty { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Medicine> medicines { get; set; }
        public DbSet<Bill> bills { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Warehouse> warehouses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-O7H8C51\MSSQLSERVER03;Initial Catalog=ExampleEFCore5;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //add class in domain model 3 method
            modelBuilder.Entity<Patient>();

            //set primary key
            modelBuilder.Entity<Medicine>().HasKey(c => c.registration_Number);
            modelBuilder.Entity<Bill>().HasKey(c => c.Numebr_Of_Bill);
            modelBuilder.Entity<Warehouse>().HasKey(c => c.tax_Register);

            ////Data query filter 
            //// كدا هيطلع ال data كلها ماعدا الي ال aga بتاعهم ==10
            //modelBuilder.Entity<Patient>().HasQueryFilter(c => c.Age != 10);


            ////identity
            //modelBuilder.Entity<Patient>().Property(c=>c.Id).ValueGeneratedOnAdd();

            //one to one relation
            modelBuilder.Entity<Warehouse>()
                .HasOne(c => c.medicine)
                .WithOne(c => c.warehouse)
                .HasForeignKey<Warehouse>(c => c.registration_Number)
                .OnDelete(DeleteBehavior.Restrict);

            //one to many relation 
            modelBuilder.Entity<Patient>()
                .HasOne(c => c.medicine)
                .WithMany(c => c.patient)
                .HasForeignKey(c => c.registration);


            modelBuilder.Entity<Employee>()
                .HasOne(c => c.warehouse)
                .WithMany(c => c.employees)
                .HasForeignKey(c => c.tax_Register);

            modelBuilder.Entity<Patient>()
                .HasOne(c => c.doctor)
                .WithMany(c => c.patients)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Medicine>()
                .HasOne(c => c.supplier)
                .WithMany(c => c.medicines)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Patient_Phone>()
                .HasOne(c => c.patient)
                .WithMany(c => c.patient_Phone)
                .HasForeignKey(c => c.Patient_Id);

            modelBuilder.Entity<Patient>()
                .HasOne(c => c.doctor)
                .WithMany(c => c.patients)
                .HasForeignKey(c => c.Doctor_ID);

            modelBuilder.Entity<Medicine>()
                .HasOne(c => c.supplier)
                .WithMany(c => c.medicines)
                .HasForeignKey(c => c.Supplier_ID);

            //composite Key
            modelBuilder.Entity<Doctor_Location>().HasKey(c => new { c.DoctorId, c.Location });
            modelBuilder.Entity<Patient_Phone>().HasKey(c => new { c.Patient_Id, c.Phone_Number });
        }
    }
}
