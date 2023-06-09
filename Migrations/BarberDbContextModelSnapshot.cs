﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using team_status_undefined_backend.Migrations;

#nullable disable

namespace team_status_undefined_backend.Migrations
{
    [DbContext(typeof(BarberDbContext))]
    partial class BarberDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("team_status_undefined_backend.Models.Barber", b =>
                {
                    b.Property<int>("BarberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfilePic")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.HasKey("BarberId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Barber");
                });

            modelBuilder.Entity("team_status_undefined_backend.Models.BarberImageLink", b =>
                {
                    b.Property<int>("BarberImageLinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BarberId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BarberImageLinkId");

                    b.HasIndex("BarberId");

                    b.ToTable("BarberImageLinks");
                });

            modelBuilder.Entity("team_status_undefined_backend.Models.BarberImageLink", b =>
                {
                    b.HasOne("team_status_undefined_backend.Models.Barber", "Barber")
                        .WithMany("ImageLinks")
                        .HasForeignKey("BarberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barber");
                });

            modelBuilder.Entity("team_status_undefined_backend.Models.Barber", b =>
                {
                    b.Navigation("ImageLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
