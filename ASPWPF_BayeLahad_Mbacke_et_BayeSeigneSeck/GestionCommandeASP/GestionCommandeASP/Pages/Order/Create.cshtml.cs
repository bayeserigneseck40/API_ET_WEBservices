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
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;

namespace GestionCommandeASP.Pages.Order
{
    public class CreateModel : PageModel
    {
        SqlConnection conn = new SqlConnection("Data source=DESKTOP-V2E4DNM;Initial Catalog=northwind;Integrated Security=true");
        private readonly GestionCommandeASP.Data.OrderContext _context;
        private readonly GestionCommandeASP.Data.ProductContext _context1;
        private readonly GestionCommandeASP.Data.OrderDContext _context2;

        public CreateModel(GestionCommandeASP.Data.OrderContext context, GestionCommandeASP.Data.OrderDContext context1, GestionCommandeASP.Data.ProductContext context2)
        {
            _context = context;
             _context2=context1;
            _context1=context2;
    }
       


        [BindProperty]
        public Orders Orders { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            _context.Orders.Add(Orders);
            await _context.SaveChangesAsync();
            return RedirectToPage("/DetailOrder/Index");
        }


        public Order_Details Order_Details { get; set; }

        public async Task<IActionResult> OnGetAsync(int idprod, int price, int qte)
        {
            try
            {
                int i = idprod;
                int p = price;
                int q = qte;
               

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select max(OrderID) from Orders";
                conn.Open();
                IDataReader reader = cmd.ExecuteReader();
                //cmd.ExecuteNonQuery();
                reader.Read();
               String max = Convert.ToString(reader.GetValue(1));
                conn.Close();

                cmd.CommandText = "insert into  Order_Details values (' " + int.Parse(max) + "',' " + i + "',' " + p + "',' " + q + "',0)";
                    //cmd.CommandText = "Update Products set UnitsInStock=UnitsInStock-(' " + q + "') where ProductID=' " + i + "'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                
                
                //_context2.Order_Details.Add(Order_Details);
                await _context2.SaveChangesAsync();
                cmd.CommandText = "Update Products set UnitsInStock=UnitsInStock-(' " + q + "') where ProductID=' " + i + "'";
                //cmd.CommandText = "Update Products set UnitsInStock=UnitsInStock-(' " + q + "') where ProductID=' " + i + "'";
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                //_context2.Order_Details.Add(Order_Details);
                await _context.SaveChangesAsync();

               
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
            return Page();

        }

         
        }
    }

