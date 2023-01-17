using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebVendas.Models;

namespace WebVendas.Services
{
    public class DepartamentoServico
    {

        private readonly WebVendasContext _context;

        public DepartamentoServico(WebVendasContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x => x.Name).ToList();

        }

    }
}
