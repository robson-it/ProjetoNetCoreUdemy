using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebVendas.Models;
using Microsoft.EntityFrameworkCore;

namespace WebVendas.Services
{
    public class DepartamentoServico
    {

        private readonly WebVendasContext _context;

        public DepartamentoServico(WebVendasContext context)
        {
            _context = context;
        }

        public async Task<List<Departamento>> FindAllAsync()
        {
            return await _context.Departamento.OrderBy(x => x.Name).ToListAsync();

        }

    }
}
