using LapinCouvert.Data;
using LapinCouvertMVC.Services;
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
        private ProduitsService _produitsService;
        private PaginationService _paginationService;
        public InventaireController(ApplicationDbContext dbContext, ProduitsService produitsService, PaginationService paginationService)
        {
            _dbContext = dbContext;
            _produitsService = produitsService;
            _paginationService = paginationService;
        }

        private const int PRODUIT_PAR_PAGE = 2;
        // GET: InventaireController
        public async Task<IActionResult> Index()
        {
            var inventaire = await _produitsService.ObtenirInventaireOrdreNomAsync();
            var produitsViewModel = _paginationService.PaginationProduits(inventaire, 0, PRODUIT_PAR_PAGE);

            return View(produitsViewModel);
        }

        // GET: Change de page
        public async Task<IActionResult> ChangerPage(ProduitsViewModel produitsViewModel)
        {
            var inventaire = await _produitsService.ObtenirInventaireOrdreNomAsync();
            produitsViewModel = _paginationService.PaginationProduits(inventaire, produitsViewModel.PageSelectionneeIndex, PRODUIT_PAR_PAGE);

            return View("Index", produitsViewModel);
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
                _produitsService.CreateProduit(produit);
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
