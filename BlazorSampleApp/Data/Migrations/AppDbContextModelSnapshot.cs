﻿// <auto-generated />
using BlazorSampleApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorSampleApp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("BlazorSampleApp.Data.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is some example for description to post with id equals 1",
                            Title = "Post 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is some example for description to post with id equals 2",
                            Title = "Post 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "This is some example for description to post with id equals 3",
                            Title = "Post 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "This is some example for description to post with id equals 4",
                            Title = "Post 4"
                        },
                        new
                        {
                            Id = 5,
                            Description = "This is some example for description to post with id equals 5",
                            Title = "Post 5"
                        },
                        new
                        {
                            Id = 6,
                            Description = "This is some example for description to post with id equals 6",
                            Title = "Post 6"
                        },
                        new
                        {
                            Id = 7,
                            Description = "This is some example for description to post with id equals 7",
                            Title = "Post 7"
                        },
                        new
                        {
                            Id = 8,
                            Description = "This is some example for description to post with id equals 8",
                            Title = "Post 8"
                        },
                        new
                        {
                            Id = 9,
                            Description = "This is some example for description to post with id equals 9",
                            Title = "Post 9"
                        },
                        new
                        {
                            Id = 10,
                            Description = "This is some example for description to post with id equals 10",
                            Title = "Post 10"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
