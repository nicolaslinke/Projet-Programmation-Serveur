using API.DTOs;
using LapinCouvertAPI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LapinCouvertAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProduitController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ProduitService _produitService;

        public ProduitController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ProduitService produitService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _produitService = produitService;
        }

        [HttpGet]
        public async Task<ActionResult> RecupererProduits()
        {
            return Ok(await _produitService.RecupererProduits());
        }
    }
}
