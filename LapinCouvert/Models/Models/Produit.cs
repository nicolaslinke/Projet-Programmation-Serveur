using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Produit
    {
        
        public int ProduitId { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        [DisplayName("Prix Vendu")]
        
        public decimal PrixVendu { get; set; }

        [Required]
        public string Description { get; set; }
        public string? Image { get; set; }
        [Required]
        public int Quantite { get; set; }

        [DisplayName("Prix Coutant")]
        public decimal PrixCoutant { get; set; }
        [Required]
        public bool Disponible { get; set; }
        public CategorieEnum? Categorie { get; set; }
    }
}
