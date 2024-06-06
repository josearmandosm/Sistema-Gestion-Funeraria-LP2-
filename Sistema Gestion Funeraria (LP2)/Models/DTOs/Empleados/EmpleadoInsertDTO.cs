using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestion_Funeraria__LP2_.Models.DTOs.Empleados
{
    public class EmpleadoInsertDTO
    {
        [Required(ErrorMessage = "Nombre es requerido")]
        [MaxLength(100, ErrorMessage = "Nombre no puede ser mayor a 100 carácteres")]
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "Número de Documento es requerido")]
        [MinLength(9, ErrorMessage = "Número de Documento no puede ser menor a 9 carácteres")]
        [MaxLength(11, ErrorMessage = "Número de Documento no puede ser mayor a 11 carácteres")]
        public string? NumDocumento { get; set; }
        [Required(ErrorMessage = "Dirección es requerida")]
        [MaxLength(200, ErrorMessage = "Número de Documento no puede ser mayor a 200 carácteres")]
        public string Direccion { get; set; } = null!;
        [Required(ErrorMessage = "Teléfono es requerido")]
        [MaxLength(10, ErrorMessage = "Número de Documento no puede ser mayor a 10 carácteres")]
        public string Telefono { get; set; } = null!;
        [Required(ErrorMessage = "Tipo de Identificación es requerido")]
        public int? IdIdentificacion { get; set; }
        [Required(ErrorMessage = "Tipo de Cargo es requerido")]
        public int? IdCargo { get; set; }
    }
}
