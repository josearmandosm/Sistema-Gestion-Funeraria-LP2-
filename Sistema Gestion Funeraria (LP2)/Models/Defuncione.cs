using System;
using System.Collections.Generic;

namespace Sistema_Gestion_Funeraria__LP2_.Models;

public partial class Defuncione
{
    public int IdDefuncion { get; set; }

    public int? IdSala { get; set; }

    public int? IdIdentificacion { get; set; }

    public string Identificacion { get; set; } = null!;

    public string Representante { get; set; } = null!;

    public string RepresentanteTelefono { get; set; } = null!;

    public string RepresentanteDireccion { get; set; } = null!;

    public string NombreDifunto { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public DateOnly FechaFallecimiento { get; set; }

    public TimeOnly HorarioEntrada { get; set; }

    public TimeOnly HorarioSalida { get; set; }

    public byte[] CertificacionDefuncion { get; set; } = null!;

    public virtual ICollection<FacturacionesAtributo> FacturacionesAtributos { get; set; } = new List<FacturacionesAtributo>();

    public virtual ICollection<FacturacionesServicio> FacturacionesServicios { get; set; } = new List<FacturacionesServicio>();

    public virtual TipoIdentificacion? IdIdentificacionNavigation { get; set; }

    public virtual Sala? IdSalaNavigation { get; set; }

    public virtual ICollection<LibroFirma> LibroFirmas { get; set; } = new List<LibroFirma>();
}
