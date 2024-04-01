
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

using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore.Migrations;
using Canoe.Models;

#nullable disable

namespace Canoe.Migrations
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

                    // Foregin Key

                    GroupId = table.Column<int>(type: "int", nullable: false) // Group Id
                },

                // Define a constraint named OrganizationModel where the primary key is identified as OrgId
                constraints: table =>

                {
                    table.PrimaryKey("PK_OrganizationModel", x => x.OrgId); //Primary Key
                    table.ForeignKey("FK_OrganizationModel_GroupModel_GroupID", x => x.GroupId, "GroupModel", "GroupId");
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
                    OrgId = table.Column<int>(type: "int", nullable: false), // OrgId Foregin Key
                    UserId = table.Column<int>(type: "int", nullable: false) // UserId Foregin Key


                },

                // Create a constraint on the GroupId Column. Name the constraint GroupModel. 
                constraints: table =>

                {
                    table.PrimaryKey("PK_GroupModel", x => x.GroupId); //PrimaryKey
                    table.ForeignKey("FK_GroupModel_OrganizationModel_OrgId", x => x.OrgId, "OrganizationModel", "OrgId"); //Foreign key
                    table.ForeignKey("FK_GroupModel_UserModel_UserId", x => x.UserId, "UserModel", "UserId"); // Foregin Key


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

                    GroupId = table.Column<int>(type: "int", nullable: false),
                    IssueId = table.Column<int>(type: "int", nullable: false),
                    OrgId = table.Column<int>(type: "int", nullable: false)

                },

                // Create a constraint on the table on the user.ID column. Name the constraint PK_UserMode for the primary key
                constraints: table =>

                {
                    table.PrimaryKey("PK_UserModel", x => x.UserId); // Primary Key

                    table.ForeignKey("FK_UserModel_GroupModel_GroupId", x => x.GroupId, "GroupModel", "GroupId"); // ForeignKey
                    table.ForeignKey("FK_UserModel_IssueModel_IssueID", x => x.IssueId, "IssueModel", "IssueId"); // ForeginKey
                    
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
                    IsWithinSLA = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),

                    // Foregin Key

                    UserId = table.Column<int>(type: "int", nullable: false) //UserModel ForeginKey

                },

                // Define a constraint named IssueModel where the primary key is identified as IssueId and UserId
                constraints: table =>

                {
                    table.PrimaryKey("PK_IssueModel", x => x.IssueId); // Primary Key
                    table.ForeignKey("FK_IssueModel_UserModel_UserId", x => x.UserId, "UserModel", "UserId"); // Foreign Key
                }

                ) ;

            // End Creating Issue Table

            // Create the CustomerModel table

            migrationBuilder.CreateTable(
                //table name
                name: "CustomerModel",

                // Create a new table with the columns, CustomerId, CustomerName, CustomerLegalName, CustomerEmail, CustomerPhone, CustomerCity, Customer Country, CustomerState,
                // ... CustomerZipCode, CustomnerTimeZone, CreatedDate and LastModifiedDate)

                columns: table => new
                {
                    // Primary Key

                    CustomerId = table.Column<int> (type: "int", nullable: false)
                        .Annotation("SqlServer.Identify", "1, 1"),

                    // Attributes

                    CustomerName = table.Column<string>(type: "string", nullable: false),
                    CustomerLegalName = table.Column<string>(type: "string", nullable: false),
                    CustomerEmail = table.Column<string>(type: "string", nullable: false),
                    CustomerPhone = table.Column<string>(type: "string", nullable: false),
                    CustomerCity = table.Column<string>(type: "string", nullable: false),
                    CustomerCountry = table.Column<string>(type: "string", nullable: false),
                    CustomerState = table.Column<string>(type: "string", nullable: false),
                    CustomerZipCode = table.Column<string>(type: "string", nullable: false, maxLength: 4), // Zip Codes only a array of 5 numbers (0, 1, 2, 3, 4)
                    CustomerTimeZone = table.Column<string>(type: "string", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),

                    // Foregin Key

                    ResponsibleOrg = table.Column<int>(type: "int", nullable: false), // Organization Model ForeginKey
                    CreatedBy = table.Column<int>(type: "int", nullable: false), // User Model Foregin Key
                    Contacts = table.Column<int>(type: "int", nullable: false), // Contacts Model Foregin Key

                },

                // Define a constraint named IssueModel where the primary key is identified as IssueId and UserId
                constraints: table =>

                {
                    table.PrimaryKey("PK_CustomerModel", x => x.CustomerId); // Primary Key
                    table.ForeignKey("FK_CustomerModel_OrganizationModel_OrganizationId", x => x.ResponsibleOrg, "OrganizationModel", "OrganizationId");
                    table.ForeignKey("FK_CustomerModel_UserModel_UserId", x => x.CreatedBy, "UserModel", "UserId");
                    table.ForeignKey("FK_CustomerModel_ContactModel_ContactId", x => x.Contacts, "ContactModel", "ContactId");

                }

                );

            // End Creating the CustomerModel Table

            // Create the LogModel table

            migrationBuilder.CreateTable(
                //table name
                name: "LogModel",

                // Create a new table with the columns, LogID, LogHeader, LogBody, CreatedDate, LastModifiedDate

                columns: table => new
                {
                    // Primary Key

                    LogId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer.Identify", "1, 1"),

                    // Attributes

                    LogHeader = table.Column<string>(type: "string", nullable: false),
                    LogBody = table.Column<string>(type: "string", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifieDate = table.Column<DateTime>(type: "datetime2", nullable: false),

                    // Foregin Key

                    LogIssue = table.Column<int>(type: "int", nullable: false),
                    LogUser = table.Column<int>(type: "int", nullable: false),
                    LogContact = table.Column<int>(type: "int", nullable: false),

                },

                // Define a constraint named IssueModel where the primary key is identified as IssueId and UserId
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogModel", x => x.LogId); // Primary Key
                    table.ForeignKey("FK_LogModel_IssueModel_IssueId", x => x.LogIssue, "IssueModel", "IssueId");
                    table.ForeignKey("FK_LogModel_UserModel_UserId", x => x.LogUser, "UserModel", "UserId");
                    table.ForeignKey("FK_LogModel_ContactModel_ContactId", x => x.LogContact, "ContactModel", "ContactId");
                }

                );

            // End Creating the LogModel Table

            // Create the ActionModel table

            migrationBuilder.CreateTable(
                //table name
                name: "ActionModel",

                // Create a new table with the columns, ActionId, ActionHeader, ActionBody, ActionUser, ActionIssue,
                // CreatedDate and LastModifiedDate)

                columns: table => new
                {
                    // Primary Key
                    ActionId = table.Column<int>(type: "int", nullable: false),

                    // Attributes

                    ActionHeader = table.Column<string>(type: "string", nullable: false),
                    ActionBody = table.Column<string>(type: string, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDAte = table.Column<DateTime>(type: "datetime2", nullable: false),

                    // Foregin Key

                    ActionUser = table.Column<int>(type: "int", nullable: false),
                    ActionIssue = table.Column<int>(type: "int", nullable: false),

                },

                // Define a constraint named IssueModel where the primary key is identified as IssueId and UserId
                constraints: table =>

                {
                    table.PrimaryKey("PK_ActionModel", x => x.ActionId);
                    table.ForeignKey("FK_ActionModel_UserModel", x => x.ActionUser, "UserModel", "UserId");
                    table.ForeignKey("FK_ActionModel_IssueModel", x => x.ActionIssue, "IssueModel", "IssueId");

                }

                );

            // End Creating the ActionModel Table

            // Create the ContactModel table

            migrationBuilder.CreateTable(
                //table name
                name: "ContactModel",

                // Create a new table with the columns, ContactId, ContactAlias, ContactLast, ContactFirst, ContactPhone, ContactEmail, ContactCity,
                // CreatedDate and LastModifiedDate)

                columns: table => new
                {
                    // Primary Key
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    // Attributes
                    ContactAlias = table.Column<string>(type: "string", nullable: false),
                    ContactLast = table.Column<string>(type: "string", nullable: true),
                    ContactFirst = table.Column<string>(type: "string", nullable: true),
                    ContactPhone = table.Column<string>(type: "string", nullable: true),
                    ContactEmail = table.Column<string>(type: "string", nullable: true),
                    ContactCity = table.Column<string>(type: "string", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),

                    // Foregin Key

                    AssignedCustomer = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                },

                // Define a constraint named IssueModel where the primary key is identified as IssueId and UserId
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContacModel", x => x.ContactId);
                    table.ForeignKey("FK_ContactModel_CustomerModel_CustomerID", x => x.AssignedCustomer, "CustomerModel", "CustomerId");
                    table.ForeignKey("FK_ContactModel_UserModel_UserId", x => x.CreatedBy, "UserModel", "UserId");
                }

                );

            // End Creating the ContactModel Table

        }

        // End Creating Tables

        // Define the Down Method with the migrationBuilder context as a param
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //Drop the Organization Table

            migrationBuilder.DropTable(
                name: "OrganizationModel");

            //Drop the Group Table

            migrationBuilder.DropTable(
                name: "GroupModel");

            //Drop the User Table

            migrationBuilder.DropTable(
                name: "UserModel");

            //Drop the Issue table.

            migrationBuilder.DropTable(
                name: "IssueModel");

            //Drop the Customer Table

            migrationBuilder.DropTable(
                name: "CustomerModel");

            //Drop the Contact Tabke

            migrationBuilder.DropTable(
                name: "ContactModel");

            //Drop the Action Table

            migrationBuilder.DropTable(
                name: "ActionModel");

            // Drop the Log table

            migrationBuilder.DropTable(
                name: "LogModel");


        }
    }
}
