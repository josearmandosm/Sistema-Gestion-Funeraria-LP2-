using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class Atributo
{
    public int IdAtributo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Estatus { get; set; }

    public decimal Costo { get; set; }

    public virtual ICollection<AtributoCategoria> AtributoCategoria { get; set; } = new List<AtributoCategoria>();

    public virtual ICollection<FacturacionesAtributo> FacturacionesAtributos { get; set; } = new List<FacturacionesAtributo>();
}
