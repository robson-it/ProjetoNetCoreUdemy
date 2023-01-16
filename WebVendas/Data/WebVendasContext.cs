using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebVendas.Models
{
    public class WebVendasContext : DbContext
    {
        public WebVendasContext (DbContextOptions<WebVendasContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<RegistroVenda> RegistroVenda { get; set; }
    }
}
