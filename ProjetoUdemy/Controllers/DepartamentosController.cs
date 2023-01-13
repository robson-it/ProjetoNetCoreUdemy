using Microsoft.AspNetCore.Mvc;
using ProjetoUdemy.Models;

namespace ProjetoUdemy.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Name = "Eletronicos" });
            list.Add(new Departamento { Id = 2, Name = "Financeiro" });
            return View(list);
        }
    }
}
