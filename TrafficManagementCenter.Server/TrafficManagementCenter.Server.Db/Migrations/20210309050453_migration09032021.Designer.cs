﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TrafficManagementCenter.Server.Db.Context;

namespace TrafficManagementCenter.Server.Db.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210309050453_migration09032021")]
    partial class migration09032021
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Model.Appeal", b =>
                {
                    b.Property<long>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Attachment")
                        .HasColumnType("text");

                    b.Property<int>("AppealClass")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<long?>("SubtypeKey")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.HasKey("Key");

                    b.HasIndex("SubtypeKey");

                    b.ToTable("Appeal");
                });

            modelBuilder.Entity("Model.SubtypeAppeal", b =>
                {
                    b.Property<long>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<long?>("TypeKey")
                        .HasColumnType("bigint");

                    b.HasKey("Key");

                    b.HasIndex("TypeKey");

                    b.ToTable("SubtypeAppeals");
                });

            modelBuilder.Entity("Model.TypeAppeal", b =>
                {
                    b.Property<long>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.HasKey("Key");

                    b.ToTable("TypeAppeal");
                });

            modelBuilder.Entity("Model.Appeal", b =>
                {
                    b.HasOne("Model.SubtypeAppeal", "Subtype")
                        .WithMany()
                        .HasForeignKey("SubtypeKey");

                    b.Navigation("Subtype");
                });

            modelBuilder.Entity("Model.SubtypeAppeal", b =>
                {
                    b.HasOne("Model.TypeAppeal", "Type")
                        .WithMany()
                        .HasForeignKey("TypeKey");

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
