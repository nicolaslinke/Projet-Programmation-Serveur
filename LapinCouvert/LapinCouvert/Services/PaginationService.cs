using LapinCouvertMVC.ViewModels;
using Models.Models;

namespace LapinCouvertMVC.Services
{
    public class PaginationService
    {
        public ProduitsViewModel GetProduitsPage(List<Produit> produits, int pageSelectionneeIndex, int produitParPage)
        {
            var produitsPage = new List<Produit>();
            produitsPage.AddRange(produits.Skip(pageSelectionneeIndex * produitParPage).Take(produitParPage).ToList());
            return new ProduitsViewModel() { Produits = produitsPage, PageSelectionneeIndex = pageSelectionneeIndex, NombrePageTotale = (int)Math.Ceiling(produits.Count / (double)produitParPage) };
        }
    }
}
