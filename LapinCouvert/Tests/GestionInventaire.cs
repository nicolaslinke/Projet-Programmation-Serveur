using LapinCouvert.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class GestionInventaire
    {
        DbContextOptions<ApplicationDbContext> options;
        public GestionInventaire()
        {
            options = new DbContextOptionsBuilder<ApplicationDbContext>()
            // TODO il faut installer la dépendance Microsoft.EntityFrameworkCore.InMemory
            .UseInMemoryDatabase(databaseName: "CardsService")
            .Options;
        }

        [TestInitialize]
        public void init()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);

            Produit produitA = new Produit
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
            };
            Produit produitB = new Produit
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
            };
            Produit produitC = new Produit
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
            };

            db.Produits.Add(produitA);
            db.Produits.Add(produitB);
            db.Produits.Add(produitC);
            db.SaveChanges();
        }

        [TestCleanup]
        public void Dispose()
        {
            //TODO on efface les données de tests pour remettre la BD dans son état initial
            using ApplicationDbContext db = new ApplicationDbContext(options);
            db.Produits.RemoveRange(db.Produits);
            db.SaveChanges();
        }

        [TestMethod()]
        public void GetProduitS()
        {
            using ApplicationDbContext db = new ApplicationDbContext(options);
            
            
        }
    }
}