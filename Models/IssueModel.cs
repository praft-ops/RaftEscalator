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



namespace RaftEscalator.Models
{
    public class IssueModel
    {
        // Primary Key
        public int IssueId { get; set; }
        public string? IssueName { get; set; }
        public string? IssueDescription { get; set; }
        public bool IssueResolved { get; set; }

        public bool IssueStageOne { get; set;}
        public bool IssueStageTwo { get; set; }
        public bool IssueStageThree { get; set; }
        public bool IssueStageFour { get; set; }
        public bool IssueStageFive { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        // Foregin Keys

        //Define one-to-one relationship to users
        public UserModel? Users { get; set; }
    }
}
