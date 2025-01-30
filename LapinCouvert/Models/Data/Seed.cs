using Microsoft.AspNetCore.Identity;
using Models.Models;
using System;
using System.Collections.Generic;

namespace Models.Data
{
    public class Seed
    {
        public Seed() { }

        public static Produit[] SeedProduits()
        {
            return new Produit[]
            {
                new Produit
                {
                    ProduitId = 1,
                    Nom = "Caramilk",
                    PrixVendu = 2.75m,
                    PrixCoutant = 2.00m,
                    Description = "Une barre chocolatée Cadbury avec un cœur de caramel fondant enrobé de chocolat au lait.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Caramilk.png",
                    Quantite = 5,
                    Disponible = true,
                    Categorie = CategorieEnum.Collation
                },
                new Produit
                {
                    ProduitId = 2,
                    Nom = "Aero",
                    PrixVendu = 2.50m,
                    PrixCoutant = 1.80m,
                    Description = "Une barre chocolatée Nestlé avec un intérieur alvéolé unique.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Aero.png",
                    Quantite = 10,
                    Disponible = true,
                    Categorie = CategorieEnum.Collation
                },
                new Produit
                {
                    ProduitId = 3,
                    Nom = "Beigne au chocolat",
                    PrixVendu = 1.99m,
                    PrixCoutant = 1.20m,
                    Description = "Un délicieux beignet moelleux recouvert d'un glaçage au chocolat.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/BeigneChocolat.png",
                    Quantite = 8,
                    Disponible = true,
                    Categorie = CategorieEnum.Collation
                },
                new Produit
                {
                    ProduitId = 4,
                    Nom = "Burrito",
                    PrixVendu = 5.50m,
                    PrixCoutant = 4.00m,
                    Description = "Un burrito garni de viande, fromage et légumes dans une tortilla souple.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Burrito.png",
                    Quantite = 6,
                    Disponible = true,
                    Categorie = CategorieEnum.Repas
                },
                new Produit
                {
                    ProduitId = 5,
                    Nom = "Gatorade Bleu Cool",
                    PrixVendu = 3.25m,
                    PrixCoutant = 2.00m,
                    Description = "Une boisson énergisante aux électrolytes pour une hydratation optimale.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/GatoradeBleu.png",
                    Quantite = 12,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                },
                new Produit
                {
                    ProduitId = 6,
                    Nom = "Guru Original",
                    PrixVendu = 3.99m,
                    PrixCoutant = 2.50m,
                    Description = "Une boisson énergisante naturelle avec caféine biologique.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/GuruOriginal.png",
                    Quantite = 7,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                },
                new Produit
                {
                    ProduitId = 7,
                    Nom = "KitKat",
                    PrixVendu = 2.75m,
                    PrixCoutant = 1.80m,
                    Description = "Une barre chocolatée avec des gaufrettes croustillantes enrobées de chocolat.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/KitKat.png",
                    Quantite = 9,
                    Disponible = true,
                    Categorie = CategorieEnum.Collation
                },
                new Produit
                {
                    ProduitId = 8,
                    Nom = "Lait Protéiné Fairlife Chocolat",
                    PrixVendu = 4.50m,
                    PrixCoutant = 3.00m,
                    Description = "Lait ultra-filtré riche en protéines avec une saveur chocolatée onctueuse.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/FairlifeChocolat.png",
                    Quantite = 10,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                },
                new Produit
                {
                    ProduitId = 9,
                    Nom = "McCain Pizza Pochette au Pepperoni",
                    PrixVendu = 4.99m,
                    PrixCoutant = 3.25m,
                    Description = "Une pochette croustillante farcie de sauce tomate, fromage et pepperoni.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/PizzaPochette.png",
                    Quantite = 6,
                    Disponible = true,
                    Categorie = CategorieEnum.Repas
                },
                new Produit
                {
                    ProduitId = 10,
                    Nom = "Monster Original",
                    PrixVendu = 3.99m,
                    PrixCoutant = 2.50m,
                    Description = "Une boisson énergisante puissante avec une haute teneur en caféine.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/MonsterOriginal.png",
                    Quantite = 8,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                },
                new Produit
                {
                    ProduitId = 11,
                    Nom = "Monster Ultra",
                    PrixVendu = 3.99m,
                    PrixCoutant = 2.50m,
                    Description = "Une version sans sucre de la célèbre boisson énergisante Monster.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/MonsterUltra.png",
                    Quantite = 10,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                },
                new Produit
                {
                    ProduitId = 12,
                    Nom = "Oreo",
                    PrixVendu = 3.25m,
                    PrixCoutant = 2.00m,
                    Description = "Un biscuit croustillant au chocolat fourré d’une crème sucrée.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Oreo.png",
                    Quantite = 10,
                    Disponible = true,
                    Categorie = CategorieEnum.Collation
                },
                new Produit
                {
                    ProduitId = 13,
                    Nom = "Peace Tea Original",
                    PrixVendu = 2.99m,
                    PrixCoutant = 2.00m,
                    Description = "Un thé glacé rafraîchissant au goût sucré et fruité.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/PeaceTeaOriginal.png",
                    Quantite = 8,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                },
                new Produit
                {
                    ProduitId = 14,
                    Nom = "Pizza aux poivrons",
                    PrixVendu = 7.99m,
                    PrixCoutant = 5.00m,
                    Description = "Une pizza garnie de sauce tomate, fromage et divers ingrédients.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/PizzaPoivrons.png",
                    Quantite = 5,
                    Disponible = true,
                    Categorie = CategorieEnum.Repas
                },
                new Produit
                {
                    ProduitId = 15,
                    Nom = "Pogo",
                    PrixVendu = 3.50m,
                    PrixCoutant = 2.50m,
                    Description = "Un hot-dog sur bâton enrobé d'une pâte frite croustillante.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Pogo.png",
                    Quantite = 7,
                    Disponible = true,
                    Categorie = CategorieEnum.Repas
                },
                new Produit
                {
                    ProduitId = 16,
                    Nom = "Poutine",
                    PrixVendu = 6.99m,
                    PrixCoutant = 4.50m,
                    Description = "Des frites croustillantes recouvertes de fromage en grains et de sauce brune.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Poutine.png",
                    Quantite = 6,
                    Disponible = true,
                    Categorie = CategorieEnum.Repas
                },
                new Produit
                {
                    ProduitId = 17,
                    Nom = "Prime Fraise et Melon d'eau",
                    PrixVendu = 3.99m,
                    PrixCoutant = 2.50m,
                    Description = "Une boisson hydratante à saveur de fraise et melon d’eau.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/PrimeFraiseMelon.png",
                    Quantite = 8,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                },
                new Produit
                {
                    ProduitId = 18,
                    Nom = "Redbull Original",
                    PrixVendu = 3.99m,
                    PrixCoutant = 2.50m,
                    Description = "Une boisson énergisante classique pour un regain de vitalité.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/RedbullOriginal.png",
                    Quantite = 10,
                    Disponible = true,
                    Categorie = CategorieEnum.Boisson
                },
                new Produit
                {
                    ProduitId = 19,
                    Nom = "Sandwich aux tomates",
                    PrixVendu = 4.25m,
                    PrixCoutant = 2.75m,
                    Description = "Un sandwich frais garni de tomates juteuses et d’assaisonnements.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/SandwichTomates.png",
                    Quantite = 5,
                    Disponible = true,
                    Categorie = CategorieEnum.Repas
                },
                new Produit
                {
                    ProduitId = 20,
                    Nom = "Soupe aux nouilles Shin",
                    PrixVendu = 3.75m,
                    PrixCoutant = 2.25m,
                    Description = "Une soupe instantanée épicée avec des nouilles et un bouillon savoureux.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/SoupeShin.png",
                    Quantite = 7,
                    Disponible = true,
                    Categorie = CategorieEnum.Repas
                },
                new Produit
                {
                    ProduitId = 21,
                    Nom = "Sour Patch Kids",
                    PrixVendu = 2.99m,
                    PrixCoutant = 2.00m,
                    Description = "Des bonbons gélifiés acidulés puis sucrés pour une explosion de saveurs.",
                    Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/SourPatchKids.png",
                    Quantite = 12,
                    Disponible = true,
                    Categorie = CategorieEnum.Collation
                }
            };
        }

        public static Utilisateur[] SeedUtilisateurs()
        {
            return new Utilisateur[]
            {
                new Utilisateur
                {
                    Id = 1,
                    Nom = "a",
                    Prenom = "a",
                    Matricule = "1111111",
                    UserId = "11111111-1111-1111-1111-111111111111"
                },
            };
        }

        public static IdentityUser[] SeedIdentityUsers()
        {
            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
            return new IdentityUser[]
            {
                new IdentityUser
                {
                    Id = "11111111-1111-1111-1111-111111111111",
                    UserName = "a@a.a",
                    NormalizedUserName = "A@A.A",
                    Email = "a@a.a",
                    NormalizedEmail = "A@A.A",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "Password!2")
                },                       
            };
        }

        public static IdentityRole[] SeedRoles()
        {
            return new IdentityRole[]
            {
                new IdentityRole
                {
                    Id = "1", 
                    Name = "admin", 
                    NormalizedName = "ADMIN"
                },
            };
        }

        public static IdentityUserRole<string>[] SeedIdentityUserRoles()
        {
            return new IdentityUserRole<string>[]
            {
                new IdentityUserRole<string>
                {
                    UserId = "11111111-1111-1111-1111-111111111111",
                    RoleId = "1"
                },
            };
        }
    }
}