﻿// <auto-generated />
using System;
using BookStoreV2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStoreV2.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20190307041719_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStoreV2.Entities.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("AuthorId");

                    b.ToTable("Author","dbo");

                    b.HasData(
                        new { AuthorId = new Guid("e739c64e-0fa7-4b4f-8353-47f84a134016"), FirstName = "Daniel", Genre = "Action", LastName = "Silva" },
                        new { AuthorId = new Guid("20c825de-7482-4c7d-a440-6bf5f67f1458"), FirstName = "Andrew", Genre = "Medicine", LastName = "Weil" },
                        new { AuthorId = new Guid("6b9e4325-aa5c-4a22-bb59-4c1ba0f1014c"), FirstName = "Tom", Genre = "Thriller", LastName = "Clancy" }
                    );
                });

            modelBuilder.Entity("BookStoreV2.Entities.Book", b =>
                {
                    b.Property<Guid>("BookdId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AuthorId");

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("BookdId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Book","dbo");
                });

            modelBuilder.Entity("BookStoreV2.Entities.Book", b =>
                {
                    b.HasOne("BookStoreV2.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}