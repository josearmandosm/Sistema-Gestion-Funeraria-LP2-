using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal TotalCobertura { get; set; }

    public virtual ICollection<AtributoCategoria> AtributoCategoria { get; set; } = new List<AtributoCategoria>();

    public virtual ICollection<Sala> Salas { get; set; } = new List<Sala>();

    public virtual ICollection<ServiciosCategoria> ServiciosCategoria { get; set; } = new List<ServiciosCategoria>();
}
