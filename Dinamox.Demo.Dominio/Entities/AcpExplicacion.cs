using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpExplicacion
{
    public decimal CodExplicacion { get; set; }

    public string DesExplicacion { get; set; } = null!;

    public string ObsExplicacion { get; set; } = null!;

    public virtual ICollection<AcpPreguntum> AcpPregunta { get; set; } = new List<AcpPreguntum>();

    public virtual ICollection<AcpRespuestum> AcpRespuesta { get; set; } = new List<AcpRespuestum>();
}
