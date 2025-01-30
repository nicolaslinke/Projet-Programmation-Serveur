using API.DTOs;
using LapinCouvertAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Models.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LapinCouvertAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UtilisateurController : ControllerBase
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UtilisateurService _utilisateurService;

        public UtilisateurController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, UtilisateurService utilisateurService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _utilisateurService = utilisateurService;
        }

        [HttpPost]
        public async Task<ActionResult> Inscription(InscriptionDTO inscriptionDTO)
        {

            if (inscriptionDTO.MotDePasse != inscriptionDTO.MotDePasseConfirmer)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { Error = "Le mot de passe et la confirmation ne sont pas identique" });
            }

            IdentityUser utilisateur = new IdentityUser()
            {
                UserName = inscriptionDTO.Courriel,
                Email = inscriptionDTO.Courriel
            };
            IdentityResult identityResult = await _userManager.CreateAsync(utilisateur, inscriptionDTO.MotDePasse);

            if (!identityResult.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { Error = identityResult.Errors });
            }

            await _utilisateurService.CreateUtilisateur(utilisateur, inscriptionDTO.Nom, inscriptionDTO.Prenom, inscriptionDTO.Matricule);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Connexion(ConnexionDTO connexionDTO)
        {
            IdentityUser user = await _userManager.FindByNameAsync(connexionDTO.Courriel);

            if (user != null && await _userManager.CheckPasswordAsync(user, connexionDTO.MotDePasse))
            {
                //Pour les rôles
                IList<string> roles = await _userManager.GetRolesAsync(user);
                List<Claim> authClaims = new List<Claim>();
                foreach (string role in roles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, role));
                }
                authClaims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));

                //Pour les jetons
                SymmetricSecurityKey signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("C'est tellement la meilleure cle qui a jamais ete cree dans l'histoire de l'humanite (doit etre longue)"));

                string issuer = this.Request.Scheme + "://" + this.Request.Host;

                DateTime expirationTime = DateTime.Now.AddMinutes(30);

                JwtSecurityToken token = new JwtSecurityToken(
                    issuer: issuer,
                    audience: null,
                    claims: authClaims,
                    expires: expirationTime,
                    signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256Signature)
                );

                var utilisateur = await _utilisateurService.GetUtilisateurByUserId(user.Id);

                string tokenString = new JwtSecurityTokenHandler().WriteToken(token);
                string userName =  utilisateur.Prenom + " " + utilisateur.Nom;
                // On ne veut JAMAIS retouner une string directement lorsque l'on utilise Angular.
                // Angular assume que l'on retourne un objet et donne une erreur lorsque le résultat obtenu est une simple string!
                return Ok(new ConnexionSuccesDTO() { Jeton = tokenString, UserName = userName});
            }

            return NotFound(new { Error = "L'utilisateur est introuvable ou le mot de passe ne concorde pas" });
        }

        [HttpGet]
        public ActionResult PublicTest()
        {
            return Ok(new string[] { "Pomme", "Poire", "Banane" });
        }


        [HttpGet]
        [Authorize(Roles = "admin")]
        public ActionResult PrivateTest()
        {
            return Ok(new string[] { "PrivatePomme", "PrivatePoire", "PrivateBanane" });
        }
    }
}
