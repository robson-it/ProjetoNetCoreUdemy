﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebVendas.Models;
using WebVendas.Models.Enum;

namespace WebVendas.Data
{
    public class SeedingService
    {

        private WebVendasContext _context;

        public SeedingService(WebVendasContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() ||
                _context.RegistroVenda.Any() ||
                _context.Vendedor.Any())
            {
                return;
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletronicos");
            Departamento d3 = new Departamento(3, "Moda");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedor s1 = new Vendedor(1, "Bob Yellow", "b.yellow@gmail.com", 1000.0, new DateTime(1998, 4, 21), d1);
            Vendedor s2 = new Vendedor(2, "Maria Green", "m.green@gmail.com", 3500, new DateTime(1979, 12, 31), d2);
            Vendedor s3 = new Vendedor(3, "Alex Grey", "a.grey@gmail.com", 2200, new DateTime(1988, 1, 15), d1);
            Vendedor s4 = new Vendedor(4, "Martha Red", "m.red@gmail.com", 3000, new DateTime(1993, 11, 30), d4);
            Vendedor s5 = new Vendedor(5, "Donald Blue", "d.blue@gmail.com", 4000, new DateTime(2000, 1, 9), d3);
            Vendedor s6 = new Vendedor(6, "Alex Pink", "a.pink@gmail.com", 3000, new DateTime(1997, 3, 4), d2);

            RegistroVenda r1 = new RegistroVenda(1, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Faturada, s1);
            RegistroVenda r2 = new RegistroVenda(2, new DateTime(2018, 09, 4), 7000.0, SalesStatus.Faturada, s5);
            RegistroVenda r3 = new RegistroVenda(3, new DateTime(2018, 09, 13), 4000.0, SalesStatus.Cancelada, s4);
            RegistroVenda r4 = new RegistroVenda(4, new DateTime(2018, 09, 1), 8000.0, SalesStatus.Faturada, s1);
            RegistroVenda r5 = new RegistroVenda(5, new DateTime(2018, 09, 21), 3000.0, SalesStatus.Faturada, s3);
            RegistroVenda r6 = new RegistroVenda(6, new DateTime(2018, 09, 15), 2000.0, SalesStatus.Faturada, s1);
            RegistroVenda r7 = new RegistroVenda(7, new DateTime(2018, 09, 28), 13000.0, SalesStatus.Faturada, s2);
            RegistroVenda r8 = new RegistroVenda(8, new DateTime(2018, 09, 11), 4000.0, SalesStatus.Faturada, s4);
            RegistroVenda r9 = new RegistroVenda(9, new DateTime(2018, 09, 14), 11000.0, SalesStatus.Pendente, s6);
            RegistroVenda r10 = new RegistroVenda(10, new DateTime(2018, 09, 7), 9000.0, SalesStatus.Faturada, s6);
            RegistroVenda r11 = new RegistroVenda(11, new DateTime(2018, 09, 13), 6000.0, SalesStatus.Faturada, s2);
            RegistroVenda r12 = new RegistroVenda(12, new DateTime(2018, 09, 25), 7000.0, SalesStatus.Pendente, s3);
            RegistroVenda r13 = new RegistroVenda(13, new DateTime(2018, 09, 29), 10000.0, SalesStatus.Faturada, s4);
            RegistroVenda r14 = new RegistroVenda(14, new DateTime(2018, 09, 4), 3000.0, SalesStatus.Faturada, s5);
            RegistroVenda r15 = new RegistroVenda(15, new DateTime(2018, 09, 12), 4000.0, SalesStatus.Faturada, s1);
            RegistroVenda r16 = new RegistroVenda(16, new DateTime(2018, 10, 5), 2000.0, SalesStatus.Faturada, s4);
            RegistroVenda r17 = new RegistroVenda(17, new DateTime(2018, 10, 1), 12000.0, SalesStatus.Faturada, s1);
            RegistroVenda r18 = new RegistroVenda(18, new DateTime(2018, 10, 24), 6000.0, SalesStatus.Faturada, s3);
            RegistroVenda r19 = new RegistroVenda(19, new DateTime(2018, 10, 22), 8000.0, SalesStatus.Faturada, s5);
            RegistroVenda r20 = new RegistroVenda(20, new DateTime(2018, 10, 15), 8000.0, SalesStatus.Faturada, s6);
            RegistroVenda r21 = new RegistroVenda(21, new DateTime(2018, 10, 17), 9000.0, SalesStatus.Faturada, s2);
            RegistroVenda r22 = new RegistroVenda(22, new DateTime(2018, 10, 24), 4000.0, SalesStatus.Faturada, s4);
            RegistroVenda r23 = new RegistroVenda(23, new DateTime(2018, 10, 19), 11000.0, SalesStatus.Cancelada, s2);
            RegistroVenda r24 = new RegistroVenda(24, new DateTime(2018, 10, 12), 8000.0, SalesStatus.Faturada, s5);
            RegistroVenda r25 = new RegistroVenda(25, new DateTime(2018, 10, 31), 7000.0, SalesStatus.Faturada, s3);
            RegistroVenda r26 = new RegistroVenda(26, new DateTime(2018, 10, 6), 5000.0, SalesStatus.Faturada, s4);
            RegistroVenda r27 = new RegistroVenda(27, new DateTime(2018, 10, 13), 9000.0, SalesStatus.Pendente, s1);
            RegistroVenda r28 = new RegistroVenda(28, new DateTime(2018, 10, 7), 4000.0, SalesStatus.Faturada, s3);
            RegistroVenda r29 = new RegistroVenda(29, new DateTime(2018, 10, 23), 12000.0, SalesStatus.Faturada, s5);
            RegistroVenda r30 = new RegistroVenda(30, new DateTime(2018, 10, 12), 5000.0, SalesStatus.Faturada, s2);

            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(s1, s2, s3, s4, s5, s6);
            _context.RegistroVenda.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);
            _context.SaveChanges();
        }
    }
}
