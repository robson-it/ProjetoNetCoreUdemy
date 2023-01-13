﻿using ProjetoUdemy.Models.Enums;
using System.Data;

namespace ProjetoUdemy.Models
{
    public class RegistroVenda
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }


        public RegistroVenda() { 
        
        }

        public RegistroVenda(int id, DateTime date, double amount, SalesStatus status, Vendedor vendedor)
        {
            Id = id;
            Date = date;
            Amount = amount;    
            Status = status;    
            Vendedor= vendedor;
        }
    }
}
