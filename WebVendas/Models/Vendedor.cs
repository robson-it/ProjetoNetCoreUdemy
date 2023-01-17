using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebVendas.Models
{
    public class Vendedor
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegistroVenda> Vendas { get; set; } = new List<RegistroVenda>();
        

        public Vendedor() { }

        public Vendedor(int id, string name, string email, double baseSalary, DateTime birthDate, Departamento departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Departamento = departamento;
            //DepartamentoId = departamentoId;

        }

        public void AddVenda(RegistroVenda venda)
        {
            Vendas.Add(venda);
        }

        public void RemoveVenda(RegistroVenda venda)
        {
            Vendas.Remove(venda);
        }

        public double TotalVendas(DateTime inicio, DateTime fim)
        {
            return Vendas.Where(venda => venda.Date >= inicio && venda.Date <= fim).Sum(venda => venda.Amount);
        }
    }
}
