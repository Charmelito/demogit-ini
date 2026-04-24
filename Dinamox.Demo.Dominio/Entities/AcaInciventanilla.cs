using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaInciventanilla
{
    public decimal NumInciventanilla { get; set; }

    public decimal CodAbonado { get; set; }

    public decimal NumTelefono { get; set; }

    public string? NumRadicado { get; set; }

    public decimal ValReclamado { get; set; }

    public DateTime FecCreacion { get; set; }

    public decimal TipIncidencia { get; set; }

    public decimal NumRespuesta { get; set; }

    public string ObsComentario { get; set; } = null!;

    public string NomUsuaroracr { get; set; } = null!;

    public string? TipTramite { get; set; }

    public string? CodEstado { get; set; }
}
