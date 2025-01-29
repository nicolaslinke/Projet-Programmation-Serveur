using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LapinCouvertMVC.Controllers
{
    public class InventaireController : Controller
    {
        // GET: InventaireController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InventaireController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InventaireController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InventaireController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InventaireController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InventaireController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InventaireController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InventaireController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
