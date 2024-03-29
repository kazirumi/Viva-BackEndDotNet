﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VivaSoftPractice.Data;

#nullable disable

namespace VivaSoftPractice.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240307155047_SalesMain Added")]
    partial class SalesMainAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VivaSoftPractice.Model.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = new Guid("836127e0-313e-40e3-abe9-ca80736e975e"),
                            Name = "andoid",
                            Price = 327844.58000000002
                        },
                        new
                        {
                            Id = new Guid("9d2ef2ec-fc25-43ad-9cd8-d8c5e422618b"),
                            Name = "samsung",
                            Price = 6434.96
                        },
                        new
                        {
                            Id = new Guid("f26c8380-dc1e-4441-9281-b770b49be07d"),
                            Name = "honda",
                            Price = 434.77999999999997
                        },
                        new
                        {
                            Id = new Guid("3de2eb97-f342-4d99-97b7-7425b77b6217"),
                            Name = "facewash",
                            Price = 327844.58000000002
                        },
                        new
                        {
                            Id = new Guid("d0d41311-6930-406d-9241-642d78dc7881"),
                            Name = "mini TV",
                            Price = 6434.96
                        },
                        new
                        {
                            Id = new Guid("6146472e-9854-4153-9551-4646da615193"),
                            Name = "Less",
                            Price = 434.77999999999997
                        });
                });

            modelBuilder.Entity("VivaSoftPractice.Model.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e981141b-d2cd-4ad0-9584-0c522831ce97"),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = new Guid("38638f23-a48f-418a-99c0-1dd27d61cf10"),
                            Name = "User"
                        },
                        new
                        {
                            Id = new Guid("3467e66d-6d23-42e8-b7a7-69d4c758cc0a"),
                            Name = "Organizer"
                        });
                });

            modelBuilder.Entity("VivaSoftPractice.Model.SalesMain", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SalesDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("SalesMains");
                });

            modelBuilder.Entity("VivaSoftPractice.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("JoinedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("VivaSoftPractice.Model.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("userRoles");
                });

            modelBuilder.Entity("VivaSoftPractice.Model.UserRole", b =>
                {
                    b.HasOne("VivaSoftPractice.Model.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VivaSoftPractice.Model.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VivaSoftPractice.Model.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("VivaSoftPractice.Model.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
