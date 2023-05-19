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

namespace GestionCommandeASP.Pages.Order
{
    public class DetailsModel : PageModel
    {
        private readonly GestionCommandeASP.Data.OrderContext _context;

        public DetailsModel(GestionCommandeASP.Data.OrderContext context)
        {
            _context = context;
        }

        public Orders Orders { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Orders = await _context.Orders.FirstOrDefaultAsync(m => m.OrderID == id);

            if (Orders == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
