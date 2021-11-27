using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET.Models;
using System.Web.Mvc;

namespace ASP.NET.Controllers
{
    public class LibroController : Controller
    {
        // GET: Libro
        public ActionResult Index()
        {
            try
            {
                using (var db = new LibroTpEntities1())
                {


                    //Envio la Lista a la vista para que la muestre
                    return View(db.Libro.ToList());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Agregar(Libro a)

        { //Verifica el dato qe venga bien del lado servidor
            if (!ModelState.IsValid)

                return View();
            try
            {
                //para que abra y cierre la coneccion
                using (var db = new LibroTpEntities1())
                {
                    //a.FechaIncripcion = DateTime.Now;
                    a.Autor = a.Autor.ToUpper();
                    db.Libro.Add(a);
                    db.SaveChanges();
                    return RedirectToAction("index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al agregar el libro " + ex.Message);
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Libro a)
        {
            try
            {
                using (var db = new LibroTpEntities1())
                {
                    Libro alu = db.Libro.Find(a.Id);
                    alu.Titulo = a.Titulo;
                    alu.Edicion = a.Edicion;
                    alu.Autor = a.Autor.ToUpper();
                    alu.CantidadPaginas = a.CantidadPaginas;
                    alu.Editorial = a.Editorial;
                    alu.CiudadPais = a.CiudadPais;
                    alu.FechaEdicion = a.FechaEdicion;
                    db.SaveChanges();

                    return RedirectToAction("index");
                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        public ActionResult Detalles(int id)
        {
            using (var db = new LibroTpEntities1())
            {

                Libro alu = db.Libro.Find(id);
                return View(alu);
            }

        }


        public ActionResult Eliminar(int id)
        {
            using (var db = new LibroTpEntities1())
            {

                Libro alu = db.Libro.Find(id);
                db.Libro.Remove(alu);
                db.SaveChanges();

                return RedirectToAction("index");
            }

        }
    }
}
