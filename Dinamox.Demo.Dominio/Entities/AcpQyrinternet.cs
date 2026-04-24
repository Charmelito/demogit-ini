using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpQyrinternet
{
    public DateTime FecRegistro { get; set; }

    public string ObsComentario { get; set; } = null!;

    public decimal TipIncidencia { get; set; }

    public decimal NumTelefono { get; set; }

    public decimal NroRadportal { get; set; }

    public decimal NroIncidencia { get; set; }

    public string? NomQuejoso { get; set; }

    public string? ApelQuejoso { get; set; }

    public string? NumIdentificacion { get; set; }

    public string? TipIdentificacion { get; set; }

    public string? EmailQuejoso { get; set; }

    public string? DirQuejoso { get; set; }

    public decimal? TelQuejoso { get; set; }
}
