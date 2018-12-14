﻿// <auto-generated />
using System;
using HitApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HitApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HitApp.Models.Contractor", b =>
                {
                    b.Property<int>("ContractorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContractorAdditionalNotes");

                    b.Property<string>("ContractorAddress");

                    b.Property<string>("ContractorCity");

                    b.Property<string>("ContractorCompany");

                    b.Property<string>("ContractorEmail");

                    b.Property<string>("ContractorName")
                        .IsRequired();

                    b.Property<string>("ContractorPhone");

                    b.Property<string>("ContractorService");

                    b.Property<string>("ContractorState");

                    b.Property<string>("ContractorWebsiteUrl");

                    b.Property<int?>("ContractorZip");

                    b.HasKey("ContractorId");

                    b.ToTable("Contractors");

                    b.HasData(
                        new { ContractorId = 1, ContractorAdditionalNotes = "Start 10/2, projected end date 11/2. $8,200 labor", ContractorAddress = "1234 Mian Steet", ContractorCity = "Madison", ContractorCompany = "TecTile", ContractorEmail = "tectile@live.com", ContractorName = "Jimmy McDermitt", ContractorPhone = "216-453-0983", ContractorService = "mainly Tile", ContractorState = "Ohio", ContractorZip = 44075 },
                        new { ContractorId = 2, ContractorAdditionalNotes = "Electric box,electric baseboard heaters and outlets in Kitchen island. $3,376 total", ContractorAddress = "990 Erie Road, Unit P", ContractorCity = "Eastlake", ContractorCompany = "Streb Electric", ContractorEmail = "", ContractorName = "Kevin and Lance", ContractorPhone = "440-953-5819", ContractorService = "Electric", ContractorState = "Ohio", ContractorZip = 44095 },
                        new { ContractorId = 3, ContractorAdditionalNotes = "Works at TecTile with Jimmy", ContractorAddress = "1234 Mian Steet", ContractorCity = "Madison", ContractorCompany = "TecTile", ContractorEmail = "tectile@live.com", ContractorName = "Jamie Smith", ContractorPhone = "216-453-0983", ContractorService = "Painting", ContractorState = "Ohio", ContractorZip = 44075 }
                    );
                });

            modelBuilder.Entity("HitApp.Models.Expense", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ExpenseCost");

                    b.Property<DateTime>("ExpenseDatePurchased");

                    b.Property<string>("ExpenseName")
                        .IsRequired();

                    b.Property<string>("ExpenseNotes");

                    b.Property<string>("ProductUrl");

                    b.Property<int>("ProjectId");

                    b.HasKey("ExpenseId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new { ExpenseId = 1, ExpenseCost = 1039.35, ExpenseDatePurchased = new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), ExpenseName = "Vanity", ExpenseNotes = "60 in. Vanity, Home Depot", ProductUrl = "https://www.homedepot.com/p/Home-Decorators-Collection-Sonoma-60-in-W-x-22-in-D-Double-Bath-Vanity-in-White-with-Carrara-Marble-Top-with-White-Basins-8105300410/205866623", ProjectId = 1 },
                        new { ExpenseId = 2, ExpenseCost = 95.96, ExpenseDatePurchased = new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), ExpenseName = "Bath Towel Set", ExpenseNotes = "Bronze towel bar set from Home Depot", ProjectId = 1 },
                        new { ExpenseId = 3, ExpenseCost = 107.74, ExpenseDatePurchased = new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), ExpenseName = "Mirror", ExpenseNotes = "2 mirrors for vanity", ProjectId = 1 },
                        new { ExpenseId = 4, ExpenseCost = 372.14, ExpenseDatePurchased = new DateTime(2018, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), ExpenseName = "Tile", ExpenseNotes = "From Home Depot", ProductUrl = "https://www.homedepot.com/p/TrafficMASTER-Portland-Stone-Beige-18-in-x-18-in-Glazed-Ceramic-Floor-and-Wall-Tile-17-44-sq-ft-case-PT011818HD1PV/205897841", ProjectId = 1 },
                        new { ExpenseId = 5, ExpenseCost = 90.0, ExpenseDatePurchased = new DateTime(2018, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), ExpenseName = "Paint", ExpenseNotes = "BEHR MARQUEE 2 gal. #780F-4 Sparrow One-Coat Hide Satin Enamel Interior Paint and Primer in One", ProjectId = 1 },
                        new { ExpenseId = 6, ExpenseCost = 150.0, ExpenseDatePurchased = new DateTime(2018, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), ExpenseName = "Jamie Painting labor", ExpenseNotes = "", ProjectId = 1 },
                        new { ExpenseId = 7, ExpenseCost = 1500.0, ExpenseDatePurchased = new DateTime(2018, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ExpenseName = "Jimmy Tile/construction labor", ExpenseNotes = "", ProjectId = 1 },
                        new { ExpenseId = 8, ExpenseCost = 2250.89, ExpenseDatePurchased = new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), ExpenseName = "Electric labor", ExpenseNotes = "", ProjectId = 4 },
                        new { ExpenseId = 9, ExpenseCost = 2470.12, ExpenseDatePurchased = new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), ExpenseName = "Electric labor", ExpenseNotes = "", ProjectId = 3 },
                        new { ExpenseId = 10, ExpenseCost = 1970.68, ExpenseDatePurchased = new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), ExpenseName = "total expenses labor", ExpenseNotes = "", ProjectId = 2 }
                    );
                });

            modelBuilder.Entity("HitApp.Models.FilePath", b =>
                {
                    b.Property<int>("FilePathId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .HasMaxLength(255);

                    b.Property<int>("FileType");

                    b.Property<int>("ProjectId");

                    b.HasKey("FilePathId");

                    b.HasIndex("ProjectId");

                    b.ToTable("FilePaths");
                });

            modelBuilder.Entity("HitApp.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectDescription");

                    b.Property<DateTime?>("ProjectEndDate");

                    b.Property<bool>("ProjectIsOnDashboard");

                    b.Property<string>("ProjectName");

                    b.Property<string>("ProjectOwnerId");

                    b.Property<DateTime>("ProjectStartDate");

                    b.Property<double>("ProjectTotalBudget");

                    b.Property<double>("ProjectTotalExpenses");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(
                        new { ProjectId = 1, ProjectDescription = "Paint and re-tile bathroom walls and floors", ProjectEndDate = new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectIsOnDashboard = true, ProjectName = "Upstairs Bathroom", ProjectOwnerId = "ec8ee904-0427-43ee-8468-ed5700fa4c32", ProjectStartDate = new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectTotalBudget = 5000.0, ProjectTotalExpenses = 0.0 },
                        new { ProjectId = 2, ProjectDescription = "Paint and re-tile bathroom walls and floors. New toilet and small corner vanity.", ProjectEndDate = new DateTime(2018, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectIsOnDashboard = false, ProjectName = "Downstairs Bathroom", ProjectOwnerId = "ec8ee904-0427-43ee-8468-ed5700fa4c32", ProjectStartDate = new DateTime(2018, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectTotalBudget = 2400.0, ProjectTotalExpenses = 0.0 },
                        new { ProjectId = 3, ProjectDescription = "Paint and re-finish wood floors. Electricty in island and other new appliances", ProjectEndDate = new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectIsOnDashboard = true, ProjectName = "Kitchen", ProjectOwnerId = "ec8ee904-0427-43ee-8468-ed5700fa4c32", ProjectStartDate = new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectTotalBudget = 4000.0, ProjectTotalExpenses = 0.0 },
                        new { ProjectId = 4, ProjectDescription = "Take out part of basement wall, add baseboard heaters", ProjectEndDate = new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectIsOnDashboard = true, ProjectName = "Basement", ProjectOwnerId = "ec8ee904-0427-43ee-8468-ed5700fa4c32", ProjectStartDate = new DateTime(2018, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), ProjectTotalBudget = 2500.0, ProjectTotalExpenses = 0.0 }
                    );
                });

            modelBuilder.Entity("HitApp.Models.ProjectContractor", b =>
                {
                    b.Property<int>("ProjectContractorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractorId");

                    b.Property<int>("ProjectId");

                    b.HasKey("ProjectContractorId");

                    b.HasIndex("ContractorId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectContractors");

                    b.HasData(
                        new { ProjectContractorId = 1, ContractorId = 1, ProjectId = 1 },
                        new { ProjectContractorId = 2, ContractorId = 1, ProjectId = 2 },
                        new { ProjectContractorId = 3, ContractorId = 1, ProjectId = 3 },
                        new { ProjectContractorId = 4, ContractorId = 2, ProjectId = 2 },
                        new { ProjectContractorId = 5, ContractorId = 2, ProjectId = 3 },
                        new { ProjectContractorId = 6, ContractorId = 3, ProjectId = 1 },
                        new { ProjectContractorId = 7, ContractorId = 3, ProjectId = 2 },
                        new { ProjectContractorId = 8, ContractorId = 3, ProjectId = 3 }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HitApp.Models.Expense", b =>
                {
                    b.HasOne("HitApp.Models.Project", "Project")
                        .WithMany("Expenses")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HitApp.Models.FilePath", b =>
                {
                    b.HasOne("HitApp.Models.Project", "Project")
                        .WithMany("FilePaths")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HitApp.Models.ProjectContractor", b =>
                {
                    b.HasOne("HitApp.Models.Contractor", "Contractors")
                        .WithMany("ProjectContractors")
                        .HasForeignKey("ContractorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HitApp.Models.Project", "Projects")
                        .WithMany("ProjectContractors")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}