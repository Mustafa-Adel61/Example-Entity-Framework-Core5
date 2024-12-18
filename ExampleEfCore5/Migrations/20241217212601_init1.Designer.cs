﻿// <auto-generated />
using System;
using ExampleEfCore5;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExampleEfCore5.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20241217212601_init1")]
    partial class init1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DoctorMedicine", b =>
                {
                    b.Property<int>("doctorsId")
                        .HasColumnType("int");

                    b.Property<int>("medicinesregistration_Number")
                        .HasColumnType("int");

                    b.HasKey("doctorsId", "medicinesregistration_Number");

                    b.HasIndex("medicinesregistration_Number");

                    b.ToTable("DoctorMedicine");
                });

            modelBuilder.Entity("ExampleEfCore5.Bill", b =>
                {
                    b.Property<int>("Numebr_Of_Bill")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Payment_method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<float>("discount")
                        .HasColumnType("real");

                    b.HasKey("Numebr_Of_Bill");

                    b.HasIndex("PatientId")
                        .IsUnique();

                    b.ToTable("bills");
                });

            modelBuilder.Entity("ExampleEfCore5.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Middle_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("specialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("years_to_retirement")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("doctors");
                });

            modelBuilder.Entity("ExampleEfCore5.Doctor_Location", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DoctorId", "Location");

                    b.ToTable("Doctor_Location");
                });

            modelBuilder.Entity("ExampleEfCore5.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tax_Register")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("tax_Register");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("ExampleEfCore5.Medicine", b =>
                {
                    b.Property<int>("registration_Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Supplier_ID")
                        .HasColumnType("int");

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<string>("frequency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("remaining_shelf_life")
                        .HasColumnType("int");

                    b.HasKey("registration_Number");

                    b.HasIndex("Supplier_ID");

                    b.ToTable("medicines");
                });

            modelBuilder.Entity("ExampleEfCore5.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Doctor_ID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Middle_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("perscrtion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("registration")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Doctor_ID");

                    b.HasIndex("registration");

                    b.ToTable("patients");
                });

            modelBuilder.Entity("ExampleEfCore5.Patient_Phone", b =>
                {
                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<string>("Phone_Number")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Patient_Id", "Phone_Number");

                    b.ToTable("Patient_Phone");
                });

            modelBuilder.Entity("ExampleEfCore5.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Middle_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("delivery_efficiency")
                        .HasColumnType("int");

                    b.Property<string>("phone_Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("suppliers");
                });

            modelBuilder.Entity("ExampleEfCore5.Warehouse", b =>
                {
                    b.Property<int>("tax_Register")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("inspection_scheduel")
                        .HasColumnType("datetime2");

                    b.Property<string>("manager_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("registration_Number")
                        .HasColumnType("int");

                    b.Property<string>("stored_items")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tax_Register");

                    b.HasIndex("registration_Number")
                        .IsUnique();

                    b.ToTable("warehouses");
                });

            modelBuilder.Entity("DoctorMedicine", b =>
                {
                    b.HasOne("ExampleEfCore5.Doctor", null)
                        .WithMany()
                        .HasForeignKey("doctorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExampleEfCore5.Medicine", null)
                        .WithMany()
                        .HasForeignKey("medicinesregistration_Number")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExampleEfCore5.Bill", b =>
                {
                    b.HasOne("ExampleEfCore5.Patient", "patient")
                        .WithOne("bill")
                        .HasForeignKey("ExampleEfCore5.Bill", "PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("patient");
                });

            modelBuilder.Entity("ExampleEfCore5.Doctor_Location", b =>
                {
                    b.HasOne("ExampleEfCore5.Doctor", "doctor")
                        .WithMany("doctor_Locations")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");
                });

            modelBuilder.Entity("ExampleEfCore5.Employee", b =>
                {
                    b.HasOne("ExampleEfCore5.Warehouse", "warehouse")
                        .WithMany("employees")
                        .HasForeignKey("tax_Register")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("warehouse");
                });

            modelBuilder.Entity("ExampleEfCore5.Medicine", b =>
                {
                    b.HasOne("ExampleEfCore5.Supplier", "supplier")
                        .WithMany("medicines")
                        .HasForeignKey("Supplier_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("supplier");
                });

            modelBuilder.Entity("ExampleEfCore5.Patient", b =>
                {
                    b.HasOne("ExampleEfCore5.Doctor", "doctor")
                        .WithMany("patients")
                        .HasForeignKey("Doctor_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ExampleEfCore5.Medicine", "medicine")
                        .WithMany("patient")
                        .HasForeignKey("registration")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");

                    b.Navigation("medicine");
                });

            modelBuilder.Entity("ExampleEfCore5.Patient_Phone", b =>
                {
                    b.HasOne("ExampleEfCore5.Patient", "patient")
                        .WithMany("patient_Phone")
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("patient");
                });

            modelBuilder.Entity("ExampleEfCore5.Warehouse", b =>
                {
                    b.HasOne("ExampleEfCore5.Medicine", "medicine")
                        .WithOne("warehouse")
                        .HasForeignKey("ExampleEfCore5.Warehouse", "registration_Number")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("medicine");
                });

            modelBuilder.Entity("ExampleEfCore5.Doctor", b =>
                {
                    b.Navigation("doctor_Locations");

                    b.Navigation("patients");
                });

            modelBuilder.Entity("ExampleEfCore5.Medicine", b =>
                {
                    b.Navigation("patient");

                    b.Navigation("warehouse");
                });

            modelBuilder.Entity("ExampleEfCore5.Patient", b =>
                {
                    b.Navigation("bill");

                    b.Navigation("patient_Phone");
                });

            modelBuilder.Entity("ExampleEfCore5.Supplier", b =>
                {
                    b.Navigation("medicines");
                });

            modelBuilder.Entity("ExampleEfCore5.Warehouse", b =>
                {
                    b.Navigation("employees");
                });
#pragma warning restore 612, 618
        }
    }
}
