using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestion_Funeraria__LP2_.Models.DTOs.Usuario
{
    public class NuevoUsuarioDTO
    {
        [Required]
        public string? Usuario { get; set; }
        [Required]
        [EmailAddress]
        public string? CorreoElectronico { get; set; }
        [Required]
        public string? Contraseña { get; set; }

    }
}