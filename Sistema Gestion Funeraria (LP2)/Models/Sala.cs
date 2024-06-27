using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class Sala
{
    public int IdSala { get; set; }

    public string Nombre { get; set; } = null!;

    public int Capacidad { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdCategoria { get; set; }

    public int IdLocalidad { get; set; }

    public virtual ICollection<Difunto> Difuntos { get; set; } = new List<Difunto>();

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;

    public virtual Localidad IdLocalidadNavigation { get; set; } = null!;
}
