﻿// <auto-generated />
using System;
using DrPet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DrPet.Data.Migrations
{
    [DbContext(typeof(DrPetDbContext))]
    [Migration("20211124135833_AddIdentity")]
    partial class AddIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DrPet.Data.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<int>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("int");

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

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("DrPet.Data.Entities.AppUserWorker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkerId");

                    b.HasIndex("AppUserId", "WorkerId")
                        .IsUnique();

                    b.ToTable("AppUserWorker");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Consulting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndOfConsulting")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartOfConsulting")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkerId");

                    b.HasIndex("StartOfConsulting", "EndOfConsulting", "WorkerId")
                        .IsUnique();

                    b.ToTable("Consultings");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Medicines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Probatbicol (350mg)"
                        },
                        new
                        {
                            Id = 2,
                            DateOfCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Placebotinol (10mg)"
                        });
                });

            modelBuilder.Entity("DrPet.Data.Entities.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("VarietyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VarietyId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("DrPet.Data.Entities.PetOwnership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PetId", "OwnerId")
                        .IsUnique();

                    b.ToTable("PetOwnerships");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LatinName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Species");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LatinName = "Canis lupus familiaris",
                            Name = "Kutya"
                        },
                        new
                        {
                            Id = 2,
                            DateOfCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LatinName = "Felis catus",
                            Name = "Macska"
                        });
                });

            modelBuilder.Entity("DrPet.Data.Entities.Treatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AntecedentId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("ConsultingId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Length")
                        .HasColumnType("int");

                    b.Property<int?>("MedicineId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseStatus")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AntecedentId");

                    b.HasIndex("ConsultingId");

                    b.HasIndex("MedicineId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PetId");

                    b.HasIndex("TypeId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Treatments");
                });

            modelBuilder.Entity("DrPet.Data.Entities.TreatmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("TreatmentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Rutinvizsgálat (panasz nélkül)",
                            Price = 10000.0
                        },
                        new
                        {
                            Id = 2,
                            DateOfCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Vizsgálat (akut panaszok)",
                            Price = 12000.0
                        },
                        new
                        {
                            Id = 3,
                            DateOfCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kontrollvizsgálat",
                            Price = 8000.0
                        },
                        new
                        {
                            Id = 4,
                            DateOfCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Műtét",
                            Price = 30000.0
                        },
                        new
                        {
                            Id = 5,
                            DateOfCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gyógyszer felírása",
                            Price = 2500.0
                        });
                });

            modelBuilder.Entity("DrPet.Data.Entities.Variety", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpeciesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpeciesId");

                    b.ToTable("Varieties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Puli",
                            SpeciesId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateOfCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Labrador",
                            SpeciesId = 1
                        },
                        new
                        {
                            Id = 3,
                            DateOfCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Amerikai rövidszőrű",
                            SpeciesId = 2
                        },
                        new
                        {
                            Id = 4,
                            DateOfCreation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfUpdate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Perzsa",
                            SpeciesId = 2
                        });
                });

            modelBuilder.Entity("DrPet.Data.Entities.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("PublicDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DrPet.Data.Entities.AppUserWorker", b =>
                {
                    b.HasOne("DrPet.Data.Entities.AppUser", "AppUser")
                        .WithMany("AppUserWorkers")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrPet.Data.Entities.Worker", "Worker")
                        .WithMany("AppUserWorkers")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Consulting", b =>
                {
                    b.HasOne("DrPet.Data.Entities.Worker", "Worker")
                        .WithMany("Consultings")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Pet", b =>
                {
                    b.HasOne("DrPet.Data.Entities.Variety", "Variety")
                        .WithMany("Pets")
                        .HasForeignKey("VarietyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Variety");
                });

            modelBuilder.Entity("DrPet.Data.Entities.PetOwnership", b =>
                {
                    b.HasOne("DrPet.Data.Entities.Owner", "Owner")
                        .WithMany("PetOwnerships")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrPet.Data.Entities.Pet", "Pet")
                        .WithMany("PetOwnerships")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Treatment", b =>
                {
                    b.HasOne("DrPet.Data.Entities.Treatment", "Antecedent")
                        .WithMany("Consequences")
                        .HasForeignKey("AntecedentId");

                    b.HasOne("DrPet.Data.Entities.Consulting", "Consulting")
                        .WithMany("Treatments")
                        .HasForeignKey("ConsultingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DrPet.Data.Entities.Medicine", "Medicine")
                        .WithMany("Treatments")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DrPet.Data.Entities.Owner", "Owner")
                        .WithMany("Treatments")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DrPet.Data.Entities.Pet", "Pet")
                        .WithMany("Treatments")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DrPet.Data.Entities.TreatmentType", "Type")
                        .WithMany("Treatments")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DrPet.Data.Entities.Worker", "Worker")
                        .WithMany("Treatments")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Antecedent");

                    b.Navigation("Consulting");

                    b.Navigation("Medicine");

                    b.Navigation("Owner");

                    b.Navigation("Pet");

                    b.Navigation("Type");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Variety", b =>
                {
                    b.HasOne("DrPet.Data.Entities.Species", "Species")
                        .WithMany("Varieties")
                        .HasForeignKey("SpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Species");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("DrPet.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("DrPet.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrPet.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("DrPet.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DrPet.Data.Entities.AppUser", b =>
                {
                    b.Navigation("AppUserWorkers");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Consulting", b =>
                {
                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Medicine", b =>
                {
                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Owner", b =>
                {
                    b.Navigation("PetOwnerships");

                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Pet", b =>
                {
                    b.Navigation("PetOwnerships");

                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Species", b =>
                {
                    b.Navigation("Varieties");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Treatment", b =>
                {
                    b.Navigation("Consequences");
                });

            modelBuilder.Entity("DrPet.Data.Entities.TreatmentType", b =>
                {
                    b.Navigation("Treatments");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Variety", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("DrPet.Data.Entities.Worker", b =>
                {
                    b.Navigation("AppUserWorkers");

                    b.Navigation("Consultings");

                    b.Navigation("Treatments");
                });
#pragma warning restore 612, 618
        }
    }
}
