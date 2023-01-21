using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebVendas.Models;
using Microsoft.EntityFrameworkCore;

namespace WebVendas.Services
{
    public class RegistroVendaServico
    {
        private readonly WebVendasContext _context;

        public RegistroVendaServico(WebVendasContext context)
        {
            _context = context;
        }

        public async Task<List<RegistroVenda>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.RegistroVenda select obj;

            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
