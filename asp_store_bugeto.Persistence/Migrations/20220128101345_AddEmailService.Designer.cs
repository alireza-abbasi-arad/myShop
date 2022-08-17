﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asp_store_bugeto.Persistence.Contexts;

namespace asp_store_bugeto.Persistence.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20220128101345_AddEmailService")]
    partial class AddEmailService
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("asp_store_bugeto.Domain.Entities.Commons.Temp", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Removetime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Temps");
                });

            modelBuilder.Entity("asp_store_bugeto.Domain.Entities.Emails.Email", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("SenderEmailId")
                        .HasColumnType("bigint");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SenderEmailId");

                    b.HasIndex("Subject")
                        .IsUnique()
                        .HasFilter("[Subject] IS NOT NULL");

                    b.ToTable("Emails");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Subject = "بازیابی گذرواژه",
                            Text = "<a href= $link >بازیابی گذرواژه</a>",
                            Titel = "بازیابی گذرواژه",
                            URL = "Authentication/resetpassword"
                        },
                        new
                        {
                            Id = 2L,
                            Subject = "تایید ایمیل",
                            Text = "<a href= $link >تایید ایمیل</a>",
                            Titel = "تایید ایمیل",
                            URL = "Authentication/verifyemail"
                        });
                });

            modelBuilder.Entity("asp_store_bugeto.Domain.Entities.Emails.SenderEmail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Removetime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AddressEmail")
                        .IsUnique()
                        .HasFilter("[AddressEmail] IS NOT NULL");

                    b.ToTable("SenderEmails");
                });

            modelBuilder.Entity("asp_store_bugeto.Domain.Entities.Emails.SentEmail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("SendingTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SentEmails");
                });

            modelBuilder.Entity("asp_store_bugeto.Domain.Entities.Users.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 10L,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 11L,
                            Name = "Operator"
                        },
                        new
                        {
                            Id = 12L,
                            Name = "Customer"
                        });
                });

            modelBuilder.Entity("asp_store_bugeto.Domain.Entities.Users.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Removetime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("asp_store_bugeto.Domain.Entities.Users.UserInRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserInRoles");
                });

            modelBuilder.Entity("asp_store_bugeto.Domain.Entities.Emails.Email", b =>
                {
                    b.HasOne("asp_store_bugeto.Domain.Entities.Emails.SenderEmail", "SenderEmail")
                        .WithMany("Emails")
                        .HasForeignKey("SenderEmailId");

                    b.Navigation("SenderEmail");
                });

            modelBuilder.Entity("asp_store_bugeto.Domain.Entities.Users.UserInRole", b =>
                {
                    b.HasOne("asp_store_bugeto.Domain.Entities.Users.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("asp_store_bugeto.Domain.Entities.Users.User", "User")
                        .WithMany("UserInRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("asp_store_bugeto.Domain.Entities.Emails.SenderEmail", b =>
                {
                    b.Navigation("Emails");
                });

            modelBuilder.Entity("asp_store_bugeto.Domain.Entities.Users.User", b =>
                {
                    b.Navigation("UserInRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
