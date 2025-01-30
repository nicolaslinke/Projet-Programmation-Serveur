using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.Data;
using Models.Models;
using Models.Models;
using System.Numerics;

namespace LapinCouvert.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(Seed.SeedRoles());

            builder.Entity<Utilisateur>().HasData(Seed.SeedUtilisateurs());

            builder.Entity<IdentityUser>().HasData(Seed.SeedIdentityUsers());

            builder.Entity<IdentityUserRole<string>>().HasData(Seed.SeedIdentityUserRoles());

            builder.Entity<Produit>().HasData(Seed.SeedProduits());
        }
        public DbSet<Produit> Produits { get; set; } = default;

        public DbSet<Utilisateur> Utilisateurs { get; set; } = default!;
    }
}
