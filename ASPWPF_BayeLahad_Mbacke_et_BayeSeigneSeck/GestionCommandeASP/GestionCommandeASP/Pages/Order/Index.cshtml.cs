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

#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionCommandeASP.Pages.Order
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration Configuration;
        private readonly GestionCommandeASP.Data.OrderContext _context;

        [BindProperty(SupportsGet = true)]
        public string Customer { get; set; }


        public IndexModel(GestionCommandeASP.Data.OrderContext context, IConfiguration configuration)
        {
           _context = context;
            Configuration = configuration;
        }


        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public IList<Orders> orders { get;set; }


        public PaginatedList<Orders> Orders { get; set; }

        public async Task OnGetAsync(string currentFilter, int? pageIndex)
        {

            if (Customer != null)
            {
                pageIndex = 1;
            }
            else
            {
                Customer = currentFilter;
            }

            CurrentFilter = Customer;
            var ods = from m in _context.Orders select m;
                if (!string.IsNullOrEmpty(Customer))
                    {
                       ods = ods.Where(s => s.CustomerID.Contains(Customer));
                    }
           //orders = await ods.ToListAsync();

            var pageSize = Configuration.GetValue("PageSize", 5);

            Orders = await PaginatedList<Orders>.CreateAsync(
                ods.AsNoTracking(), pageIndex ?? 1, pageSize);

        }
    }

}
