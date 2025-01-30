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
using Supabase;

namespace LapinCouvertMVC.Controllers
{
    [Authorize(Roles = "admin")]
    public class InventaireController : Controller
    {
        private ApplicationDbContext _dbContext;
        private readonly Supabase.Client _supabaseClient;

        public InventaireController(ApplicationDbContext dbContext)
        private ProduitsService _produitsService;
        private PaginationService _paginationService;
        public InventaireController(ApplicationDbContext dbContext, ProduitsService produitsService, PaginationService paginationService)
        {
            _dbContext = dbContext;
            _supabaseClient = new Supabase.Client("https://wxxkhaynopgdjhcbrsqe.supabase.co", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Ind4eGtoYXlub3BnZGpoY2Jyc3FlIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzgxNjU5MDQsImV4cCI6MjA1Mzc0MTkwNH0.v3PYWCL2Ayv7epyfcytKL4fNZMtD6fLWrN_RgD3Rq1o");

            _produitsService = produitsService;
            _paginationService = paginationService;
        }

        private const int PRODUIT_PAR_PAGE = 7;
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
        public async Task<IActionResult> Create([Bind("ProduitId,Nom,PrixVendu,Description,Quantite,PrixCoutant,Disponible,Categorie")] Produit produit, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null && Image.Length > 0)
                {
                    var fileBytes = new byte[Image.Length];
                    using (var stream = Image.OpenReadStream())
                    {
                        await stream.ReadAsync(fileBytes);
                    }
                    var filePath = Path.GetFileName(Image.FileName);

                    var uploadResult = await _supabaseClient.Storage
                        .From("Images")
                        .Upload(fileBytes, filePath);

                    if (uploadResult != null)
                    {
                        var fileUrl =  _supabaseClient.Storage
                            .From("Images")
                            .GetPublicUrl(filePath);

                        if (!string.IsNullOrEmpty(fileUrl))
                        {
                            produit.Image = fileUrl;
                        }
                        else
                        {
                            ModelState.AddModelError("Image", "Failed to retrieve the image URL.");
                            return View(produit);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Image", "Failed to upload the image.");
                        return View(produit);
                    }
                }

                _dbContext.Add(produit);
                await _dbContext.SaveChangesAsync();

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
