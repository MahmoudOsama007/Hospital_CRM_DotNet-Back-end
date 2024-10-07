﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test1_Blue_Api.Data;

#nullable disable

namespace Test1_Blue_Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240924110602_SoftDeleteCommenInhertV5")]
    partial class SoftDeleteCommenInhertV5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Areas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            IsDeleted = false,
                            Name = "Zamalek"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            IsDeleted = false,
                            Name = "Maadi"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 1,
                            IsDeleted = false,
                            Name = "Heliopolis"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 1,
                            IsDeleted = false,
                            Name = "Nasr City"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 1,
                            IsDeleted = false,
                            Name = "Downtown"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 2,
                            IsDeleted = false,
                            Name = "Smouha"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 2,
                            IsDeleted = false,
                            Name = "Sidi Gaber"
                        },
                        new
                        {
                            Id = 8,
                            CityId = 2,
                            IsDeleted = false,
                            Name = "Montaza"
                        },
                        new
                        {
                            Id = 9,
                            CityId = 2,
                            IsDeleted = false,
                            Name = "Stanley"
                        },
                        new
                        {
                            Id = 10,
                            CityId = 2,
                            IsDeleted = false,
                            Name = "Sporting"
                        },
                        new
                        {
                            Id = 11,
                            CityId = 3,
                            IsDeleted = false,
                            Name = "Mohandessin"
                        },
                        new
                        {
                            Id = 12,
                            CityId = 3,
                            IsDeleted = false,
                            Name = "6th of October City"
                        },
                        new
                        {
                            Id = 13,
                            CityId = 3,
                            IsDeleted = false,
                            Name = "Dokki"
                        },
                        new
                        {
                            Id = 14,
                            CityId = 3,
                            IsDeleted = false,
                            Name = "Haram"
                        },
                        new
                        {
                            Id = 15,
                            CityId = 3,
                            IsDeleted = false,
                            Name = "Sheikh Zayed"
                        },
                        new
                        {
                            Id = 16,
                            CityId = 4,
                            IsDeleted = false,
                            Name = "Daraw"
                        },
                        new
                        {
                            Id = 17,
                            CityId = 4,
                            IsDeleted = false,
                            Name = "Kom Ombo"
                        },
                        new
                        {
                            Id = 18,
                            CityId = 4,
                            IsDeleted = false,
                            Name = "Edfu"
                        },
                        new
                        {
                            Id = 19,
                            CityId = 5,
                            IsDeleted = false,
                            Name = "Al Bayadiyah"
                        },
                        new
                        {
                            Id = 20,
                            CityId = 5,
                            IsDeleted = false,
                            Name = "Karnak"
                        },
                        new
                        {
                            Id = 21,
                            CityId = 5,
                            IsDeleted = false,
                            Name = "Al Mabad"
                        },
                        new
                        {
                            Id = 22,
                            CityId = 6,
                            IsDeleted = false,
                            Name = "Naama Bay"
                        },
                        new
                        {
                            Id = 23,
                            CityId = 6,
                            IsDeleted = false,
                            Name = "Ras Nasrani"
                        },
                        new
                        {
                            Id = 24,
                            CityId = 6,
                            IsDeleted = false,
                            Name = "Shark's Bay"
                        },
                        new
                        {
                            Id = 25,
                            CityId = 7,
                            IsDeleted = false,
                            Name = "El Gouna"
                        },
                        new
                        {
                            Id = 26,
                            CityId = 7,
                            IsDeleted = false,
                            Name = "Sahl Hasheesh"
                        },
                        new
                        {
                            Id = 27,
                            CityId = 7,
                            IsDeleted = false,
                            Name = "Al Kawthar"
                        },
                        new
                        {
                            Id = 28,
                            CityId = 8,
                            IsDeleted = false,
                            Name = "Al Manakh"
                        },
                        new
                        {
                            Id = 29,
                            CityId = 8,
                            IsDeleted = false,
                            Name = "Al Arab"
                        },
                        new
                        {
                            Id = 30,
                            CityId = 8,
                            IsDeleted = false,
                            Name = "Al Sharq"
                        },
                        new
                        {
                            Id = 31,
                            CityId = 9,
                            IsDeleted = false,
                            Name = "Al Arbaeen"
                        },
                        new
                        {
                            Id = 32,
                            CityId = 9,
                            IsDeleted = false,
                            Name = "Faisal"
                        },
                        new
                        {
                            Id = 33,
                            CityId = 9,
                            IsDeleted = false,
                            Name = "Ataka"
                        },
                        new
                        {
                            Id = 34,
                            CityId = 10,
                            IsDeleted = false,
                            Name = "El Salam"
                        },
                        new
                        {
                            Id = 35,
                            CityId = 10,
                            IsDeleted = false,
                            Name = "Sheikh Zayed"
                        },
                        new
                        {
                            Id = 36,
                            CityId = 10,
                            IsDeleted = false,
                            Name = "Al Sabah"
                        });
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.CallAbout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CallTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CallTypeId");

                    b.ToTable("CallAbouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CallTypeId = 1,
                            IsActive = true,
                            Name = "Product Issue"
                        },
                        new
                        {
                            Id = 2,
                            CallTypeId = 1,
                            IsActive = true,
                            Name = "Account Access"
                        },
                        new
                        {
                            Id = 3,
                            CallTypeId = 2,
                            IsActive = true,
                            Name = "Payment Method"
                        },
                        new
                        {
                            Id = 4,
                            CallTypeId = 2,
                            IsActive = true,
                            Name = "Invoice Query"
                        },
                        new
                        {
                            Id = 5,
                            CallTypeId = 3,
                            IsActive = true,
                            Name = "Service Availability"
                        });
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.CallService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CallAboutId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CallAboutId");

                    b.ToTable("CallServices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CallAboutId = 2,
                            IsActive = true,
                            Name = "Reset Password"
                        },
                        new
                        {
                            Id = 2,
                            CallAboutId = 1,
                            IsActive = true,
                            Name = "Check Order Status"
                        },
                        new
                        {
                            Id = 3,
                            CallAboutId = 3,
                            IsActive = true,
                            Name = "Update Payment Info"
                        },
                        new
                        {
                            Id = 4,
                            CallAboutId = 4,
                            IsActive = true,
                            Name = "Request Invoice Copy"
                        },
                        new
                        {
                            Id = 5,
                            CallAboutId = 5,
                            IsActive = true,
                            Name = "Check Service Location"
                        });
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.CallType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("CallTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            Name = "Technical Support"
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            Name = "Billing"
                        },
                        new
                        {
                            Id = 3,
                            IsActive = true,
                            Name = "General Inquiry"
                        });
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Cairo"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Alexandria"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Giza"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Aswan"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Luxor"
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            Name = "Sharm El-Sheikh"
                        },
                        new
                        {
                            Id = 7,
                            IsDeleted = false,
                            Name = "Hurghada"
                        },
                        new
                        {
                            Id = 8,
                            IsDeleted = false,
                            Name = "Port Said"
                        },
                        new
                        {
                            Id = 9,
                            IsDeleted = false,
                            Name = "Suez"
                        },
                        new
                        {
                            Id = 10,
                            IsDeleted = false,
                            Name = "Ismailia"
                        });
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LandLineNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientNumber")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("CityId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Test1_Blue_Api.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Test1_Blue_Api.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test1_Blue_Api.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Test1_Blue_Api.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.Area", b =>
                {
                    b.HasOne("Test1_Blue_Api.Models.City", "City")
                        .WithMany("Area")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.CallAbout", b =>
                {
                    b.HasOne("Test1_Blue_Api.Models.CallType", "CallType")
                        .WithMany()
                        .HasForeignKey("CallTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CallType");
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.CallService", b =>
                {
                    b.HasOne("Test1_Blue_Api.Models.CallAbout", "CallAbout")
                        .WithMany()
                        .HasForeignKey("CallAboutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CallAbout");
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.Customer", b =>
                {
                    b.HasOne("Test1_Blue_Api.Models.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test1_Blue_Api.Models.City", null)
                        .WithMany("customer")
                        .HasForeignKey("CityId");

                    b.HasOne("Test1_Blue_Api.Models.Company", "Company")
                        .WithMany("Customer")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.City", b =>
                {
                    b.Navigation("Area");

                    b.Navigation("customer");
                });

            modelBuilder.Entity("Test1_Blue_Api.Models.Company", b =>
                {
                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
