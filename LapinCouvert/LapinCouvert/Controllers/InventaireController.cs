using LapinCouvert.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace LapinCouvertMVC.Controllers
{
    public class InventaireController : Controller
    {
        private ApplicationDbContext _dbContext;
        public InventaireController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: InventaireController
        public async Task<IActionResult> Index()
        {
            return View(await _dbContext.Produits.ToListAsync());
        }

        // GET: InventaireController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InventaireController/Create
        public ActionResult Create()
        {
            ViewBag.Categories = new SelectList(Enum.GetValues(typeof(CategorieEnum)));
            return View();
        }

        // POST: InventaireController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProduitId,Nom,PrixVendu,Description,Image,Quantite,PrixCoutant,Disponible,Categorie")] Produit produit)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(produit);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(produit);
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
