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

using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace Canoe.Models
{
    public class CustomerModel
    {

        // Primary Key
        public int CustomerId { get; set; }

        // Properties
        public string? CustomerName { get; set; }
        public string? CustomerLegalName { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerPhone { get; set;}

        public string? CustomerCity { get; set; }
        public string? CustomerCountry { get; set;}
        public string? CustomerState {  get; set; }
        public string? CustomerZipCode { get; set; }
        public string? CustomerTimeZone { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime LastModifiedDate { get; set; }

        // ForeginKey

        // Customers can only have one organization, Organizations can have many customers (One-to-Many)
        public OrganizationModel? ResponsibleOrg { get; set; }

        // Customers are created by users, Users can create many Custoners (One-to-many)
        public UserModel? CreatedBy { get; set; }

        // Customers can have many contacts, Contacts can only be part of one customer (One-to-Many)

        public ICollection<ContactModel>? Contacts { get; set; }



    }
}
