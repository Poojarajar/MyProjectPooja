﻿// <auto-generated />
using MVC_CodeFirstApproach1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_CodeFirstApproach1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241016112331_AppInit")]
    partial class AppInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_CodeFirstApproach1.Models.CategoryModel", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("tblCategory");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("MVC_CodeFirstApproach1.Models.ProductModel", b =>
                {
                    b.HasBaseType("MVC_CodeFirstApproach1.Models.CategoryModel");

                    b.Property<int>("CategoryId1")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasIndex("CategoryId1");

                    b.ToTable("tblProduct");
                });

            modelBuilder.Entity("MVC_CodeFirstApproach1.Models.ProductModel", b =>
                {
                    b.HasOne("MVC_CodeFirstApproach1.Models.CategoryModel", null)
                        .WithOne()
                        .HasForeignKey("MVC_CodeFirstApproach1.Models.ProductModel", "CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_CodeFirstApproach1.Models.CategoryModel", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MVC_CodeFirstApproach1.Models.CategoryModel", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
