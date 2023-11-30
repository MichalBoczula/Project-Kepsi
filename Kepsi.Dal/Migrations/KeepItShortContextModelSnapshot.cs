﻿// <auto-generated />
using System;
using KeepItShort.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kepsi.Dal.Migrations
{
    [DbContext(typeof(KeepItShortContext))]
    partial class KeepItShortContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KeepItShort.Persistance.Models.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("AddedDate");

                    b.HasIndex("Id");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("KeepItShort.Persistance.Models.RefactoredEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<int>("EmailId")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("EmailId")
                        .IsUnique();

                    b.HasIndex("Id");

                    b.ToTable("RefactoredEmails");
                });

            modelBuilder.Entity("KeepItShort.Persistance.Models.RefactoredEmail", b =>
                {
                    b.HasOne("KeepItShort.Persistance.Models.Email", "EmailRef")
                        .WithOne("RefactoredEmailRef")
                        .HasForeignKey("KeepItShort.Persistance.Models.RefactoredEmail", "EmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmailRef");
                });

            modelBuilder.Entity("KeepItShort.Persistance.Models.Email", b =>
                {
                    b.Navigation("RefactoredEmailRef");
                });
#pragma warning restore 612, 618
        }
    }
}
