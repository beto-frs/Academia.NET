using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class OiGenteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MostraNome(string nome, int n = 1)
        {
            ViewData["Nome"] = "Roberto Silva";
            ViewData["Mensagem"] = "Mensagem digitada na Controller";
            ViewData["repete"] = n;
            return View();
            //return HtmlEncoder.Default.Encode($"Oi {nome}");
        }
    }
}
