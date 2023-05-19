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
    public class DeleteModel : PageModel
    {
        private readonly GestionCommandeASP.Data.DetailContext _context;

        public DeleteModel(GestionCommandeASP.Data.DetailContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Details Details { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Details = await _context.Details.FirstOrDefaultAsync(m => m.DetailID == id);

            if (Details == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Details = await _context.Details.FindAsync(id);

            if (Details != null)
            {
                _context.Details.Remove(Details);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
