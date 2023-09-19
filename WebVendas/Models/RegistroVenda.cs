using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebVendas.Models.Enum;

namespace WebVendas.Models
{
    public class RegistroVenda
    {

        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }


        public RegistroVenda()
        {

        }

        public RegistroVenda(int id, DateTime date, double amount, SalesStatus status, Vendedor vendedor)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
