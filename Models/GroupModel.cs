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

using System.ComponentModel.DataAnnotations;


namespace Canoe.Models
{
    public class GroupModel
    {
        public int GroupId { get; set; }
        public string? GroupName { get; set; }
        public bool IsStageOne { get; set; }
        public bool IsStageTwo { get; set;}
        public bool IsStageThree { get; set;}
        public bool IsStageFour { get; set;}
        public bool IsStageFive { get; set;}
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set;}

        // Groups can be assigned to one organization (One to One)
        public OrganizationModel? Organization { get; set; } //Navigation Property
        
        // Groups can have many users (One-to-Many

        public ICollection<UserModel>? Users { get; set; } // Navigation Property
    }
}
