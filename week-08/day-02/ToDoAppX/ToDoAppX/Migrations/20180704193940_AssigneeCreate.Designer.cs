﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoAppX.Repositories;

namespace ToDoAppX.Migrations
{
    [DbContext(typeof(ToDoDbContext))]
    [Migration("20180704193940_AssigneeCreate")]
    partial class AssigneeCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDoAppX.Models.Assignee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Assignees");
                });

            modelBuilder.Entity("ToDoAppX.Models.ToDo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssigneeId");

                    b.Property<bool>("IsDone");

                    b.Property<bool>("IsUrgent");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("ToDoAppX.Models.ToDo", b =>
                {
                    b.HasOne("ToDoAppX.Models.Assignee", "Assignee")
                        .WithMany("ToDos")
                        .HasForeignKey("AssigneeId");
                });
#pragma warning restore 612, 618
        }
    }
}
