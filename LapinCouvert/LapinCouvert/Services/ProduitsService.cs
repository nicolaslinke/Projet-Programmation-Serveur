using LapinCouvert.Data;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace LapinCouvertMVC.Services
{
    public class ProduitsService
    {
        private ApplicationDbContext _dbContext;
        public ProduitsService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Produit>> GetInventaire()
        {
            return await _dbContext.Produits.OrderBy(produit => produit.Nom).ToListAsync();
        }
    }
}
