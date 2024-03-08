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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Canoe.Models;

namespace Canoe.Data
{
    public class CanoeContext : DbContext
    {
        public CanoeContext (DbContextOptions<CanoeContext> options)
            : base(options)
        {
        }

        public DbSet<Canoe.Models.UserModel> UserModel { get; set; } = default!;
        public DbSet<Canoe.Models.GroupModel> GroupModel { get; set; } = default!;
        public DbSet<Canoe.Models.IssueModel> IssueModel { get; set; } = default!;
        public DbSet<Canoe.Models.OrganizationModel> OrganizationModel { get; set; } = default!;
    }
}
