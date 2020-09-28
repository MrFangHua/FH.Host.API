﻿// <auto-generated />
using System;
using FH.Host.API.Infrastructure.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FH.Host.API.Infrastructure.Migrations
{
    [DbContext(typeof(FangHuaHostDbContext))]
    partial class FangHuaHostDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FH.Host.API.Model.DefaultEntity.FH_Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminName")
                        .IsRequired();

                    b.Property<string>("AdminPwd")
                        .IsRequired();

                    b.Property<int>("CreateAdminID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("CreateUserID");

                    b.Property<string>("DeleteTimeAndRemark");

                    b.Property<int>("IsDeleted");

                    b.Property<DateTime>("LastUpdateTime");

                    b.HasKey("Id");

                    b.ToTable("FH_Admin");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminName = "Admin",
                            AdminPwd = "Admin123456",
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 9, 28, 17, 29, 27, 782, DateTimeKind.Local).AddTicks(769),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 9, 28, 17, 29, 27, 784, DateTimeKind.Local).AddTicks(8574)
                        },
                        new
                        {
                            Id = 2,
                            AdminName = "Mr.Fang",
                            AdminPwd = "Fh2269...",
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 9, 28, 17, 29, 27, 785, DateTimeKind.Local).AddTicks(2057),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 9, 28, 17, 29, 27, 785, DateTimeKind.Local).AddTicks(2061)
                        });
                });

            modelBuilder.Entity("FH.Host.API.Model.DefaultEntity.FH_Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreateAdminID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("CreateUserID");

                    b.Property<string>("DeleteTimeAndRemark");

                    b.Property<int>("IsDeleted");

                    b.Property<DateTime>("LastUpdateTime");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("UserPwd")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("FH_Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 9, 28, 17, 29, 27, 786, DateTimeKind.Local).AddTicks(9390),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 9, 28, 17, 29, 27, 786, DateTimeKind.Local).AddTicks(9414),
                            UserName = "Admin",
                            UserPwd = "Admin123456"
                        },
                        new
                        {
                            Id = 2,
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 9, 28, 17, 29, 27, 787, DateTimeKind.Local).AddTicks(1476),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 9, 28, 17, 29, 27, 787, DateTimeKind.Local).AddTicks(1478),
                            UserName = "Mr.Fang",
                            UserPwd = "Fh2269..."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}