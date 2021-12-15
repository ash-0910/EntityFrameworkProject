﻿// <auto-generated />
using System;
using EntityFrameworkProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkProject.Migrations
{
    [DbContext(typeof(EFdbcontext))]
    partial class EFdbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("EntityFrameworkProject.Models.Product", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EntityFrameworkProject.Models.SaleItem", b =>
                {
                    b.Property<string>("SaleName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Product")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("SaleName");

                    b.ToTable("SalesItem");
                });
#pragma warning restore 612, 618
        }
    }
}