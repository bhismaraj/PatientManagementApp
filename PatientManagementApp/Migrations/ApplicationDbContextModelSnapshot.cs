﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientManagementApp.Data;

namespace PatientManagementApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoctorPatientDetail", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientDetailsPatientId")
                        .HasColumnType("int");

                    b.HasKey("DoctorId", "PatientDetailsPatientId");

                    b.HasIndex("PatientDetailsPatientId");

                    b.ToTable("DoctorPatientDetail");
                });

            modelBuilder.Entity("PatientManagementApp.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialist")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("PatientManagementApp.Models.PatientDetail", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DOB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("DoctorFees")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorToAttend")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalBill")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfPayment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("PatientDetail");
                });

            modelBuilder.Entity("PatientManagementApp.Models.PatientMedications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientProblemsId")
                        .HasColumnType("int");

                    b.Property<string>("TimesPerDay")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientProblemsId");

                    b.ToTable("PatientMedications");
                });

            modelBuilder.Entity("PatientManagementApp.Models.PatientProblems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("PatientDetailIdPatientId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("ProblemType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientDetailIdPatientId");

                    b.ToTable("PatientProblems");
                });

            modelBuilder.Entity("DoctorPatientDetail", b =>
                {
                    b.HasOne("PatientManagementApp.Models.Doctor", null)
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PatientManagementApp.Models.PatientDetail", null)
                        .WithMany()
                        .HasForeignKey("PatientDetailsPatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PatientManagementApp.Models.PatientMedications", b =>
                {
                    b.HasOne("PatientManagementApp.Models.PatientProblems", "PatientProblems")
                        .WithMany("PatientMedications")
                        .HasForeignKey("PatientProblemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PatientProblems");
                });

            modelBuilder.Entity("PatientManagementApp.Models.PatientProblems", b =>
                {
                    b.HasOne("PatientManagementApp.Models.PatientDetail", "PatientDetailId")
                        .WithMany("PatientProblem")
                        .HasForeignKey("PatientDetailIdPatientId");

                    b.Navigation("PatientDetailId");
                });

            modelBuilder.Entity("PatientManagementApp.Models.PatientDetail", b =>
                {
                    b.Navigation("PatientProblem");
                });

            modelBuilder.Entity("PatientManagementApp.Models.PatientProblems", b =>
                {
                    b.Navigation("PatientMedications");
                });
#pragma warning restore 612, 618
        }
    }
}
