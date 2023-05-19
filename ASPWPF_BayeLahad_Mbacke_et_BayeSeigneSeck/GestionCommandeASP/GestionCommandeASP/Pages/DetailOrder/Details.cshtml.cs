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
    public class DetailsModel : PageModel
    {
        private readonly GestionCommandeASP.Data.OrderDContext _context;

        public DetailsModel(GestionCommandeASP.Data.OrderDContext context)
        {
            _context = context;
        }

        public Order_Details Order_Details { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order_Details = await _context.Order_Details.FirstOrDefaultAsync(m => m.OrderID == id);

            if (Order_Details == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
