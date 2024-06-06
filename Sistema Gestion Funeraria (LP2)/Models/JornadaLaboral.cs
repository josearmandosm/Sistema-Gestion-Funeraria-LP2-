using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class JornadaLaboral
{
    public int IdJornadaLaboral { get; set; }

    public int? IdLocalidad { get; set; }

    public DateOnly FechaEntrada { get; set; }

    public DateOnly FechaSalida { get; set; }

    public virtual Localidad? IdLocalidadNavigation { get; set; }
}
