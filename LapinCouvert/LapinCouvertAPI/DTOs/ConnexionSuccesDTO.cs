using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class ConnexionSuccesDTO
    {
        [Required]
        public string Jeton { get; set; } = "";
    }
}
