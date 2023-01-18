﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebVendas.Models;
using WebVendas.Models.ViewModel;
using WebVendas.Services;

namespace WebVendas.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorServico _vendedorServico;
        private readonly DepartamentoServico _departamentosServico;

        public VendedoresController(VendedorServico vendedorServico, DepartamentoServico departamentoServico)
        {
            _vendedorServico = vendedorServico;
            _departamentosServico = departamentoServico;
        }

        public IActionResult Index()
        {
            var list = _vendedorServico.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departamentos = _departamentosServico.FindAll();
            var viewModel = new VendedorFormViewModel { Departamentos = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedorServico.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _vendedorServico.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete (int id)
        {
            _vendedorServico.Remove(id);

            return RedirectToAction(nameof(Index));
        }
    }
}