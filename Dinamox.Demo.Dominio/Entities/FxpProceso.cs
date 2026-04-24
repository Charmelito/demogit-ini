using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class FxpProceso
{
    /// <summary>
    /// Indicador unico del proceso
    /// </summary>
    public int IdProceso { get; set; }

    /// <summary>
    /// Nombre del proceso
    /// </summary>
    public string NomProceso { get; set; } = null!;

    /// <summary>
    /// Descripción del proceso
    /// </summary>
    public string DesProceso { get; set; } = null!;

    /// <summary>
    /// Indicador unico del tipo de proceso
    /// </summary>
    public int IdProcesoTipo { get; set; }

    public virtual ICollection<FxpProcesoVsParam> FxpProcesoVsParams { get; set; } = new List<FxpProcesoVsParam>();

    public virtual FxpProcesoTipo IdProcesoTipoNavigation { get; set; } = null!;
}
