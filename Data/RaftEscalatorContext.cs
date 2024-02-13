using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RaftEscalator.Models;

namespace RaftEscalator.Data
{
    public class RaftEscalatorContext : DbContext
    {
        public RaftEscalatorContext (DbContextOptions<RaftEscalatorContext> options)
            : base(options)
        {
        }

        public DbSet<RaftEscalator.Models.UserModel> UserModel { get; set; } = default!;
    }
}
