using Microsoft.EntityFrameworkCore;
using PatientManagementApp.Controllers;
using PatientManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientManagementApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=ZIWIN;Initial Catalog=HealthCare;Integrated Security=True");
        //}
        public ApplicationDbContext()
        {

        }
        public DbSet<Doctor>Doctors { get; set; }
        public DbSet<PatientDetail> PatientDetails { get; set; }
        public DbSet<PatientProblems> PatientProblem { get; set; }
        public DbSet<PatientMedications> PatientMedication { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientDetail>().ToTable("PatientDetail");
            modelBuilder.Entity<PatientProblems>().ToTable("PatientProblems");
            modelBuilder.Entity<PatientMedications>().ToTable("PatientMedications");
            modelBuilder.Entity<Doctor>().ToTable("Doctor");

        }

        //public static implicit operator ApplicationDbContext(PatientAPIController v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
