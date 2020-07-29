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
    public class IndexModel : PageModel
    {
        private readonly Assignment4.Data.AppDbContext _context;

        public IndexModel(Assignment4.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Sport> Sport { get;set; }

        public async Task OnGetAsync()
        {
            Sport = await _context.Sport.ToListAsync();
        }
    }
}
