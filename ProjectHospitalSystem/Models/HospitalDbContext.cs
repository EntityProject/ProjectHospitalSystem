using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectHospitalSystem.Models
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Doctor_Schedule> Doctor_Schedules { get; set; }
        public DbSet<Patient_Phone> Patient_Phones { get; set; }
        public DbSet<User_Phone> UserPhones { get; set; }
        public DbSet<Payment> payments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
        .HasOne(d => d.DoctorManger)
        .WithMany()
        .HasForeignKey(d => d.DoctorMgnId)
        .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>()
        .Property(u => u.Role)
        .HasDefaultValue("Doctor");
            modelBuilder.Entity<User>()
                .ToTable(t => t.HasCheckConstraint("CK_User_Role",
                    "Role IN ('Admin', 'Doctor', 'Receptionist')"));
            modelBuilder.Entity<Patient>().Property(p => p.Gender).HasDefaultValue("Male");
            modelBuilder.Entity<Patient>()
                .ToTable(t => t.HasCheckConstraint("CK_PatientGender",
                    "Gender IN ('Male', 'Female')"));
            modelBuilder.Entity<Appointment>()
       .Property(a => a.AppointmentDateTime)
       .HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Bill>()
.Property(a => a.GenertedDate)
.HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Bill>()
       .Property(b => b.GenertedDate)
       .HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Bill>()
                .Property(b => b.DueDate)
                .HasDefaultValueSql("DATEADD(DAY, 3, GETDATE())");
            modelBuilder.Entity<Payment>().Property(Payment => Payment.PaymentDate).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<MedicalRecord>().Property(med => med.DateOfVist).HasDefaultValueSql("GETDATE()");
            base.OnModelCreating(modelBuilder);
        }
    }
}
