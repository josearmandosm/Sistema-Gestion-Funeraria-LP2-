using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestion_Funeraria__LP2_.Models.DTOs.Empleados
{
    public class EmpleadoInsertDTO
    {
        public int? IdIdentificacion { get; set; }

        public int? IdCargo { get; set; }
        public string? NumDocumento { get; set; }
        [Required]
        public string Nombre { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public string Telefono { get; set; } = null!;
    }
}
