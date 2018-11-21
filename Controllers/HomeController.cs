using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repaso_RCV.Models;
using Repaso_RCV.Context;

namespace Repaso_RCV.Controllers
{
    public class HomeController : Controller
    {
        private readonly BDContext _Context;
        public HomeController(BDContext _context)
        {
            _Context = _context;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Tienda
            public IActionResult NuevaTienda()
            {
                return View();
            }

            [HttpPost]

            public IActionResult NuevaTienda(Tienda t)
            {
                if (ModelState.IsValid)
                {
                    _Context.Add(t);
                    _Context.SaveChanges();

                    return RedirectToAction("ConfirmacionTienda");
                }
                return View(t);
            }


            public IActionResult ConfirmacionTienda()
            {
                return View();
            }
        #endregion Tienda

        #region Categoria

            public IActionResult NuevaCategoria()
            {
                return View();
            }
            [HttpPost]
            public IActionResult NuevaCategoria(Categoria c)
            {
            if (ModelState.IsValid)
            {
                _Context.Add(c);
                _Context.SaveChanges();

                return RedirectToAction("ConfirmacionCategoria");
            }
            return View(c);
            }

            public IActionResult ConfirmacionCategoria()
            {
                return View();
            }

        #endregion

        #region Producto

        public IActionResult NuevoProducto()
        {
            ViewBag.Tiendas = new SelectList(_Context.Tiendas, "Id", "Nombre");
            ViewBag.Categorias = new SelectList(_Context.Categorias, "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public IActionResult NuevoProducto(Producto p)
        {
            if (ModelState.IsValid)
            {
                _Context.Add(p);
                _Context.SaveChanges();

                TempData["resultado"] = 1;
                return RedirectToAction("NuevoProducto");
            }

            //Al redireccionar a la misma vista, se deben cargar las Listas de las Entidades relacionadas
            ViewBag.Tiendas = new SelectList(_Context.Tiendas, "Id", "Nombre");
            ViewBag.Categorias = new SelectList(_Context.Categorias, "Id", "Nombre");

            return View(p);
        }

        public IActionResult ConfirmacionProducto()
        {
            return View();
        }
        #endregion
    }
}
