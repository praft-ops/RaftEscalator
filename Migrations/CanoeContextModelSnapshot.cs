﻿
//    <Canoe: A program for escalating issues.>
//    Copyright (C) <2024>  <Patrick Sullivan Raftery>

//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU Affero General Public License as published
//   by the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.

//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU Affero General Public License for more details.

//    You should have received a copy of the GNU Affero General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.

// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Canoe.Data;

#nullable disable

namespace Canoe.Migrations
{
    [DbContext(typeof(CanoeContext))]
    partial class CanoeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            // Using the Entity() method.Returns a entity type in the model. 
            // If the Entity is not already part of the model, a new entity type that does not have a cooresponding CLR type
            // ...Will be added to the Model.

            // // Create the User Model Entity using the overloaded entity method > Entity(String, Action<EntityTypeBuilder>)

            modelBuilder.Entity("Canoe.Models.UserModel", b =>
                {
                    // Primary Key
                    // b.Property returns a object (b) that be used to configure a property of the entity type (<int>)
                    // Value Generated On Add Configures a property to have a value generated only when saving a new entity.

                    b.Property<int>("UserId").ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    // SqlServerPropertyBuilderExtensions.UseIdentiyColum(PropertyBuilder, Int32, Int32) - Configures the Key Property
                    // to use the SQL Server IDENTITY features to generate values for new entities. (ID/Date Time on Creation)

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    // Property/Attributes

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(7)");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhone")
                        .HasColumnType("nvarchar(max)");

                    // Foregin Keys

                    b.Property<int>("Groups")
                        .HasColumnType("int");

                    b.Property<int>("Issues")
                        .HasColumnType("int");

                    b.Property<int>("Organization")
                        .HasColumnType("int");

                    //Entity Type Builder Relationships

                    b.HasKey("UserId"); //Primary Key

                    b.HasMany("Groups"); // Users can be part of many groups

                    b.HasMany("Issues"); // Users can have many issues

                    b.ToTable("UserModel"); // Map this EntityTypeBuilder to the UserModel table
                });

            // End the User Model EntityType for the modelBuilder Param

            // Create the Group Model Entity using the overloaded entity method > Entity(String, Action<EntityTypeBuilder>)
            modelBuilder.Entity("Canoe.Models.GroupModel", b =>
            {

                // Primary Key

                b.Property<int>("GroupId").ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"));

                // Property/Attributes

                b.Property<string>("GroupName")
                    .HasColumnType("ncarchar(max)");

                b.Property<bool>("IsStageOne")
                    .HasDefaultValueSql("false")
                    .HasColumnType("boolean");

                b.Property<bool>("IsStageTwo")
                    .HasDefaultValueSql("false")
                    .HasColumnType("boolean");

                b.Property<bool>("IsStageThree")
                    .HasDefaultValueSql("false")
                    .HasColumnType("boolean");

                b.Property<bool>("IsStageFour")
                    .HasDefaultValueSql("false")
                    .HasColumnType("boolean");

                b.Property<bool>("IsStageFive")
                    .HasDefaultValueSql("false")
                    .HasColumnType("boolean");

                b.Property<DateTime>("CreatedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime2(7)");

                b.Property<DateTime>("LastModifiedDate")
                    .HasColumnType("datetime2(7)");

                // Foregin Keys

                b.Property<int>("Organization")
                    .HasColumnType("int");

                b.Property<int>("Users")
                    .HasColumnType("int");

                //Entity Type Builder Relationships

                b.HasKey("GroupId"); // Primary Key

                b.HasMany("Users"); // Foregin Key

            });

            // End the Group Model EntityType for the modelBuilder Param

            // Create the Organization Model Entity using the overloaded entity method > Entity(String, Action<EntityTypeBuilder>)
            modelBuilder.Entity("Canoe.Models.OrganizationModel", b =>
            {
                // Primary Key

                b.Property<int>("OrgId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrgId"));

                // Properties/Attributes

                b.Property<string>("OrgName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("OrganizationPhone")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("OrganizationEmail")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreatedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime2(7)");

                b.Property<DateTime>("LastModifiedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime2(7)");

                // Foregin Key

                b.Property<int>("Groups")
                    .HasColumnType("int");

                // Entity Type Builder Relationships

                b.HasKey("OrgId"); // Primary Key

                b.HasMany("Groups"); // Foregin Key
            });
            // End the Creation of the Organzation Entity Builder

            // Create the Issue Model Entity using the overloaded entity method > Entity(String, Action<EntityTypeBuilder>)
            modelBuilder.Entity("Canoe.Models.IssueModel", b =>
            {
                //Primary Key Property

                b.Property<int>("IssueId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IssueId"));

                // Properties/Attributes

                b.Property<string>("IssueName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("IssueDescription")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IssueResolved")
                    .HasDefaultValueSql("false")
                    .HasColumnType("boolean");

                b.Property<bool>("IssueStageOne")
                    .HasDefaultValueSql("false")
                    .HasColumnType("boolean");

                b.Property<bool>("IssueStageTwo")
                    .HasDefaultValueSql("false")
                    .HasColumnType("boolean");

                b.Property<bool>("IssueStageThree")
                    .HasDefaultValueSql("false")
                    .HasColumnType("boolean");

                b.Property<bool>("IssueStageFour")
                    .HasDefaultValueSql("false")
                    .HasColumnType("boolean");

                b.Property<bool>("IssueStageFive")
                    .HasDefaultValueSql("false")
                    .HasColumnType("boolean");

                b.Property<bool>("IsWithinSLA")
                    .HasDefaultValueSql("false")
                    .HasColumnType("boolean");

                b.Property<DateTime>("CreatedDate")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime2(7)");

                b.Property<DateTime>("LastModifiedDate")
                  .ValueGeneratedOnAdd()
                  .HasColumnType("datetime2(7)");

                // Foregin Key

                b.Property<int>("AssignedUser")
                    .HasColumnType ("int");

                // Entity Type Builder Relationships

                b.HasKey("IssueId"); // Primary Key

            });
#pragma warning restore 612, 618
        }
    }
}
