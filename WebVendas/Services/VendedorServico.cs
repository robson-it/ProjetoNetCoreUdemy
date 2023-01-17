using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebVendas.Models;

namespace WebVendas.Services
{
    public class VendedorServico
    {
        private readonly WebVendasContext _context;

        public VendedorServico(WebVendasContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }    
}
}
