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
    public class ContactModel
    {

        // Primary Key
        public int ContactId { get; set; }

        //Properties
        public string? ContactAlias { get; set; }
        public string? ContactLast {  get; set; }
        public string? ContactFirst { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactCity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }


        //Foregin Key

        // Contacts can only be assigned to one customer, Customers can have many contacts (One-to-many)
        public CustomerModel? AssignedCustomer { get; set; }

        // Contacts can by be created by a user, Users can create many contacts
        public UserModel? CreatedBy { get; set; }

    }
}
