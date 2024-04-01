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


namespace Canoe.Models
{
    public class ActionModel
    {

        // Primary Key
        public int ActionId { get; set; }

        // Properties
        public string? ActionHeader { get; set; }
        public string? ActionBody { get; set; }

        public DateTime? CreatedDate { get; set; } = default(DateTime?);
        public DateTime? LastModifiedDate { get; set; }

        // Foregin Keys

        // Action can be created by a user
        public UserModel? ActionUser { get; set; }

        // Action can be assigned to a Issue
        public IssueModel? ActionIssue { get; set; }



    }
}
