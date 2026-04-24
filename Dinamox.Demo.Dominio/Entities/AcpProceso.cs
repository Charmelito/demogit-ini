using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpProceso
{
    public decimal CodProcsac { get; set; }

    public int TipProceso { get; set; }

    public string DesProcsac { get; set; } = null!;

    public string? CodPrograma { get; set; }

    public short? NumVersion { get; set; }

    public short? NumSubversion { get; set; }

    public string? CodProceso { get; set; }

    public short? TipInterlocutor { get; set; }

    public string? NomFichero { get; set; }

    public virtual ICollection<AcpProcparam> AcpProcparams { get; set; } = new List<AcpProcparam>();

    public virtual ICollection<AcpRespproceso> AcpRespprocesos { get; set; } = new List<AcpRespproceso>();

    public virtual ICollection<AcpTipodocumento> AcpTipodocumentos { get; set; } = new List<AcpTipodocumento>();

    public virtual AcpInterlocutor? TipInterlocutorNavigation { get; set; }
}
