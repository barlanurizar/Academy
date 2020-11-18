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
    public class ProductIndexModel : PageModel
    {
        private readonly AcademyEnterprise.Data.AcademyEnterpriseContext _context;

        public ProductIndexModel(AcademyEnterprise.Data.AcademyEnterpriseContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
