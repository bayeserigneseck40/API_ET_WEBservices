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

namespace GestionCommandeASP.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly GestionCommandeASP.Data.ProductContext _context;
        private readonly IConfiguration Configuration;

        [BindProperty(SupportsGet = true)]
        public string ProductName { get; set; }

        public IndexModel(GestionCommandeASP.Data.ProductContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
       // public IList<Products> Products { get;set; }

        public PaginatedList<Products> Products { get; set; }
        public async Task OnGetAsync(string currentFilter, int? pageIndex)
        {

            if (ProductName != null)
            {
                pageIndex = 1;
            }
            else
            {
                ProductName = currentFilter;
            }

            CurrentFilter = ProductName;
            // Products = await _context.Products.ToListAsync();
            var pdts = from m in _context.Products select m;
            if (!string.IsNullOrEmpty(ProductName))
            {
                pdts = pdts.Where(s => s.ProductName.Contains(ProductName));
            }
            //orders = await ods.ToListAsync();

            var pageSize = Configuration.GetValue("PageSize", 10);

            Products = await PaginatedList<Products>.CreateAsync(
                pdts.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}
