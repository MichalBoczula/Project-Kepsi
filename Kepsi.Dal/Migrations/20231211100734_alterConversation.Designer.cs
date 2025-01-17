﻿// <auto-generated />
using System;
using KeepItShort.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kepsi.Dal.Migrations
{
    [DbContext(typeof(KeepItShortContext))]
    [Migration("20231211100734_alterConversation")]
    partial class alterConversation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("ConversationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddedDate");

                    b.HasIndex("ConversationId");

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

                    b.Property<int>("RefactoredConversationId")
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

                    b.HasIndex("RefactoredConversationId");

                    b.ToTable("RefactoredEmails");
                });

            modelBuilder.Entity("Kepsi.Dal.Models.Conversation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RefactoredConversationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Conversation");
                });

            modelBuilder.Entity("Kepsi.Dal.Models.RefactoredConversation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConversationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConversationId")
                        .IsUnique();

                    b.HasIndex("Id");

                    b.ToTable("RefactoredConversation");
                });

            modelBuilder.Entity("KeepItShort.Persistance.Models.Email", b =>
                {
                    b.HasOne("Kepsi.Dal.Models.Conversation", "Conversation")
                        .WithMany("Emails")
                        .HasForeignKey("ConversationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Conversation");
                });

            modelBuilder.Entity("KeepItShort.Persistance.Models.RefactoredEmail", b =>
                {
                    b.HasOne("KeepItShort.Persistance.Models.Email", "EmailRef")
                        .WithOne("RefactoredEmailRef")
                        .HasForeignKey("KeepItShort.Persistance.Models.RefactoredEmail", "EmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kepsi.Dal.Models.RefactoredConversation", "RefactoredConversationRef")
                        .WithMany("RefactoredEmails")
                        .HasForeignKey("RefactoredConversationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("EmailRef");

                    b.Navigation("RefactoredConversationRef");
                });

            modelBuilder.Entity("Kepsi.Dal.Models.RefactoredConversation", b =>
                {
                    b.HasOne("Kepsi.Dal.Models.Conversation", "ConversationRef")
                        .WithOne("ConversationRef")
                        .HasForeignKey("Kepsi.Dal.Models.RefactoredConversation", "ConversationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ConversationRef");
                });

            modelBuilder.Entity("KeepItShort.Persistance.Models.Email", b =>
                {
                    b.Navigation("RefactoredEmailRef");
                });

            modelBuilder.Entity("Kepsi.Dal.Models.Conversation", b =>
                {
                    b.Navigation("ConversationRef");

                    b.Navigation("Emails");
                });

            modelBuilder.Entity("Kepsi.Dal.Models.RefactoredConversation", b =>
                {
                    b.Navigation("RefactoredEmails");
                });
#pragma warning restore 612, 618
        }
    }
}
