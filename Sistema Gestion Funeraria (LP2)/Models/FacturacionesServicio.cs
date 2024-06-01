using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class FacturacionesServicio
{
    public int IdServicio { get; set; }

    public int IdDefuncion { get; set; }

    public decimal Costo { get; set; }

    public virtual Defuncione IdDefuncionNavigation { get; set; } = null!;

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
