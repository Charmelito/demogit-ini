using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class AcpCuestionario
{
    public string CodCuestionario { get; set; } = null!;

    public string DesCuestionario { get; set; } = null!;

    public DateTime FecCreacion { get; set; }

    public string NomUsuarora { get; set; } = null!;

    public virtual ICollection<AcpCampaniacuest> AcpCampaniacuests { get; set; } = new List<AcpCampaniacuest>();

    public virtual ICollection<AcpPreguntum> AcpPregunta { get; set; } = new List<AcpPreguntum>();
}
