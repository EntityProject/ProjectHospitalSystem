﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectHospitalSystem.Models;


#nullable disable

namespace ProjectHospitalSystem.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    partial class HospitalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectHospitalSystem.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"));

                    b.Property<DateTime>("AppointmentDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<bool>("ReminderSent")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("UserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DueDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("DATEADD(DAY, 3, GETDATE())");

                    b.Property<DateTime>("GenertedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("money");

                    b.HasKey("BillId");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptId"));

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Dept_Desc")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int?>("DoctorMgnId")
                        .HasColumnType("int");

                    b.HasKey("DeptId");

                    b.HasIndex("DoctorMgnId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DoctorId");

                    b.HasIndex("DeptId");

                    b.HasIndex("UserId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Doctor_Schedule", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScheduleDay")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId", "ScheduleDay");

                    b.ToTable("Doctor_Schedules");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.MedicalRecord", b =>
                {
                    b.Property<int>("MedicalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicalId"));

                    b.Property<DateTime>("DateOfVist")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Diaqnois")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("LabResult")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Prescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("TreatmentDetails")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MedicalId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("UserId");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)")
                        .HasDefaultValue("Male");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PatientId");

                    b.HasIndex("UserId");

                    b.ToTable("Patients", t =>
                        {
                            t.HasCheckConstraint("CK_PatientGender", "Gender IN ('Male', 'Female')");
                        });
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Patient_Phone", b =>
                {
                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PatientId", "PhoneNumber");

                    b.ToTable("Patient_Phones");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("money");

                    b.Property<int?>("BillId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Paymentmethod")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("PaymentId");

                    b.HasIndex("BillId");

                    b.ToTable("payments");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int?>("BillId")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasDefaultValue("Doctor");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("BillId");

                    b.ToTable("Users", t =>
                        {
                            t.HasCheckConstraint("CK_User_Role", "Role IN ('Admin', 'Doctor', 'Receptionist')");
                        });
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.User_Phone", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserId", "PhoneNumber");

                    b.ToTable("UserPhones");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Appointment", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId");

                    b.HasOne("ProjectHospitalSystem.Models.Patient", "Patient")
                        .WithMany("Appointment")
                        .HasForeignKey("PatientId");

                    b.HasOne("ProjectHospitalSystem.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Bill", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.Appointment", "Appointment")
                        .WithMany("Bill")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Department", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.Doctor", "DoctorManger")
                        .WithMany()
                        .HasForeignKey("DoctorMgnId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("DoctorManger");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Doctor", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.Department", "Dept")
                        .WithMany("Doctors")
                        .HasForeignKey("DeptId");

                    b.HasOne("ProjectHospitalSystem.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Dept");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Doctor_Schedule", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.Doctor", "Doctor")
                        .WithMany("doctorSchedule")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.MedicalRecord", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.HasOne("ProjectHospitalSystem.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.HasOne("ProjectHospitalSystem.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Patient", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Patient_Phone", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.Patient", "Patient")
                        .WithMany("Patient_Phone")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Payment", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.Bill", "Bill")
                        .WithMany("Payment")
                        .HasForeignKey("BillId");

                    b.Navigation("Bill");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.User", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.Bill", "Bill")
                        .WithMany()
                        .HasForeignKey("BillId");

                    b.Navigation("Bill");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.User_Phone", b =>
                {
                    b.HasOne("ProjectHospitalSystem.Models.User", "User")
                        .WithMany("UserPhones")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Appointment", b =>
                {
                    b.Navigation("Bill");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Bill", b =>
                {
                    b.Navigation("Payment");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Department", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("doctorSchedule");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.Patient", b =>
                {
                    b.Navigation("Appointment");

                    b.Navigation("Patient_Phone");
                });

            modelBuilder.Entity("ProjectHospitalSystem.Models.User", b =>
                {
                    b.Navigation("UserPhones");
                });
#pragma warning restore 612, 618
        }
    }
}
