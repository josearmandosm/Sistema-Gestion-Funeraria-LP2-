using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class TipoIdentificacione
{
    public int IdTipoIdentificacion { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual Difunto? Difunto { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
