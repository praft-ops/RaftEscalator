
//    <Raft Escalator: A program for escalating issues.>
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

using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore.Migrations;
using RaftEscalator.Models;

#nullable disable

namespace RaftEscalator.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        /// 
        // Initiate the migration using the migrationBuilder object passed as a agrument into the Up function. 
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            // Create the Organization Table

            migrationBuilder.CreateTable(
                // Table Name
                name: "OrganizationModel",

                // Create a new table with the columns, OrgId, OrgName, OrganizationPhone, OrganizationEmail, CreatedDate, LastModified Date. 
                columns: table => new

                {
                    // Primary Key

                    OrgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer.Identify", "1, 1"),

                    // Attributes

                    OrgName = table.Column<string>(type: "string", nullable: false),
                    OrganizationPhone = table.Column<string>(type: "string", nullable: true),
                    OrganizationEmail = table.Column<string>(type: "string", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                },

                // Define a constraint named OrganizationModel where the primary key is identified as OrgId
                constraints: table =>

                {
                    table.PrimaryKey("OrganizationModel", x => x.OrgId); //Primary Key
                    // No Foregin Key. Top level data
                }

                );

            // End Creating Organization table

            // Create the Group Table

            migrationBuilder.CreateTable(
                // Table name
                name: "GroupModel",

                // Create new table with columns GroupId, GroupName, IsStageOne, IsStageTwo, IsStageThree, IsStageFrour, IsStageFive
                //...CreatedDate, LastModifiedDate and OrgId

                columns: table => new

                {

                    // Primary Key

                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    // Attibutes

                    GroupName = table.Column<string>(type: "string", nullable: true),
                    IsStageOne = table.Column<bool>(type: "string", nullable: true),
                    IsStageTwo = table.Column<bool>(type: "boolean", nullable: true),
                    IsStageThree = table.Column<bool>(type: "boolean", nullable: true),
                    IsStageFour = table.Column<bool>(type: "boolean", nullable: true),
                    IsStageFive = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),

                    // Foregin Key
                    OrgId = table.Column<int>(type: "int", nullable: false) // OrgId Foregin Key


                },

                // Create a constraint on the GroupId Column. Name the constraint GroupModel. 
                constraints: table =>

                {
                    table.PrimaryKey("PK_GroupModel", x => x.GroupId); //PrimaryKey
                    table.ForeignKey("FK_GroupModel_OrganizationModel_OrgId", x => x.OrgId, "OrganizationModel", "OrgId"); //Foreign key


                }

                );

            // End Creating group Table

            //Create the User Table

            migrationBuilder.CreateTable(
                // Table Name
                name: "UserModel",

                // Create new table with columns UserID, UserFirstName, UserLastName, UserEmail, UserPhone, UserPassword
                // ...CreatedDate, Last ModifiedDate, and GroupID

                columns: table => new
                {
                    // Primary Key

                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    // Attributes

                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    
                    //Foregin Key

                    GroupId = table.Column<int>(type: "int", nullable: false)

                },

                // Create a constraint on the table on the user.ID column. Name the constraint PK_UserMode for the primary key
                constraints: table =>

                {
                    table.PrimaryKey("PK_UserModel", x => x.UserId); // Primary Key
                    table.ForeignKey("FK_UserModel_GroupModel_GroupId", x => x.GroupId, "GroupModel", "GroupId"); // ForeignKey
                }

                );
            // End Creatung User Table

            // Create the Issues table

            migrationBuilder.CreateTable(
                //table name
                name: "IssueModel",

                // Create a new table with the columns, IssueId, IssueName, IssueDescription, IssueResolved, IssueStageOne, IssueStageTwo, IssueStageFour, IssueStageFive
                // CreatedDate and LastModifiedDate)

                columns: table => new
                {
                    // Primary Key

                    IssueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer.Identify", "1, 1"),

                    // Attributes

                    IssueName = table.Column<string>(type: "string", nullable: false),
                    IssueDescription = table.Column<string>(type: "string", nullable: false),
                    IssueResolved = table.Column<bool>(type: "boolean", nullable: false),
                    IssueStageOne = table.Column<bool>(type: "boolean", nullable: true),
                    IssueStageTwo = table.Column<bool>(type: "boolean", nullable: true),
                    IssueStageThree = table.Column<bool>(type: "boolean", nullable: true),
                    IssueStageFour = table.Column<bool>(type: "boolean", nullable: true),
                    IssueStageFive = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),

                    // Foregin Key

                    UserId = table.Column<int>(type: "int", nullable: false) //UserModel ForeginKey

                },

                // Define a constraint named IssueModel where the primary key is identified as IssueId
                constraints: table =>

                {
                    table.PrimaryKey("PK_IssueModel", x => x.IssueId); // Primary Key
                    table.ForeignKey("FK_IssueModel_UserModel)UserId", x => x.UserId, "UserModel", "UserId"); // Foreign Key
                }

                ); ;

            // End Creating Issue Table

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserModel");
        }
    }
}
