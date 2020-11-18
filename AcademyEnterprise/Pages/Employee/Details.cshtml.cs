using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AcademyEnterprise.Data;
using AcademyEnterprise.Models;

namespace AcademyEnterprise
{
    public class DetailsModel : PageModel
    {
        private readonly AcademyEnterprise.Data.AcademyEnterpriseContext _context;

        public DetailsModel(AcademyEnterprise.Data.AcademyEnterpriseContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.EmployeeID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
