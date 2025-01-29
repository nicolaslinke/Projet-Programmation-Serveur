using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Produit
    {
        public int ProduitId { get; set; }
        public string Nom { get; set; }
        public decimal Prix { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Quantite { get; set; }

        public decimal PrixCoutant { get; set; }
        public bool Disponible { get; set; }
        public CategorieEnum Categorie { get; set; }
    }
}
