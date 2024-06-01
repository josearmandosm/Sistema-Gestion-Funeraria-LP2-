using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class AtributoCategoria
{
    public int IdAtributo { get; set; }

    public int IdCategoria { get; set; }

    public decimal Costo { get; set; }

    public virtual Atributo IdAtributoNavigation { get; set; } = null!;

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;
}
