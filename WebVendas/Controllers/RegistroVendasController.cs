﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebVendas.Services;

namespace WebVendas.Controllers
{
    public class RegistroVendasController : Controller
    {

        private readonly RegistroVendaServico _registroVendaServico;

        public RegistroVendasController(RegistroVendaServico registroVendaServico)
        {
            _registroVendaServico = registroVendaServico;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscaSimples(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }

            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _registroVendaServico.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        public async Task<IActionResult> BuscaAgrupada(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }

            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _registroVendaServico.FindByDateGroupAsync(minDate, maxDate);
            return View(result);
        }


    }
}