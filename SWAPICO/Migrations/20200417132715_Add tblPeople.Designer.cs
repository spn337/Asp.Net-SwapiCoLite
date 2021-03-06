﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SWAPICO.Entities;

namespace SWAPICO.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200417132715_Add tblPeople")]
    partial class AddtblPeople
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SWAPICO.Entities.DbPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthYear");

                    b.Property<string>("EyeColor");

                    b.Property<string>("Gender");

                    b.Property<string>("HairColor");

                    b.Property<string>("Height");

                    b.Property<string>("Homeworld");

                    b.Property<string>("Mass");

                    b.Property<string>("Name");

                    b.Property<string>("SkinColor");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.ToTable("tblPeople");
                });

            modelBuilder.Entity("SWAPICO.Entities.DbPlanet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Climate");

                    b.Property<string>("Diameter");

                    b.Property<string>("Gravity");

                    b.Property<string>("Name");

                    b.Property<string>("OrbitalPeriod");

                    b.Property<string>("Population");

                    b.Property<string>("RotationPeriod");

                    b.Property<string>("SurfaceWater");

                    b.Property<string>("Terrain");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.ToTable("tblPlanets");
                });
#pragma warning restore 612, 618
        }
    }
}
