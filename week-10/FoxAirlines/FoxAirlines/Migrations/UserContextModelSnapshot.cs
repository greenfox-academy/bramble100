﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FoxAirlines.Entities;

namespace FoxAirlines.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoxAirlines.Models.User", b =>
                {
                    b.Property<string>("LoginName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30);

                    b.Property<DateTime>("LastAttemptedLogin");

                    b.Property<DateTime>("LastSuccesfulLogin");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("LoginName");

                    b.ToTable("Users");
                });
        }
    }
}