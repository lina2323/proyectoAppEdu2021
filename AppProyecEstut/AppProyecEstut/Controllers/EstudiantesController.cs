using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppProyecEstut.Models;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;



namespace AppProyecEstut.Controllers
{
    public class EstudiantesController : Controller
    {
        public IActionResult Index(int? page)
        {
            var db = new tallersena588Context();


            var pageNumber = page ?? 1;
            var pageSize = 6;
            var estudiante = db.Estudiantes.ToPagedList(pageNumber, pageSize);
            return View(estudiante);
        }

        [Authorize]
        public IActionResult Crear()
        {
            var db = new tallersena588Context();
            //cargar los roles de la base de datos
            var listaRoles = db.Roles.ToList();
            ViewBag.Roles = listaRoles;
            return View();
        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult Crear(Estudiantes myEstudiantes)
        {
            var db = new tallersena588Context();
            var existe = db.Estudiantes.Find(myEstudiantes.Codigo);
            if (existe == null)
            {
                db.Estudiantes.Add(myEstudiantes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["msj"] = $" El Codigo { myEstudiantes.Codigo} ya Existe";
                return View();
            }
        }

        [Authorize(Roles = "admin, coordinador")]
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var db = new tallersena588Context();
            var myEstudiantes = db.Estudiantes.Find(id);
            return View(myEstudiantes);
        }

        [Authorize(Roles = "admin, coordinador")]
        [HttpPost]
        public IActionResult Editar(Estudiantes myEstudiantes)
        {
            var db = new tallersena588Context();
            var objEstudiantes = db.Estudiantes.Find(myEstudiantes.Codigo);
            objEstudiantes.Nombre = myEstudiantes.Nombre;
            objEstudiantes.Correo = myEstudiantes.Correo;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "admin, vendedor")]
        [HttpGet]
        public IActionResult Detalle(int? id)
        {
            var db = new tallersena588Context();
            var myEstudiantes = db.Estudiantes.Find(id);
            return View(myEstudiantes);
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        public IActionResult Borrar(int id)
        {
            var db = new tallersena588Context();
            var myEstudiantes = db.Estudiantes.Find(id);
            return View(myEstudiantes);
        }

        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Borrar")]
        public IActionResult ConfirmarBorrar(int id)
        {
            var db = new tallersena588Context();
            var myEstudiantes = db.Estudiantes.Find(id);
            db.Remove(myEstudiantes);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult NombreMetodo()
        {
            return View();
        }

    }
}

