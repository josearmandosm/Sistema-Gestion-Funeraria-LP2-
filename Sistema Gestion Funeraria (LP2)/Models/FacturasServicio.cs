﻿using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class FacturasServicio
{
    public int IdServicio { get; set; }

    public int IdDifunto { get; set; }

    public decimal Costo { get; set; }

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
