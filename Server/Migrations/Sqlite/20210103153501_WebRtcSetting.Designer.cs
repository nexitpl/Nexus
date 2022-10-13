﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nexus.Server.Data;

namespace Nexus.Server.Migrations.Sqlite
{
    [DbContext(typeof(SqliteDbContext))]
    [Migration("20210103153501_WebRtcSetting")]
    partial class WebRtcSetting
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DeviceGroupNexusUser", b =>
                {
                    b.Property<string>("DeviceGroupsID")
                        .HasColumnType("TEXT");

                    b.Property<string>("UsersId")
                        .HasColumnType("TEXT");

                    b.HasKey("DeviceGroupsID", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("DeviceGroupNexusUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("NexusUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Nexus.Shared.Models.Alert", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedOn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("DeviceID");

                    b.HasIndex("OrganizationID");

                    b.HasIndex("UserID");

                    b.ToTable("Alerts");
                });

            modelBuilder.Entity("Nexus.Shared.Models.ApiToken", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastUsed")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Secret")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.HasIndex("Token");

                    b.ToTable("ApiTokens");
                });

            modelBuilder.Entity("Nexus.Shared.Models.CommandResult", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommandMode")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommandResults")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommandText")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("TEXT");

                    b.Property<string>("PSCoreResults")
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderConnectionID")
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderUserID")
                        .HasColumnType("TEXT");

                    b.Property<string>("TargetDeviceIDs")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeStamp")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("CommandResults");
                });

            modelBuilder.Entity("Nexus.Shared.Models.Device", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("AgentVersion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Alias")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double>("CpuUtilization")
                        .HasColumnType("REAL");

                    b.Property<string>("CurrentUser")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceGroupID")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Drives")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Is64Bit")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastOnline")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int>("OSArchitecture")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OSDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Platform")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProcessorCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PublicIP")
                        .HasColumnType("TEXT");

                    b.Property<string>("ServerVerificationToken")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tags")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalMemory")
                        .HasColumnType("REAL");

                    b.Property<double>("TotalStorage")
                        .HasColumnType("REAL");

                    b.Property<double>("UsedMemory")
                        .HasColumnType("REAL");

                    b.Property<double>("UsedStorage")
                        .HasColumnType("REAL");

                    b.Property<int>("WebRtcSetting")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("DeviceGroupID");

                    b.HasIndex("DeviceName");

                    b.HasIndex("OrganizationID");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Nexus.Shared.Models.DeviceGroup", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("DeviceGroups");
                });

            modelBuilder.Entity("Nexus.Shared.Models.EventLog", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<int>("EventType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .HasColumnType("TEXT");

                    b.Property<string>("StackTrace")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeStamp")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("EventLogs");
                });

            modelBuilder.Entity("Nexus.Shared.Models.InviteLink", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateSent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("InvitedUser")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResetUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("InviteLinks");
                });

            modelBuilder.Entity("Nexus.Shared.Models.Organization", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrganizationName")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Nexus.Shared.Models.SharedFile", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContentType")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("FileContents")
                        .HasColumnType("BLOB");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Timestamp")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("SharedFiles");
                });

            modelBuilder.Entity("Nexus.Shared.Models.NexusUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdministrator")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsServerAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("TEXT");

                    b.Property<string>("TempPassword")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserOptions")
                        .HasColumnType("TEXT");

                    b.HasIndex("OrganizationID");

                    b.HasIndex("UserName");

                    b.HasDiscriminator().HasValue("NexusUser");
                });

            modelBuilder.Entity("DeviceGroupNexusUser", b =>
                {
                    b.HasOne("Nexus.Shared.Models.DeviceGroup", null)
                        .WithMany()
                        .HasForeignKey("DeviceGroupsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nexus.Shared.Models.NexusUser", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nexus.Shared.Models.Alert", b =>
                {
                    b.HasOne("Nexus.Shared.Models.Device", "Device")
                        .WithMany("Alerts")
                        .HasForeignKey("DeviceID");

                    b.HasOne("Nexus.Shared.Models.Organization", "Organization")
                        .WithMany("Alerts")
                        .HasForeignKey("OrganizationID");

                    b.HasOne("Nexus.Shared.Models.NexusUser", "User")
                        .WithMany("Alerts")
                        .HasForeignKey("UserID");

                    b.Navigation("Device");

                    b.Navigation("Organization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Nexus.Shared.Models.ApiToken", b =>
                {
                    b.HasOne("Nexus.Shared.Models.Organization", "Organization")
                        .WithMany("ApiTokens")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Nexus.Shared.Models.CommandResult", b =>
                {
                    b.HasOne("Nexus.Shared.Models.Organization", "Organization")
                        .WithMany("CommandResults")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Nexus.Shared.Models.Device", b =>
                {
                    b.HasOne("Nexus.Shared.Models.DeviceGroup", "DeviceGroup")
                        .WithMany("Devices")
                        .HasForeignKey("DeviceGroupID");

                    b.HasOne("Nexus.Shared.Models.Organization", "Organization")
                        .WithMany("Devices")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("DeviceGroup");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Nexus.Shared.Models.DeviceGroup", b =>
                {
                    b.HasOne("Nexus.Shared.Models.Organization", "Organization")
                        .WithMany("DeviceGroups")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Nexus.Shared.Models.EventLog", b =>
                {
                    b.HasOne("Nexus.Shared.Models.Organization", "Organization")
                        .WithMany("EventLogs")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Nexus.Shared.Models.InviteLink", b =>
                {
                    b.HasOne("Nexus.Shared.Models.Organization", "Organization")
                        .WithMany("InviteLinks")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Nexus.Shared.Models.SharedFile", b =>
                {
                    b.HasOne("Nexus.Shared.Models.Organization", "Organization")
                        .WithMany("SharedFiles")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Nexus.Shared.Models.NexusUser", b =>
                {
                    b.HasOne("Nexus.Shared.Models.Organization", "Organization")
                        .WithMany("NexusUsers")
                        .HasForeignKey("OrganizationID");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Nexus.Shared.Models.Device", b =>
                {
                    b.Navigation("Alerts");
                });

            modelBuilder.Entity("Nexus.Shared.Models.DeviceGroup", b =>
                {
                    b.Navigation("Devices");
                });

            modelBuilder.Entity("Nexus.Shared.Models.Organization", b =>
                {
                    b.Navigation("Alerts");

                    b.Navigation("ApiTokens");

                    b.Navigation("CommandResults");

                    b.Navigation("DeviceGroups");

                    b.Navigation("Devices");

                    b.Navigation("EventLogs");

                    b.Navigation("InviteLinks");

                    b.Navigation("NexusUsers");

                    b.Navigation("SharedFiles");
                });

            modelBuilder.Entity("Nexus.Shared.Models.NexusUser", b =>
                {
                    b.Navigation("Alerts");
                });
#pragma warning restore 612, 618
        }
    }
}
