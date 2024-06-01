using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class Localidad
{
    public int IdLocalidad { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public int? IdContacto1 { get; set; }

    public int? IdContacto2 { get; set; }

    public virtual ICollection<JornadaLaboral> JornadaLaborals { get; set; } = new List<JornadaLaboral>();

    public virtual ICollection<Sala> Salas { get; set; } = new List<Sala>();
}
