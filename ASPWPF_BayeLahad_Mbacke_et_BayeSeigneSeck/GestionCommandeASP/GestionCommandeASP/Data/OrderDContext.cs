#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestionCommandeASP.models;

namespace GestionCommandeASP.Data
{
    public class OrderDContext : DbContext
    {
        public OrderDContext (DbContextOptions<OrderDContext> options)
            : base(options)
        {
        }

        public DbSet<GestionCommandeASP.models.Order_Details> Order_Details { get; set; }
    }
}
