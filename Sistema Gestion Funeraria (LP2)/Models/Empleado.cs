using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public int? IdIdentificacion { get; set; }

    public int? IdJornadaLaboral { get; set; }

    public int? IdCargo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public virtual Cargo? IdCargoNavigation { get; set; }

    public virtual TipoIdentificacion? IdIdentificacionNavigation { get; set; }

    public virtual ICollection<JornadaLaboral> JornadaLaborals { get; set; } = new List<JornadaLaboral>();
}
