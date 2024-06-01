﻿using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class ServiciosCategoria
{
    public int IdServicio { get; set; }

    public int IdCategoria { get; set; }

    public decimal Costo { get; set; }

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
