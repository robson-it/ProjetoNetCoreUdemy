using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebVendas.Models
{
    public class Vendedor
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Requerido")]
        [StringLength(60,MinimumLength = 3,ErrorMessage ="{0} O tamanho do nome deve ser entre {2} e {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} Requerido")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Digite um e-mail valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} Requerido")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} Requerido")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        [Range(100.0, 50000.0, ErrorMessage = "O {0} deve estar entre {1} e {2}")]
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
