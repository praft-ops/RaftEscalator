using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RaftEscalator.Data;
using RaftEscalator.Models;

namespace RaftEscalator.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly RaftEscalator.Data.RaftEscalatorContext _context;

        public CreateModel(RaftEscalator.Data.RaftEscalatorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public UserModel UserModel { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.UserModel.Add(UserModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
