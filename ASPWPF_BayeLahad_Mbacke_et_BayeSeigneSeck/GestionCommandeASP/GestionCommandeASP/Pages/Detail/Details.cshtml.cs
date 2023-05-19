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
    public class DetailsModel : PageModel
    {
        private readonly GestionCommandeASP.Data.DetailContext _context;

        public DetailsModel(GestionCommandeASP.Data.DetailContext context)
        {
            _context = context;
        }

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
    }
}
