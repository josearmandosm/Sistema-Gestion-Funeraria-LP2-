using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class FacturacionesAtributo
{
    public int IdAtributo { get; set; }

    public int IdDefuncion { get; set; }

    public decimal Costo { get; set; }

    public virtual Atributo IdAtributoNavigation { get; set; } = null!;

    public virtual Defuncione IdDefuncionNavigation { get; set; } = null!;
}
