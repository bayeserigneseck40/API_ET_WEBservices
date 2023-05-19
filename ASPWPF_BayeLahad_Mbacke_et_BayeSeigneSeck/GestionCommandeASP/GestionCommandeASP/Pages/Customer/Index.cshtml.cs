#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestionCommandeASP.Data;
using GestionCommandeASP.models;

namespace GestionCommandeASP.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly GestionCommandeASP.Data.CustomerContext _context;
        private readonly IConfiguration Configuration;

        [BindProperty(SupportsGet = true)]
        public string CustomerID { get; set; }

        public IndexModel(GestionCommandeASP.Data.CustomerContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        // public IList<Products> Products { get;set; }

        public PaginatedList<Customers> Customers { get; set; }

        // public IList<Customers> Customers { get;set; }

        public async Task OnGetAsync(string currentFilter, int? pageIndex)
        {

            if (CustomerID != null)
            {
                pageIndex = 1;
            }
            else
            {
                CustomerID = currentFilter;
            }

            CurrentFilter = CustomerID;
            // Products = await _context.Products.ToListAsync();
            var cust = from m in _context.Customers select m;
            if (!string.IsNullOrEmpty(CustomerID))
            {
                cust = cust.Where(s => s.CustomerID.Contains(CustomerID));
            }
            // Customers = await _context.Customers.ToListAsync();
            var pageSize = Configuration.GetValue("PageSize", 10);

            Customers = await PaginatedList<Customers>.CreateAsync(
                cust.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}
