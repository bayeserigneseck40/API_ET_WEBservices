#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestionCommandeASP.models;

namespace GestionCommandeASP.Data
{
    public class DetailContext : DbContext
    {
        public DetailContext (DbContextOptions<DetailContext> options)
            : base(options)
        {
        }

        public DbSet<GestionCommandeASP.models.Details> Details { get; set; }
        public object Order_Details { get; internal set; }
    }
}
