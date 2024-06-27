﻿using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string NumDocumento { get; set; } = null!;

    public int IdTipoIdentificacion { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Direccion { get; set; }

    public string Telefono { get; set; } = null!;

    public int IdCargo { get; set; }

    public int IdJornadaLaboral { get; set; }

    public int IdLocalidad { get; set; }

    public virtual Cargo IdCargoNavigation { get; set; } = null!;

    public virtual JornadaLaborale IdJornadaLaboralNavigation { get; set; } = null!;

    public virtual Localidad IdLocalidadNavigation { get; set; } = null!;

    public virtual TipoIdentificacione IdTipoIdentificacionNavigation { get; set; } = null!;
}
