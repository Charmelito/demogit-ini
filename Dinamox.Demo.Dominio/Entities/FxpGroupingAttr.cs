using System;
using System.Collections.Generic;

namespace Dinamox.Demo.Dominio.Entities;

public partial class FxpGroupingAttr
{
    /// <summary>
    /// Identificador del grupo
    /// </summary>
    public int IdGrouping { get; set; }

    /// <summary>
    /// Nombre del grupo
    /// </summary>
    public string NomGrouping { get; set; } = null!;

    /// <summary>
    /// Objeto que representa el GropingAttribute
    /// </summary>
    public string JsnConfig { get; set; } = null!;

    public virtual ICollection<FxpProcesoVsParam> FxpProcesoVsParams { get; set; } = new List<FxpProcesoVsParam>();
}
