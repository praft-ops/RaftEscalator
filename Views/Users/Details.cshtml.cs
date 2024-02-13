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
    public class DetailsModel : PageModel
    {
        private readonly RaftEscalator.Data.RaftEscalatorContext _context;

        public DetailsModel(RaftEscalator.Data.RaftEscalatorContext context)
        {
            _context = context;
        }

        public UserModel UserModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usermodel = await _context.UserModel.FirstOrDefaultAsync(m => m.Id == id);
            if (usermodel == null)
            {
                return NotFound();
            }
            else
            {
                UserModel = usermodel;
            }
            return Page();
        }
    }
}
