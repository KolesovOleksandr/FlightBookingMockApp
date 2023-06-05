﻿// <auto-generated />
using System;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace _2023_Kolesov_O_O_Lab2.Migrations
{
    [DbContext(typeof(TimetableContext))]
    [Migration("20230603112149_UpdatedIds")]
    partial class UpdatedIds
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("DataAccessLayer.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CountryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("DocumentNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PassengerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DocumentId");

                    b.HasIndex("PassengerId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeparturePointId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DestinationPointId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PlaneId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FlightId");

                    b.HasIndex("DeparturePointId");

                    b.HasIndex("DestinationPointId");

                    b.HasIndex("PlaneId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PassengerId");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Plane", b =>
                {
                    b.Property<int>("PlaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlaneName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlaneId");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AquirementTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("DocumentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FlightId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ReturnmentTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TicketNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("TicketPrice")
                        .HasColumnType("REAL");

                    b.HasKey("TicketId");

                    b.HasIndex("DocumentId");

                    b.HasIndex("FlightId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("DataAccessLayer.Models.City", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Document", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Passenger", "Passenger")
                        .WithMany()
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Flight", b =>
                {
                    b.HasOne("DataAccessLayer.Models.City", "DeparturePoint")
                        .WithMany("DeparturePoints")
                        .HasForeignKey("DeparturePointId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Models.City", "DestinationPoint")
                        .WithMany("DestinationPoints")
                        .HasForeignKey("DestinationPointId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Models.Plane", "Plane")
                        .WithMany("Flights")
                        .HasForeignKey("PlaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeparturePoint");

                    b.Navigation("DestinationPoint");

                    b.Navigation("Plane");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Ticket", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Document", "Document")
                        .WithMany("Tickets")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Models.Flight", "Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("DataAccessLayer.Models.City", b =>
                {
                    b.Navigation("DeparturePoints");

                    b.Navigation("DestinationPoints");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Document", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Flight", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("DataAccessLayer.Models.Plane", b =>
                {
                    b.Navigation("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}
