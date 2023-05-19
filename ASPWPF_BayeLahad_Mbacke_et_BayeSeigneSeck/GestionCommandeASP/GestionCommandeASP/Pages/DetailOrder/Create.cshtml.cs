#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GestionCommandeASP.Data;
using GestionCommandeASP.models;

namespace GestionCommandeASP.Pages.DetailOrder
{
    public class CreateModel : PageModel
    {
        private readonly GestionCommandeASP.Data.OrderDContext _context;

        public CreateModel(GestionCommandeASP.Data.OrderDContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Order_Details Order_Details { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Order_Details.Add(Order_Details);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
