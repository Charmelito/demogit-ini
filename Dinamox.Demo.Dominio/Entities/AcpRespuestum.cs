using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpRespuestum
{
    public string CodCuestionario { get; set; } = null!;

    public decimal NumPregunta { get; set; }

    public decimal NumRespuesta { get; set; }

    public string DesRespuesta { get; set; } = null!;

    public decimal NumOrden { get; set; }

    public string? CodCuestasociado { get; set; }

    public decimal? NumPregasociada { get; set; }

    public decimal? IndFinal { get; set; }

    public int? TipIncidencia { get; set; }

    public decimal? CodExplicacion { get; set; }

    public virtual ICollection<AcaAtendetalle> AcaAtendetalles { get; set; } = new List<AcaAtendetalle>();

    public virtual AcpPreguntum? AcpPreguntum { get; set; }

    public virtual AcpPreguntum AcpPreguntumNavigation { get; set; } = null!;

    public virtual ICollection<AcpRespproceso> AcpRespprocesos { get; set; } = new List<AcpRespproceso>();

    public virtual AcpExplicacion? CodExplicacionNavigation { get; set; }

    public virtual AcpTipoincidencium? TipIncidenciaNavigation { get; set; }
}
