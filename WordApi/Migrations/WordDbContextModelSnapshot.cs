﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WordApi;

namespace WordApi.Migrations
{
    [DbContext(typeof(WordDbContext))]
    partial class WordDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WordApi.WordDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LngId")
                        .HasColumnType("int");

                    b.Property<string>("Meaning")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WordDef")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WordDefinitions");
                });
#pragma warning restore 612, 618
        }
    }
}