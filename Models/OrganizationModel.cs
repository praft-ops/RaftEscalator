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

namespace RaftEscalator.Models
{
    public class OrganizationModel
    {
        //Primary Key
        public int OrgId { get; set; }
        public string? OrgName { get; set; }
        public string? OrganizationPhone { get; set; }
        public string? OrganizationEmail { get; set; }
        public DateTime CreatedDate { get; set; }  
        public DateTime LastModifiedDate { get; set; }

        //Foreign Keys

        // Organizations can have many groups (one-to-many)
        public ICollection<GroupModel>? Groups { get; set; } // Navigation Property.

    }
}
