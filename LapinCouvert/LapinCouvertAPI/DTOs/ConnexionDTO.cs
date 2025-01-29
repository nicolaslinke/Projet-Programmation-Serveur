using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class ConnexionDTO
    {
        [Required]
        public string Courriel { get; set; } = "";
        [Required]
        public string MotDePasse { get; set; } = "";
    }
}
