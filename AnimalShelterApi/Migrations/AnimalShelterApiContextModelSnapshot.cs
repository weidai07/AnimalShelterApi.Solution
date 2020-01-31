﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelterApi.Solution.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    partial class AnimalShelterApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cats");

                    b.Property<string>("Dogs");

                    b.Property<int>("Quantity");

                    b.HasKey("AnimalId");

                    b.ToTable("Animal");

                    b.HasData(
                        new
                        {
                            AnimalId = 121,
                            Cats = "Brown",
                            Dogs = "Corgi",
                            Quantity = 51
                        },
                        new
                        {
                            AnimalId = 131,
                            Cats = "White",
                            Dogs = "Lab",
                            Quantity = 61
                        },
                        new
                        {
                            AnimalId = 141,
                            Cats = "Egyptian",
                            Dogs = "Retriever",
                            Quantity = 71
                        },
                        new
                        {
                            AnimalId = 151,
                            Cats = "Grey",
                            Dogs = "Pug",
                            Quantity = 81
                        },
                        new
                        {
                            AnimalId = 161,
                            Cats = "Orange",
                            Dogs = "Chihuahua",
                            Quantity = 91
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
