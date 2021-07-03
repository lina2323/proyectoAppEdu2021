using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppProyecEstut.Models;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace AppProyecEstut.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("Denegado")]
        public IActionResult Denegado()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Welcome()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        public IActionResult Privado()
        {
            return View();
        }

        public IActionResult QuienesSomos()
        {
            return View();
        }

        public IActionResult Actividades()
        {
            return View();
        }

        public IActionResult Contactenos()
        {
            return View();
        }

        public IActionResult Estudiantes()
        {
            return View();
        }
        //--------------------------------------------autenticacion
        [HttpGet("Login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Validar(string username, string password, string returnUrl)

        {
            // Lectura de la base de datos y validacion
            var db = new tallersena588Context();
            var usuarioLogeado = db.Usuarios.FirstOrDefault(u => u.Apodo == username && u.Contraseña == password);


            if (usuarioLogeado != null)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("username", usuarioLogeado.Apodo));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, username));
                claims.Add(new Claim(ClaimTypes.Name, usuarioLogeado.Nombre));
                claims.Add(new Claim(ClaimTypes.Role, usuarioLogeado.Rol));
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                Console.WriteLine(returnUrl);
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewData["ReturnUrl"] = returnUrl;
                TempData["Error"] = " El usuario o la contraseña no son validos";
                return View("Login");
            }

        }



        [Authorize]

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        //------------------------------------------------------
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}



