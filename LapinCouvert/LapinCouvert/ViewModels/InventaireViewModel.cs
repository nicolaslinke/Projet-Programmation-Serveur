using Models.Models;

namespace LapinCouvertMVC.ViewModels
{
    public class InventaireViewModel
    {
        public InventaireViewModel()
        {

        }
        public List<Produit>? Inventaire { get; set; }
        public int SelectedPageIndex { get; set; }
        public int? NombrePageTotale { get; set; }
    }
}
