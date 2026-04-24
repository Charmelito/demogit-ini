using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcaAtencampo
{
    public int NumAtencion { get; set; }

    public int CodCampo { get; set; }

    public bool IndTipo { get; set; }

    public string TipCampo { get; set; } = null!;

    public string? ValCampo { get; set; }

    public virtual AcpCampo CodCampoNavigation { get; set; } = null!;

    public virtual AcaAtencion NumAtencionNavigation { get; set; } = null!;
}
