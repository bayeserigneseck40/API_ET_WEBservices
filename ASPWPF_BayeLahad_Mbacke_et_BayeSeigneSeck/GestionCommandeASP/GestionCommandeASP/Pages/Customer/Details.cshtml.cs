﻿#nullable disable
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
    public class DetailsModel : PageModel
    {
        private readonly GestionCommandeASP.Data.CustomerContext _context;

        public DetailsModel(GestionCommandeASP.Data.CustomerContext context)
        {
            _context = context;
        }

        public Customers Customers { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customers = await _context.Customers.FirstOrDefaultAsync(m => m.CustomerID == id);

            if (Customers == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
