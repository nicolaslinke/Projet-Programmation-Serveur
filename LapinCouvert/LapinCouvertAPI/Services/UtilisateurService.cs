using LapinCouvert.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System.Numerics;

namespace LapinCouvertAPI.Services
{
    public class UtilisateurService
    {
        private ApplicationDbContext _dbContext;

        public UtilisateurService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<Utilisateur> CreateUtilisateur(IdentityUser user, string nom, string prenom, string matricule)
        {
            Utilisateur u = new Utilisateur()
            {
                Id = 0,
                UserId = user.Id,
                Nom = nom,
                Prenom = prenom,
                Matricule = matricule
            };

            _dbContext.Add(u);
            _dbContext.SaveChanges();

            return u;
        }

        public async Task<Utilisateur> GetUtilisateurByUserId(string userId)
        {
            Utilisateur utilisateur = await _dbContext.Utilisateurs
                .FirstOrDefaultAsync(u => u.UserId == userId);
            return utilisateur;
        }

    }
}
