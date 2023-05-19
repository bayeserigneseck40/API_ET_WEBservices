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

namespace GestionCommandeASP.Pages.DetailOrder
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Order { get; set; }
        private readonly GestionCommandeASP.Data.OrderDContext _context;
        private readonly IConfiguration Configuration;


        public IndexModel(GestionCommandeASP.Data.OrderDContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        // public IList<Products> Products { get;set; }

        public PaginatedList<Order_Details> Order_Details { get; set; }
        // public IList<Order_Details> Order_Details { get;set; }

        public async Task OnGetAsync(string currentFilter, int? pageIndex)
        {

           
            var odd = from m in _context.Order_Details select m;
            if (!string.IsNullOrEmpty(Order))
            {
                odd = odd.Where(s => s.OrderID.ToString().Contains(Order));
            }
           // Order_Details = await odd.ToListAsync();

            var pageSize = Configuration.GetValue("PageSize", 10);

            Order_Details = await PaginatedList<Order_Details>.CreateAsync(
                odd.AsNoTracking(), pageIndex ?? 1, pageSize);
        }

    }
}
