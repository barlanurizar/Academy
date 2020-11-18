using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AcademyEnterprise.Models;

namespace AcademyEnterprise
{
    public class EnrollmentDetailsModel : PageModel
    {
        private readonly AcademyEnterprise.Data.AcademyEnterpriseContext _context;

        public EnrollmentDetailsModel(AcademyEnterprise.Data.AcademyEnterpriseContext context)
        {
            _context = context;
        }

        public Enrollment Enrollment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Enrollment = await _context.Enrollment
                .Include(e => e.Order)
                .Include(e => e.Product).FirstOrDefaultAsync(m => m.EnrollmentID == id);

            if (Enrollment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
