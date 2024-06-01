using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class TipoIdentificacion
{
    public int IdIdentificacion { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Defuncione> Defunciones { get; set; } = new List<Defuncione>();

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
