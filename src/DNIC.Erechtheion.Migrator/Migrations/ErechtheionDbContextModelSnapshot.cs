﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace DNIC.Erechtheion.Migrator.Migrations
{
    [DbContext(typeof(ErechtheionDbContext))]
    partial class ErechtheionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DNIC.Erechtheion.Domain.Entities.AbstractContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ChannelId");

                    b.Property<string>("Content");

                    b.Property<int>("ContentType");

                    b.Property<DateTime?>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<int>("DenyCount");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<int>("LikeCount");

                    b.Property<string>("Slug");

                    b.Property<int>("State");

                    b.Property<string>("Title");

                    b.Property<int>("ViewCount");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.ToTable("AbstractContent");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AbstractContent");
                });

            modelBuilder.Entity("DNIC.Erechtheion.Domain.Entities.Analytics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Analytics");
                });

            modelBuilder.Entity("DNIC.Erechtheion.Domain.Entities.Channel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BgColor")
                        .HasMaxLength(100);

                    b.Property<int?>("ChannelId");

                    b.Property<string>("Class")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<bool>("Enabled");

                    b.Property<string>("Icon")
                        .HasMaxLength(100);

                    b.Property<string>("ImageClass")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Link")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Order");

                    b.Property<int>("ParentId");

                    b.Property<string>("Slug")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("DNIC.Erechtheion.Domain.Entities.ErechtheionUser", b =>
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

            modelBuilder.Entity("DNIC.Erechtheion.Domain.Entities.Reply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<Guid>("ContentId");

                    b.Property<DateTime?>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<int>("Target");

                    b.Property<Guid>("TargetId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted")
                        .HasName("IDX_IsDeleted");

                    b.ToTable("Replies");
                });

            modelBuilder.Entity("DNIC.Erechtheion.Domain.ValueObjects.ContentChannels", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AbstractContentId");

                    b.Property<long>("ChannelId");

                    b.Property<string>("ChannelName");

                    b.HasKey("Id");

                    b.HasIndex("AbstractContentId");

                    b.ToTable("ContentChannels");
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
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

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

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DNIC.Erechtheion.Domain.Entities.Topic", b =>
                {
                    b.HasBaseType("DNIC.Erechtheion.Domain.Entities.AbstractContent");

                    b.Property<bool>("Enabled");

                    b.Property<bool>("Locked");

                    b.ToTable("Topic");

                    b.HasDiscriminator().HasValue("Topic");
                });

            modelBuilder.Entity("DNIC.Erechtheion.Domain.Entities.AbstractContent", b =>
                {
                    b.HasOne("DNIC.Erechtheion.Domain.Entities.Channel")
                        .WithMany("Contents")
                        .HasForeignKey("ChannelId");
                });

            modelBuilder.Entity("DNIC.Erechtheion.Domain.Entities.Channel", b =>
                {
                    b.HasOne("DNIC.Erechtheion.Domain.Entities.Channel")
                        .WithMany("ChildNodes")
                        .HasForeignKey("ChannelId");
                });

            modelBuilder.Entity("DNIC.Erechtheion.Domain.ValueObjects.ContentChannels", b =>
                {
                    b.HasOne("DNIC.Erechtheion.Domain.Entities.AbstractContent")
                        .WithMany("Channels")
                        .HasForeignKey("AbstractContentId");
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
                    b.HasOne("DNIC.Erechtheion.Domain.Entities.ErechtheionUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DNIC.Erechtheion.Domain.Entities.ErechtheionUser")
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

                    b.HasOne("DNIC.Erechtheion.Domain.Entities.ErechtheionUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DNIC.Erechtheion.Domain.Entities.ErechtheionUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
