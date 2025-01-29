using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    public class Seed
    {
        public Seed() { }

        public static Produit[] SeedProduit()
        {
            return new Produit[]
            {
                new Produit
                {
                    ProduitId = 1,
                    Nom = "Caramilk",
                    PrixVendu = 2.75m,
                    PrixCoutant = 3,
                    Description =
                   " Le Caramilk est une barre chocolatée emblématique de la marque Cadbury, qui combine une riche et crémeuse chocolat au lait avec un délicieux cœur de caramel fondant. Sa texture unique est à la fois lisse et fondante, créant une expérience sucrée et gourmande. Le caramel, caché à l'intérieur, apporte une douceur subtile et une note sucrée intense qui se marie parfaitement avec le chocolat au lait.",
                    Image = "../../Images/Caramilk.png",
                    Quantite = 5,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                }, new Produit
                {
                    ProduitId = 2,
                    Nom = "Gatorade Bleu",
                    PrixVendu = 3,
                    PrixCoutant = 3,
                    Description = "boisson électrolyte rafraîchissante au goût fruité",
                    Image = "../../Images/Gatorade Bleu Cool.png",
                    Quantite = 4,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                }, new Produit
                {
                    ProduitId = 3,
                     Nom = "Guru",
                    PrixVendu = 4.50m,
                    PrixCoutant = 3,
                    Description = "boisson électrolyte rafraîchissante au goût fruité",
                    Image = "../../Images/Guru Original.png",
                    Quantite = 6,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                }, new Produit
                {
                    ProduitId = 4,
                     Nom = "KitKat",
                    PrixVendu = 2.25m,
                    PrixCoutant = 3,
                    Description = "boisson électrolyte rafraîchissante au goût fruité",
                    Image = "../../Images/KitKat.png",
                    Quantite = 25,
                    Disponible = true,
                    Categorie = CategorieEnum.Collation
                }, new Produit
                {
                    ProduitId = 5,
                     Nom = "Lait protéiné Fairlife",
                    PrixVendu = 4.50m,
                    PrixCoutant = 3,
                    Description = "boisson électrolyte rafraîchissante au goût fruité",
                    Image = "../../Images/Lait protéiné Fairlife Chocolat.png",
                    Quantite = 2,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                }, new Produit
                {
                    ProduitId = 6,
                     Nom = "Pizza Pochette au pepperoni",
                    PrixVendu = 2.50m,
                    PrixCoutant = 3,
                    Description = "boisson électrolyte rafraîchissante au goût fruité",
                    Image = "../../Images/McCain Pizza Pochette au pepperoni.png",
                    Quantite = 46,
                    Disponible = true,
                    Categorie = CategorieEnum.Repas
                }, new Produit
                {
                    ProduitId = 7,
                     Nom = "Monster Original",
                    PrixVendu = 3.50m,
                    PrixCoutant = 3,
                    Description = "boisson électrolyte rafraîchissante au goût fruité",
                    Image = "../../Images/Monster Original.png",
                    Quantite = 4,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                }, new Produit
                {
                    ProduitId = 8,
                     Nom = "Peace Tea Original",
                    PrixVendu = 1.50m,
                    PrixCoutant = 3,
                    Description = "boisson électrolyte rafraîchissante au goût fruité",
                    Image = "../../Images/Peace Tea Original.png",
                    Quantite = 16,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                }, new Produit
                {
                    ProduitId = 9,
                     Nom = "Pogo",
                    PrixVendu = 3.50m,
                    PrixCoutant = 3,
                    Description = "boisson électrolyte rafraîchissante au goût fruité",
                    Image = "../../Images/Pogo.png",
                    Quantite = 65,
                    Disponible = true,
                    Categorie = CategorieEnum.Repas
                }, new Produit
                {
                    ProduitId = 10,
                     Nom = "Red Bull Original",
                    PrixVendu = 3,
                    PrixCoutant = 3,
                    Description = "boisson électrolyte rafraîchissante au goût fruité",
                    Image = "../../Images/Red Bull Original.png",
                    Quantite = 23,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                }, new Produit
                {
                    ProduitId = 11,
                     Nom = "Soupr aux nouilles Shin",
                    PrixVendu = 4.50m,
                    PrixCoutant = 3,
                    Description = "boisson électrolyte rafraîchissante au goût fruité",
                    Image = "../../Images/Soupe aux nouilles Shin.png",
                    Quantite = 12,
                    Disponible = true,
                    Categorie = CategorieEnum.Repas
                },


            };
        }
    }
}