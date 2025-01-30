﻿// <auto-generated />
using System;
using LapinCouvert.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250130190921_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Models.Models.Produit", b =>
                {
                    b.Property<int>("ProduitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProduitId"));

                    b.Property<int?>("Categorie")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Disponible")
                        .HasColumnType("boolean");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("PrixCoutant")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PrixVendu")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantite")
                        .HasColumnType("integer");

                    b.HasKey("ProduitId");

                    b.ToTable("Produits");

                    b.HasData(
                        new
                        {
                            ProduitId = 1,
                            Categorie = 2,
                            Description = "Une barre chocolatée Cadbury avec un cœur de caramel fondant enrobé de chocolat au lait.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Caramilk.png",
                            Nom = "Caramilk",
                            PrixCoutant = 2.00m,
                            PrixVendu = 2.75m,
                            Quantite = 5
                        },
                        new
                        {
                            ProduitId = 2,
                            Categorie = 2,
                            Description = "Une barre chocolatée Nestlé avec un intérieur alvéolé unique.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Aero.png",
                            Nom = "Aero",
                            PrixCoutant = 1.80m,
                            PrixVendu = 2.50m,
                            Quantite = 10
                        },
                        new
                        {
                            ProduitId = 3,
                            Categorie = 2,
                            Description = "Un délicieux beignet moelleux recouvert d'un glaçage au chocolat.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/BeigneChocolat.png",
                            Nom = "Beigne au chocolat",
                            PrixCoutant = 1.20m,
                            PrixVendu = 1.99m,
                            Quantite = 8
                        },
                        new
                        {
                            ProduitId = 4,
                            Categorie = 1,
                            Description = "Un burrito garni de viande, fromage et légumes dans une tortilla souple.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Burrito.png",
                            Nom = "Burrito",
                            PrixCoutant = 4.00m,
                            PrixVendu = 5.50m,
                            Quantite = 6
                        },
                        new
                        {
                            ProduitId = 5,
                            Categorie = 0,
                            Description = "Une boisson énergisante aux électrolytes pour une hydratation optimale.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/GatoradeBleu.png",
                            Nom = "Gatorade Bleu Cool",
                            PrixCoutant = 2.00m,
                            PrixVendu = 3.25m,
                            Quantite = 12
                        },
                        new
                        {
                            ProduitId = 6,
                            Categorie = 0,
                            Description = "Une boisson énergisante naturelle avec caféine biologique.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/GuruOriginal.png",
                            Nom = "Guru Original",
                            PrixCoutant = 2.50m,
                            PrixVendu = 3.99m,
                            Quantite = 7
                        },
                        new
                        {
                            ProduitId = 7,
                            Categorie = 2,
                            Description = "Une barre chocolatée avec des gaufrettes croustillantes enrobées de chocolat.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/KitKat.png",
                            Nom = "KitKat",
                            PrixCoutant = 1.80m,
                            PrixVendu = 2.75m,
                            Quantite = 9
                        },
                        new
                        {
                            ProduitId = 8,
                            Categorie = 0,
                            Description = "Lait ultra-filtré riche en protéines avec une saveur chocolatée onctueuse.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/FairlifeChocolat.png",
                            Nom = "Lait Protéiné Fairlife Chocolat",
                            PrixCoutant = 3.00m,
                            PrixVendu = 4.50m,
                            Quantite = 10
                        },
                        new
                        {
                            ProduitId = 9,
                            Categorie = 1,
                            Description = "Une pochette croustillante farcie de sauce tomate, fromage et pepperoni.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/PizzaPochette.png",
                            Nom = "McCain Pizza Pochette au Pepperoni",
                            PrixCoutant = 3.25m,
                            PrixVendu = 4.99m,
                            Quantite = 6
                        },
                        new
                        {
                            ProduitId = 10,
                            Categorie = 0,
                            Description = "Une boisson énergisante puissante avec une haute teneur en caféine.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/MonsterOriginal.png",
                            Nom = "Monster Original",
                            PrixCoutant = 2.50m,
                            PrixVendu = 3.99m,
                            Quantite = 8
                        },
                        new
                        {
                            ProduitId = 11,
                            Categorie = 0,
                            Description = "Une version sans sucre de la célèbre boisson énergisante Monster.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/MonsterUltra.png",
                            Nom = "Monster Ultra",
                            PrixCoutant = 2.50m,
                            PrixVendu = 3.99m,
                            Quantite = 10
                        },
                        new
                        {
                            ProduitId = 12,
                            Categorie = 2,
                            Description = "Un biscuit croustillant au chocolat fourré d’une crème sucrée.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Oreo.png",
                            Nom = "Oreo",
                            PrixCoutant = 2.00m,
                            PrixVendu = 3.25m,
                            Quantite = 10
                        },
                        new
                        {
                            ProduitId = 13,
                            Categorie = 0,
                            Description = "Un thé glacé rafraîchissant au goût sucré et fruité.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/PeaceTeaOriginal.png",
                            Nom = "Peace Tea Original",
                            PrixCoutant = 2.00m,
                            PrixVendu = 2.99m,
                            Quantite = 8
                        },
                        new
                        {
                            ProduitId = 14,
                            Categorie = 1,
                            Description = "Une pizza garnie de sauce tomate, fromage et divers ingrédients.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/PizzaPoivrons.png",
                            Nom = "Pizza aux poivrons",
                            PrixCoutant = 5.00m,
                            PrixVendu = 7.99m,
                            Quantite = 5
                        },
                        new
                        {
                            ProduitId = 15,
                            Categorie = 1,
                            Description = "Un hot-dog sur bâton enrobé d'une pâte frite croustillante.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Pogo.png",
                            Nom = "Pogo",
                            PrixCoutant = 2.50m,
                            PrixVendu = 3.50m,
                            Quantite = 7
                        },
                        new
                        {
                            ProduitId = 16,
                            Categorie = 1,
                            Description = "Des frites croustillantes recouvertes de fromage en grains et de sauce brune.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/Poutine.png",
                            Nom = "Poutine",
                            PrixCoutant = 4.50m,
                            PrixVendu = 6.99m,
                            Quantite = 6
                        },
                        new
                        {
                            ProduitId = 17,
                            Categorie = 0,
                            Description = "Une boisson hydratante à saveur de fraise et melon d’eau.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/PrimeFraiseMelon.png",
                            Nom = "Prime Fraise et Melon d'eau",
                            PrixCoutant = 2.50m,
                            PrixVendu = 3.99m,
                            Quantite = 8
                        },
                        new
                        {
                            ProduitId = 18,
                            Categorie = 0,
                            Description = "Une boisson énergisante classique pour un regain de vitalité.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/RedbullOriginal.png",
                            Nom = "Redbull Original",
                            PrixCoutant = 2.50m,
                            PrixVendu = 3.99m,
                            Quantite = 10
                        },
                        new
                        {
                            ProduitId = 19,
                            Categorie = 1,
                            Description = "Un sandwich frais garni de tomates juteuses et d’assaisonnements.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/SandwichTomates.png",
                            Nom = "Sandwich aux tomates",
                            PrixCoutant = 2.75m,
                            PrixVendu = 4.25m,
                            Quantite = 5
                        },
                        new
                        {
                            ProduitId = 20,
                            Categorie = 1,
                            Description = "Une soupe instantanée épicée avec des nouilles et un bouillon savoureux.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/SoupeShin.png",
                            Nom = "Soupe aux nouilles Shin",
                            PrixCoutant = 2.25m,
                            PrixVendu = 3.75m,
                            Quantite = 7
                        },
                        new
                        {
                            ProduitId = 21,
                            Categorie = 2,
                            Description = "Des bonbons gélifiés acidulés puis sucrés pour une explosion de saveurs.",
                            Disponible = true,
                            Image = "https://wxxkhaynopgdjhcbrsqe.supabase.co/storage/v1/object/public/Images/SourPatchKids.png",
                            Nom = "Sour Patch Kids",
                            PrixCoutant = 2.00m,
                            PrixVendu = 2.99m,
                            Quantite = 12
                        });
                });

            modelBuilder.Entity("Models.Models.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Matricule")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Models.Utilisateur", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
