
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

using System.ComponentModel.DataAnnotations;

namespace Canoe.Models
{
    public class UserModel
    {
        // Primary Key
        public int UserId { get; set; }

        // Properties
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPhone { get; set; }
        public string? UserPassword { get; set;}
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; } = DateTime.MinValue;

        // Foregin Keys 

        // Users can be part of Many Groups and Groups can have many users (Many-to-Many)

        public ICollection<GroupModel>? Groups { get; set; }

        // Users can create many issues, Issues are only created by one User (One-to-Many)

        public ICollection<IssueModel>? Issues { get; set; }

        // Users can only be part of one Organization, Organizations can have many users (One-to-Many)

        public OrganizationModel? Organization { get; set; }

        // Users can create many Logs, Logs can only be created by one User (One-to-Many)

        public ICollection<LogModel>? Logs { get; set; }

        // Users can create many Actions, Actions can only be created by one User (One-to-Many)

        public ICollection<ActionModel>? Actions { get; set; }

    }
}
