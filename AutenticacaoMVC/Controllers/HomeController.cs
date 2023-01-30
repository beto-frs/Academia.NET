using AutenticacaoMVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace AutenticacaoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginPage()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginPage(Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (usuario.Login == "beto" && usuario.Senha == "senha")
                    {
                        var clains = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, usuario.Login),
                            new Claim(ClaimTypes.Role, "admin"),
                        };

                        var identidade = new ClaimsIdentity(clains, "Login");

                        ClaimsPrincipal principal = new ClaimsPrincipal(identidade);
                        var regrasAutenticacao = new AuthenticationProperties
                        {
                            AllowRefresh = true,
                            ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(4),
                            IsPersistent = true
                        };

                        await HttpContext.SignInAsync(
                            CookieAuthenticationDefaults.AuthenticationScheme, 
                            principal, regrasAutenticacao);

                        ViewBag.Erro = "Login efetuado com sucesso";

                        return RedirectToAction("UserPage");


                    }
                    else
                    {
                        ViewBag.Erro = "Usuario e senha não confere...";
                    }
                }

            }
            catch (Exception ex)
            {

                ViewBag.Erro = $"Ocorreu um problema ao autenticar: Erro --> {ex.Message}";
                return View();
            }
            return View();
        }

        [Authorize]
        public IActionResult UserPage()
        {
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            //HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }

        
        
        
        
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}