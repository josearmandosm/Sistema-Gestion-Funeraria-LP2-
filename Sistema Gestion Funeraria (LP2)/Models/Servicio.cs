using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class Servicio
{
    public int IdServicio { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Costo { get; set; }

    public virtual ICollection<FacturacionesServicio> FacturacionesServicios { get; set; } = new List<FacturacionesServicio>();

    public virtual ICollection<ServiciosCategoria> ServiciosCategoria { get; set; } = new List<ServiciosCategoria>();
}
