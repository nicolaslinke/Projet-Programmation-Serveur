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
        [Required(ErrorMessage = "Le champ du nom est obligatoire")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le champ prix vendu est obligatoire")]
        [DisplayName("Prix Vendu")]
        [Range(0, double.MaxValue,ErrorMessage ="Le prix vendu ne peut pas être négatif. ")]
        
        public decimal PrixVendu { get; set; }

        [Required(ErrorMessage ="Le champ Description est obligatoire")]
        public string Description { get; set; }
        public string? Image { get; set; }
        [Required(ErrorMessage = "Le champ Quantité est obligatoire")]
        [Range(0, double.MaxValue, ErrorMessage = "La quantité ne peut pas être négative. ")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "La quantité ne doit contenir que des chiffres entiers, sans point ni virgule.")]

        public int Quantite { get; set; }
        [DisplayName("Prix Coutant")]
        [Range(0, double.MaxValue, ErrorMessage = "Le prix coutant ne peut pas être négatif. ")]
        public decimal PrixCoutant { get; set; }

        
        public bool Disponible { get; set; }
        public CategorieEnum? Categorie { get; set; }
    }
}
