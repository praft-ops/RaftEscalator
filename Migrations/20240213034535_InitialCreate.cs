
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

#nullable disable

namespace RaftEscalator.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            //Create the User Table

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false), //GroupModel Foregin Key
                    OrgId = table.Column<int>(type: "int", nullable: false) // OrgId Foregin Key

                },

                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.UserId); // Primary Key

                }

                );

            // Create the Group Table

            migrationBuilder.CreateTable(
                name: "GroupModel",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "string", nullable: true),
                    IsStageOne = table.Column<bool>(type: "string", nullable: true),
                    IsStageTwo = table.Column<bool>(type: "boolean", nullable: true),
                    IsStageThree = table.Column<bool>(type: "boolean", nullable: true),
                    IsStageFour = table.Column<bool>(type: "boolean", nullable: true),
                    IsStageFive = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrgId = table.Column<int>(type: "int", nullable: false) // OrgId Foregin Key


                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupModel", x => x.GroupId);



                })
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserModel");
        }
    }
}
