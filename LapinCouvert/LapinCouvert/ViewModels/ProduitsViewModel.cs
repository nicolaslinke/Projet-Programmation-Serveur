using Models.Models;

namespace LapinCouvertMVC.ViewModels
{
    public class ProduitsViewModel
    {
        public ProduitsViewModel()
        {

        }
        public List<Produit>? Produits { get; set; }
        public int PageSelectionneeIndex { get; set; }
        public int? NombrePageTotale { get; set; }
    }
}
