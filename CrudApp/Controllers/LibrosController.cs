using CrudApp.Data;
using CrudApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Controllers
{
    public class LibrosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LibrosController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            IEnumerable<Libro> listlibros = _context.Libro;
            return View(listlibros);
        }

        //Http Get Create
        public IActionResult Create()
        {
            return View();
        }

        //Http Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create (Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Add(libro);
                _context.SaveChanges();

                TempData["Mensaje"] = "Libro creado correctamente";

                return RedirectToAction("Index");
            }

            return View();
        }

        //Http Get Edit
        public IActionResult Edit(int? id)
        { if(id == null || id == 0) 
            {
                return NotFound();

            }


            // obtener el l8ibro

            var libro = _context.Libro.Find(id);

            if(libro == null)
            {
                return NotFound();
            }

            return View(libro);


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Update(libro);
                _context.SaveChanges();

                TempData["Mensaje"] = "Libro Actualizado correctamente";

                return RedirectToAction("Index");
            }

            return View();
        }

        //Http Get Delette
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }


            // obtener el l8ibro

            var libro = _context.Libro.Find(id);

            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);


        }

        //Http Post Delete
        [HttpPost]
        public IActionResult DeleteLibro(int? Id)
        {

            var libro = _context.Libro.Find(Id);
            if(libro == null)
            {
                return NotFound();
            }
          
          
                _context.Libro.Remove(libro);
                _context.SaveChanges();

                TempData["Mensaje"] = "Libro ha sido eliminado correctamente";

                return RedirectToAction("Index");
          

            
        }

    }
}
