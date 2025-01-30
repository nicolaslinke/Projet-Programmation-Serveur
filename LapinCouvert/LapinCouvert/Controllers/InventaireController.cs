using LapinCouvert.Data;
using LapinCouvertMVC.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System.Drawing.Printing;

namespace LapinCouvertMVC.Controllers
{
    [Authorize(Roles = "admin")]
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
            var inventaire = await _dbContext.Produits.OrderBy(produit => produit.Nom).ToListAsync();
            var inventairePage = new List<Produit>();
            inventairePage.AddRange(inventaire.Skip(0 * 10).Take(10).ToList());
            var inventaireViewModel = new InventaireViewModel() { Inventaire = inventairePage, SelectedPageIndex = 0, NombrePageTotale = (int)Math.Ceiling(inventaire.Count / (double)10) };

            return View(inventaireViewModel);
        }

        // GET: Change de page
        public async Task<IActionResult> ChangerPage(InventaireViewModel inventaireViewModel)
        {
            var inventaire = await _dbContext.Produits.OrderBy(produit => produit.Nom).ToListAsync();
            var inventairePage = new List<Produit>();
            inventairePage.AddRange(inventaire.Skip(inventaireViewModel.SelectedPageIndex * 10).Take(10).ToList());

            inventaireViewModel.Inventaire = inventairePage;
            inventaireViewModel.NombrePageTotale = (int)Math.Ceiling(inventaire.Count / (double)10);

            return View("Index", inventaireViewModel);
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
