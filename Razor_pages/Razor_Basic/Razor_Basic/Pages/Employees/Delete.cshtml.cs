﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly Razor_Basic.Data.ApplicationDbContext _context;

        public DeleteModel(Razor_Basic.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Employee Employee { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.employees == null)
            {
                return NotFound();
            }

            var employee = await _context.employees.FirstOrDefaultAsync(m => m.Id == id);

            if (employee == null)
            {
                return NotFound();
            }
            else 
            {
                Employee = employee;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.employees == null)
            {
                return NotFound();
            }
            var employee = await _context.employees.FindAsync(id);

            if (employee != null)
            {
                Employee = employee;
                _context.employees.Remove(Employee);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
