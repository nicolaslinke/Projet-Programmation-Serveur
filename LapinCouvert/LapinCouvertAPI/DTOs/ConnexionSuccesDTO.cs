using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class ConnexionSuccesDTO
    {
        public string UserName { get; set; } = "";

        public string Jeton { get; set; } = "";
    }
}
