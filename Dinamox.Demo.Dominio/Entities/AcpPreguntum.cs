using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpPreguntum
{
    public string CodCuestionario { get; set; } = null!;

    public decimal NumPregunta { get; set; }

    public string DesPregunta { get; set; } = null!;

    public decimal NumOrden { get; set; }

    public decimal? CodExplicacion { get; set; }

    public virtual ICollection<AcpRespuestum> AcpRespuestumAcpPregunta { get; set; } = new List<AcpRespuestum>();

    public virtual ICollection<AcpRespuestum> AcpRespuestumAcpPreguntumNavigations { get; set; } = new List<AcpRespuestum>();

    public virtual AcpCuestionario CodCuestionarioNavigation { get; set; } = null!;

    public virtual AcpExplicacion? CodExplicacionNavigation { get; set; }
}
