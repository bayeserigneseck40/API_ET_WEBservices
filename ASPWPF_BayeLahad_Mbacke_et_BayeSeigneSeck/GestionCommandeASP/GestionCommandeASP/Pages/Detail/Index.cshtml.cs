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

namespace GestionCommandeASP.Pages.Detail
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Order { get; set; }
        private readonly GestionCommandeASP.Data.DetailContext _context;

        public IndexModel(GestionCommandeASP.Data.DetailContext context)
        {
            _context = context;
        }

        public IList<Details> Details { get;set; }

        public async Task OnGetAsync()
        {
            var detail = from m in _context.Details select m;
            if (!string.IsNullOrEmpty(Order))
            {
                detail = detail.Where(s => s.OrderID.ToString().Contains(Order));
            }

            Details = await detail.ToListAsync();
        }
    }
}
