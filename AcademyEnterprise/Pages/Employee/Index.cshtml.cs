using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AcademyEnterprise.Models;

namespace AcademyEnterprise
{
    public class IndexModel : PageModel
    {
        private readonly AcademyEnterprise.Data.AcademyEnterpriseContext _context;

        public IndexModel(AcademyEnterprise.Data.AcademyEnterpriseContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
