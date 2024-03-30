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
    public class LogModel
    {
        // Primary Key
        public int LogId { get; set; }
        
        // Properties
        public string? LogHeader { get; set; }
        public string? LogBody { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime LastModifiedDate { get; set; } = DateTime.Now;

        // Issues can have many logs, a log can only be assigned to one issue

        public IssueModel? LogIssue { get; set; } //Foreign Key

        // Users can have many logs, a log can only be assigned to one user

        public UserModel? LogUser { get; set; } //Foregin Key

        // Contacts can have many logs, a log can only be assigned to one contact

        public ContactModel? LogContact { get; set; } //Foregin Key



        
    }
}
