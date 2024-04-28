using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace to_do.Pages.Incomes
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Income> Income { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Income = await _context.Incomes
                .Include(i => i.Category).ToListAsync();
        }
    }
}
