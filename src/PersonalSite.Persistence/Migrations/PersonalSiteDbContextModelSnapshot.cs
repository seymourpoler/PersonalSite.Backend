﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PersonalSite.Persistence;

namespace PersonalSite.Persistence.Migrations
{
    [DbContext(typeof(PersonalSiteDbContext))]
    partial class PersonalSiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PersonalSite.Domain.Model.JobExperienceAggregate.JobExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Company")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("TechStack")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("JobExperiences");
                });

            modelBuilder.Entity("PersonalSite.Domain.Model.JobExperienceAggregate.JobExperience", b =>
                {
                    b.OwnsOne("PersonalSite.Domain.Model.JobExperienceAggregate.JobPeriod", "JobPeriod", b1 =>
                        {
                            b1.Property<int>("JobExperienceId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.Property<DateTime?>("End")
                                .HasColumnType("timestamp without time zone");

                            b1.Property<DateTime>("Start")
                                .HasColumnType("timestamp without time zone");

                            b1.HasKey("JobExperienceId");

                            b1.ToTable("JobExperiences");

                            b1.WithOwner()
                                .HasForeignKey("JobExperienceId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
