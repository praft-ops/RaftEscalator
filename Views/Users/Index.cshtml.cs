using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RaftEscalator.Data;
using RaftEscalator.Models;

namespace RaftEscalator.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly RaftEscalator.Data.RaftEscalatorContext _context;

        public IndexModel(RaftEscalator.Data.RaftEscalatorContext context)
        {
            _context = context;
        }

        public IList<UserModel> UserModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            UserModel = await _context.UserModel.ToListAsync();
        }
    }
}
