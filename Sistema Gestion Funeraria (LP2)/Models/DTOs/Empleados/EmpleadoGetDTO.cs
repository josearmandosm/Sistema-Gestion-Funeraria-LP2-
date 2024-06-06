﻿using System.ComponentModel.DataAnnotations;

namespace Sistema_Gestion_Funeraria__LP2_.Models.DTOs.Empleados
{
    public class EmpleadoGetDTO
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; } = null!;
        public string? NumDocumento { get; set; }
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public int? IdIdentificacion { get; set; }
        public int? IdCargo { get; set; }
    }
}
