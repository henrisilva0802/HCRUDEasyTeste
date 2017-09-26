﻿// <auto-generated />
using HCRUDEasy.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HCRUDEasy.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HCRUDEasy.Domain.Bank.BankInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Agency")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("BankInformation");
                });

            modelBuilder.Entity("HCRUDEasy.Domain.Person.Candidate.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BankInformationId");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("BankInformationId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("HCRUDEasy.Domain.Person.Candidate.Candidate", b =>
                {
                    b.HasOne("HCRUDEasy.Domain.Bank.BankInformation", "BankInformation")
                        .WithMany()
                        .HasForeignKey("BankInformationId");
                });
#pragma warning restore 612, 618
        }
    }
}