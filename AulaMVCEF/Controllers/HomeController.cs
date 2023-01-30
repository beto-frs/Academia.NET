using AulaMVCEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AulaMVCEF.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Pessoas()
        {
            Contexto contexto = new Contexto();

            List<PessoaModel> pessoas = 
                (
                from PessoaModel p in contexto.Pessoas select p)
                .Include(e=>e.Emails)
                .ToList<PessoaModel>();

            return View(pessoas);
        }

        [HttpGet]
        public IActionResult PessoaId(int id)
        {
            Contexto contexto = new();
            PessoaModel? p = contexto.Pessoas.Find(id);
            return View(p);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(PessoaModel p)
        {
            Contexto contexto = new Contexto();
            contexto.Pessoas.Add(p);
            contexto.SaveChanges();

            return RedirectToAction("PessoaId", new {id=p.Id});
        }

    }
}
