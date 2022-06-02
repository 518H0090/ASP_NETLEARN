using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Basic.Data;
using Razor_Basic.Models;

namespace Razor_Basic.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly Razor_Basic.Data.ApplicationDbContext _context;

        public IndexModel(Razor_Basic.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.employees != null)
            {
                Employee = await _context.employees.ToListAsync();
            }
        }
    }
}
