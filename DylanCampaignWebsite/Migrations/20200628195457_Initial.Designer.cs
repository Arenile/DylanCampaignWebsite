﻿// <auto-generated />
using DylanCampaignWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DylanCampaignWebsite.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200628195457_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DylanCampaignWebsite.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CharacterBackground")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CharacterBio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CharacterClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CharacterLevel")
                        .HasColumnType("int");

                    b.Property<string>("CharacterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CharacterRace")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
