using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Assignment4.Data;
using Assignment4.Models;

namespace Assignment4.Pages.Sports
{
    public class DetailsModel : PageModel
    {
        private readonly Assignment4.Data.AppDbContext _context;

        public DetailsModel(Assignment4.Data.AppDbContext context)
        {
            _context = context;
        }

        public Sport Sport { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sport = await _context.Sport.FirstOrDefaultAsync(m => m.Id == id);

            if (Sport == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
