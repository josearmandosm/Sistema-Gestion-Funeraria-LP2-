using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class Sala
{
    public int IdSala { get; set; }

    public int? IdLocalidad { get; set; }

    public int? IdCategoria { get; set; }

    public string Nombre { get; set; } = null!;

    public int Capacidad { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual ICollection<Defuncione> Defunciones { get; set; } = new List<Defuncione>();

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual Localidad? IdLocalidadNavigation { get; set; }
}
