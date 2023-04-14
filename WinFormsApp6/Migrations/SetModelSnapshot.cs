﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp6;

#nullable disable

namespace WinFormsApp6.Migrations
{
    [DbContext(typeof(Set))]
    partial class SetModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("WinFormsApp6.GameBoard", b =>
                {
                    b.Property<int>("GameBoardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Complexity")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Rate")
                        .HasColumnType("REAL");

                    b.HasKey("GameBoardID");

                    b.ToTable("GameBoards");
                });
#pragma warning restore 612, 618
        }
    }
}
