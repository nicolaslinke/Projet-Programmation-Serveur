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

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "admin", NormalizedName = "ADMIN" }
            );

            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
            IdentityUser u1 = new IdentityUser
            {
                Id = "11111111-1111-1111-1111-111111111111",
                UserName = "a@a.a",
                NormalizedUserName = "A@A.A",
                Email = "a@a.a",
                NormalizedEmail = "A@A.A",
                EmailConfirmed = true
            };
            u1.PasswordHash = passwordHasher.HashPassword(u1, "Password!2");

            builder.Entity<IdentityUser>().HasData(u1);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = u1.Id, RoleId = "1" }
            );

            builder.Entity<Produit>().HasData(Seed.SeedProduit());
        }
        public DbSet<Produit> Produits { get; set; } = default;

        public DbSet<Utilisateur> Utilisateurs { get; set; } = default!;
    }
}
