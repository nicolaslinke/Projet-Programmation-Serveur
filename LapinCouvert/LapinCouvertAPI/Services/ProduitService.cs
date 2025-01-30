using LapinCouvert.Data;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace LapinCouvertAPI.Services
{
    public class ProduitService
    {
        private ApplicationDbContext _dbContext;

        public ProduitService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<List<Produit>> RecupererProduits()
        {
            var produits = new List<Produit>();
            produits = await _dbContext.Produits.ToListAsync();
            return produits;
        }
        /*
        public async Task<Produit[]> RecupererProduitsParCategorie(int categorie)
        {
            Produit[] produits = await _dbContext.Produits.Where(p => p.Categorie == categorie);
            return produits;
        }
        */
    }
}
