﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharpik.Data.BookProjectData;

#nullable disable

namespace csharpik.Data.Migrations
{
    [DbContext(typeof(BookProjectContext))]
    [Migration("20220326175520_changeAuthor")]
    partial class changeAuthor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("csharpik.Models.BookProject.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("csharpik.Models.BookProject.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFree")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("csharpik.Models.BookProject.BookNameKeeper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("PdfFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookId")
                        .IsUnique()
                        .HasFilter("[BookId] IS NOT NULL");

                    b.ToTable("UrlKeepers");
                });

            modelBuilder.Entity("csharpik.Models.BookProject.Book", b =>
                {
                    b.HasOne("csharpik.Models.BookProject.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("csharpik.Models.BookProject.BookNameKeeper", b =>
                {
                    b.HasOne("csharpik.Models.BookProject.Book", "Book")
                        .WithOne("UrlKeeper")
                        .HasForeignKey("csharpik.Models.BookProject.BookNameKeeper", "BookId");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("csharpik.Models.BookProject.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("csharpik.Models.BookProject.Book", b =>
                {
                    b.Navigation("UrlKeeper");
                });
#pragma warning restore 612, 618
        }
    }
}
