using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebVendas.Models;
using Microsoft.EntityFrameworkCore;
using WebVendas.Services.Exceptions;

namespace WebVendas.Services
{
    public class VendedorServico
    {
        private readonly WebVendasContext _context;

        public VendedorServico(WebVendasContext context)
        {
            _context = context;
        }

        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }    

        public async Task InsertAsync(Vendedor objeto)
        {
            _context.Add(objeto);
            await _context.SaveChangesAsync();
        }

        public async Task <Vendedor> FindByIdAsync(int id)
        {
            return await _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync (int id)
        {
            var obj = await _context.Vendedor.FindAsync(id);
            _context.Vendedor.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync (Vendedor obj)
        {
            bool existe = await _context.Vendedor.AnyAsync(x => x.Id == obj.Id);
            if (!existe)
            {
                throw new NotFoundException("Id not Found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
           
        }
}
}
