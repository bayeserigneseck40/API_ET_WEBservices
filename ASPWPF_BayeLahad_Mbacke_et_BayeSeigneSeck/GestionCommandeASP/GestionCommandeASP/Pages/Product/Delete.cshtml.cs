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
using Microsoft.Data.SqlClient;

namespace GestionCommandeASP.Pages.Product
{
    public class DeleteModel : PageModel
    {        
        private readonly GestionCommandeASP.Data.ProductContext _context;

        public DeleteModel(GestionCommandeASP.Data.ProductContext context)
        {
            _context = context;
           
        }

        [BindProperty]
        public Products Products { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Products = await _context.Products.FirstOrDefaultAsync(m => m.ProductID == id);
           

            if (Products == null)
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

            Products = await _context.Products.FindAsync(id);
        

            if (Products != null)
            {
               
               _context.Products.Remove(Products);
               await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
